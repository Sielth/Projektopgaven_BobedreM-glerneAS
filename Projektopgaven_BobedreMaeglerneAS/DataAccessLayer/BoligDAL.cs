using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Projektopgaven_BobedreMæglerneAS;
using Projektopgaven_BobedreMaeglerneAS.BusinessLogicLayer;
using System.Threading;
using System.Windows.Forms;

//MEMO
//REMEMBER TO ADD CHECKS FOR READ, UPDATE, DELETE => IF BOLIG EXISTS, THEN EXECUTE QUERY
//NOT NECESSARY FOR CREATE SINCE SQL IS IN CHARGE OF BOLIG ID

namespace Projektopgaven_BobedreMaeglerneAS.DataAccessLayer
{
    class BoligDAL
    {
        private BoligBLL BoligBLL;
        private ConnectionSingleton s1;
        private SqlConnection conn;

        private ComboBox output;
        
        //BoligDAL constructor
        public BoligDAL(BoligBLL boligBLL)
        {
            this.BoligBLL = boligBLL;
            this.s1 = ConnectionSingleton.Instance(); //creates a new instance of ConnectionSingleton via method Instance
            this.conn = s1.GetConnection(); //get the SqlConnection from ConnectionSingleton method GetConnection
        }

        public BoligDAL(ListBox lbox) 
        {
            this.s1 = ConnectionSingleton.Instance(); //creates a new instance of ConnectionSingleton via method Instance
            this.conn = s1.GetConnection(); //get the SqlConnection from ConnectionSingleton method GetConnection
        }

        #region Threads
        public BoligDAL(ComboBox cBox)
        {
            output = cBox;
            this.s1 = ConnectionSingleton.Instance(); //creates a new instance of ConnectionSingleton via method Instance
            this.conn = s1.GetConnection(); //get the SqlConnection from ConnectionSingleton method GetConnection
        }

        protected delegate void DisplayDelegate(List<BoligBLL> boliger);

        protected virtual void DisplayBolig(List<BoligBLL> boliger)
        {
            //CLEAR OUTPUT EVERY TIME
            //so that we don't have an infinite list
            output.Items.Clear();

            //FOREACH ITEM IN THE LIST
            //ADD ITEM TO OUTPUT
            foreach (BoligBLL bolig in boliger)
                output.Items.Add(bolig.ToString());
        }

        //method to retrieve all BoligID to show in the ComboBox of SagUI
        //returns a List of BoligBLL
        protected virtual List<BoligBLL> FetchBolig()
        {
            //INITIALIZE List OF BoligBLL boliger
            List<BoligBLL> boliger = new List<BoligBLL>();

            using (var conn = new SqlConnection(ConnectionSingleton.ConnectionString))
            {
                //SQL QUERY
                string sqlCommand = "SELECT * FROM Bolig";

                //SQL COMMAND
                SqlCommand cmd = new SqlCommand(sqlCommand, conn);

                try
                {
                    //OPEN CONNECTION
                    if (conn.State == System.Data.ConnectionState.Closed)
                        conn.Open();

                    //BEGIN TRANSACTION
                    Transactions.BeginReadCommittedTransaction(conn);

                    //EXECUTE READER (QUERY)
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        //RETRIEVE BoligBLL AND ADD IN boliger
                        while (reader.Read())
                        {
                            boliger.Add(new BoligBLL((int)reader["BoligID"], reader["Vej"].ToString(), (int)reader["Postnummer"]));
                        }

                        //CLOSE READER
                        reader.Close();
                    }

                    //COMMIT OR ROLLBACK
                    if (!Transactions.Commit(conn))
                        Transactions.Rollback(conn);

                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                //CLOSE CONNECTION
                if (conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }

            //RETURN
            return boliger;
        }

        public virtual void GenerateBolig()
        {
            while (true) //ALWAYS
            {
                //CHECK IF OUTPUT IS NOT DISPOSED
                if (!output.IsDisposed)
                {
                    //THREAD THAT CALLS FetchBolig WITH A LAMBA FUNCTION (since the method has a return argument)
                    //this will give the user a list of BoligBLL always up to date
                    ThreadStart start = new ThreadStart(() => FetchBolig());
                    Thread t1 = new Thread(start);

                    //the list from FetchBoliger is saved in boliger

                    List<BoligBLL> boliger = FetchBolig();

                    try
                    {
                        //CHECK IF OUTPUT HANDLE HAS NOT BEEN CREATED
                        if (!output.IsHandleCreated)
                            output.CreateControl(); //CREATES OUPUT CONTROL

                        //invoking DisplayBolig
                        output.Invoke(new DisplayDelegate(DisplayBolig), new object[] { boliger });
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                    Thread.Sleep(6000);
                }
            }
        }
        #endregion

        #region Opret Bolig
        //method to create a new BoligBLL
        public void OpretBolig(BoligBLL bolig)
        {
            //SQL QUERY
            string sqlCommandBolig = "INSERT INTO Bolig VALUES (@Vej, @Postnummer, @Type, @Værelser, @Etager, @Kvadratmeter, @Udbudspris, @HaveFlag, @Bygningsår, @RenoveringsÅr)";

            //SQL COMMAND + PARAMETERS
            SqlCommand cmdBolig = new SqlCommand(sqlCommandBolig, conn);
            cmdBolig.Parameters.AddWithValue("@Vej", bolig.Vej);
            cmdBolig.Parameters.AddWithValue("@Postnummer", bolig.Postnummer);
            cmdBolig.Parameters.AddWithValue("@Type", bolig.Type);
            cmdBolig.Parameters.AddWithValue("@Værelser", bolig.Værelser);
            cmdBolig.Parameters.AddWithValue("@Etager", bolig.Etager);
            cmdBolig.Parameters.AddWithValue("@Kvadratmeter", bolig.Kvadratmeter);
            cmdBolig.Parameters.AddWithValue("@Udbudspris", bolig.CalculateUdbudsPris()); ;
            cmdBolig.Parameters.AddWithValue("@HaveFlag", bolig.Have);
            cmdBolig.Parameters.AddWithValue("@Bygningsår", bolig.Bygningsår);
            cmdBolig.Parameters.AddWithValue("@RenoveringsÅr", bolig.RenoveringsÅr);

            try
            {
                //OPEN CONNECTION
                if (conn.State == System.Data.ConnectionState.Closed)
                    conn.Open();

                //BEGIN TRANSACTION
                Transactions.BeginRepeatableReadTransaction(conn);

                //EXECUTE QUERY
                cmdBolig.ExecuteNonQuery();

                //COMMIT OR ROLLBACK
                if (!Transactions.Commit(conn))
                    Transactions.Rollback(conn);
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }

            //CLOSE CONNECTION
            if (conn.State == System.Data.ConnectionState.Open)
                conn.Close();
        }
        #endregion

        #region Hent Bolig
        //method to retrieve a BoligBLL using only BoligID
        public BoligBLL HentBoligViaID(BoligBLL bolig)
        {
            //INITIALIZE BoligBLL matchingbolig
            BoligBLL matchingbolig = null;

            //SQL QUERY
            string sqlCommanBolig = "SELECT * FROM Bolig WHERE " +
                "BoligID = @BoligID";
            
            //SQL COMMAND + PARAMETERS
            SqlCommand cmdBolig = new SqlCommand(sqlCommanBolig, conn);
            cmdBolig.Parameters.AddWithValue("@BoligID", bolig.BoligID);

            try
            {
                //OPEN CONNECTION
                if (conn.State == System.Data.ConnectionState.Closed)
                    conn.Open();

                //BEGIN TRANSACTION
                Transactions.BeginReadCommittedTransaction(conn);

                //EXECUTE READER (QUERY)
                using (SqlDataReader reader = cmdBolig.ExecuteReader())
                {
                    //RETRIEVE BoligBLL AND SAVE IN matchingbolig
                    while (reader.Read())
                    {
                        matchingbolig = new BoligBLL((int)reader["BoligID"],
                            reader["Vej"].ToString(),
                            (int)reader["Postnummer"],
                            reader["Type"].ToString(),
                            (int)reader["Værelser"],
                            (int)reader["Etager"],
                            (int)reader["Kvadratmeter"],
                            (int)reader["Udbudspris"],
                            (bool)reader["HaveFlag"],
                            (DateTime)reader["Bygningsår"],
                            (DateTime)reader["RenoveringsÅr"]);
                    }

                    //CLOSE READER
                    reader.Close();
                }

                //COMMIT OR ROLLBACK
                if (!Transactions.Commit(conn))
                    Transactions.Rollback(conn);

                //RETURN
                return matchingbolig;
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }

            //CLOSE CONNECTION
            if (conn.State == System.Data.ConnectionState.Open)
                conn.Close();

            return null;
        }

        //method to retrieve a BoligBLL using either BoligID or a combination of all other attributes
        public BoligBLL HentBolig(BoligBLL bolig)
        {
            //INITIALIZE BoligBLL matchingbolig
            BoligBLL matchingbolig = null;

            //SQL QUERY
            string sqlCommanBolig = "SELECT * FROM Bolig WHERE " +
                "BoligID LIKE @BoligID OR " +
                "Vej Like @Vej AND " +
                "Postnummer LIKE @Postnummer AND " +
                "Type LIKE @Type AND " +
                "Værelser LIKE @Værelser AND " +
                "Etager LIKE @Etager AND " +
                "Kvadratmeter LIKE @Kvadratmeter AND " +
                //"Udbudspris <= @Udbudspris AND " +
                "HaveFlag LIKE @HaveFlag AND " +
                "Bygningsår LIKE @Bygningsår AND " +
                "RenoveringsÅr LIKE @RenoveringsÅr ";

            //SQL COMMAND + PARAMETERS
            SqlCommand cmdBolig = new SqlCommand(sqlCommanBolig, conn);
            cmdBolig.Parameters.AddWithValue("@BoligID", bolig.BoligID);
            cmdBolig.Parameters.AddWithValue("@Vej", bolig.Vej);
            cmdBolig.Parameters.AddWithValue("@Postnummer", bolig.Postnummer);
            cmdBolig.Parameters.AddWithValue("@Type", bolig.Type);
            cmdBolig.Parameters.AddWithValue("@Værelser", bolig.Værelser);
            cmdBolig.Parameters.AddWithValue("@Etager", bolig.Etager);
            cmdBolig.Parameters.AddWithValue("@Kvadratmeter", bolig.Kvadratmeter);
            //cmdBolig.Parameters.AddWithValue("@Udbudspris", bolig.Udbudspris);
            cmdBolig.Parameters.AddWithValue("@HaveFlag", bolig.Have);
            cmdBolig.Parameters.AddWithValue("@Bygningsår", bolig.Bygningsår);
            cmdBolig.Parameters.AddWithValue("@RenoveringsÅr", bolig.RenoveringsÅr);

            try
            {
                //OPEN CONNECTION
                if (conn.State == System.Data.ConnectionState.Closed)
                    conn.Open();

                //BEGIN TRANSACTION
                Transactions.BeginReadCommittedTransaction(conn);

                //EXECUTE READER (QUERY)
                using (SqlDataReader reader = cmdBolig.ExecuteReader())
                {
                    //RETRIEVE BoligBLL AND SAVE IN matchingbolig
                    while (reader.Read())
                    {
                        matchingbolig = new BoligBLL((int)reader["BoligID"],
                            reader["Vej"].ToString(),
                            (int)reader["Postnummer"],
                            reader["Type"].ToString(),
                            (int)reader["Værelser"],
                            (int)reader["Etager"],
                            (int)reader["Kvadratmeter"],
                            (int)reader["Udbudspris"],
                            (bool)reader["HaveFlag"],
                            (DateTime)reader["Bygningsår"],
                            (DateTime)reader["RenoveringsÅr"]);
                    }

                    //CLOSE READER
                    reader.Close();
                }

                //COMMIT OR ROLLBACK
                if (!Transactions.Commit(conn))
                    Transactions.Rollback(conn);

                //RETURN
                return matchingbolig;
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }

            //CLOSE CONNECTION
            if (conn.State == System.Data.ConnectionState.Open)
                conn.Close();

            return null;
        }
        #endregion

        #region Opdater Bolig
        public void OpdaterBolig(BoligBLL bolig)
        {
            //SQL QUERY
            string sqlCommandBolig = "UPDATE Bolig SET " +
                "Vej = IsNull(NullIf(@Vej, ''), Vej), " +
                "Postnummer = IsNull(NullIf(@Postnummer, ''), Postnummer), " +
                "Type = IsNull(NullIf(@Type, ''), Type), " +
                "Værelser = IsNull(NullIf(@Værelser, ''), Værelser), " +
                "Etager = IsNull(NullIf(@Etager, ''), Etager), " +
                "Kvadratmeter = IsNull(NullIf(@Kvadratmeter, ''), Kvadratmeter), " +
                "Udbudspris = IsNull(NullIf(@Udbudspris, ''), Udbudspris), " +
                "HaveFlag = IsNull(NullIf(@HaveFlag, ''), HaveFlag), " +
                "Bygningsår = IsNull(NullIf(@Bygningsår, ''), Bygningsår), " +
                "RenoveringsÅr = IsNull(NullIf(@RenoveringsÅr, ''), RenoveringsÅr) " +
                "WHERE BoligID = @BoligID";

            //SQL COMMAND + PARAMETERS
            SqlCommand cmdBolig = new SqlCommand(sqlCommandBolig, conn);
            cmdBolig.Parameters.AddWithValue("@Vej", bolig.Vej);
            cmdBolig.Parameters.AddWithValue("@Postnummer", bolig.Postnummer);
            cmdBolig.Parameters.AddWithValue("@Type", bolig.Type);
            cmdBolig.Parameters.AddWithValue("@Værelser", bolig.Værelser);
            cmdBolig.Parameters.AddWithValue("@Etager", bolig.Etager);
            cmdBolig.Parameters.AddWithValue("@Kvadratmeter", bolig.Kvadratmeter);
            cmdBolig.Parameters.AddWithValue("@Udbudspris", bolig.CalculateUdbudsPris());
            cmdBolig.Parameters.AddWithValue("@HaveFlag", bolig.Have);
            cmdBolig.Parameters.AddWithValue("@Bygningsår", bolig.Bygningsår);
            cmdBolig.Parameters.AddWithValue("@RenoveringsÅr", bolig.RenoveringsÅr);
            cmdBolig.Parameters.AddWithValue("@BoligID", bolig.BoligID);

            try
            {
                //OPEN CONNECTION
                if (conn.State == System.Data.ConnectionState.Closed)
                    conn.Open();

                //BEGIN TRANSACTION
                Transactions.BeginReadCommittedTransaction(conn);

                //EXECUTE QUERY
                cmdBolig.ExecuteNonQuery();

                //COMMIT OR ROLLBACK
                if (!Transactions.Commit(conn))
                    Transactions.Rollback(conn);
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }

            //CLOSE CONNECTION
            if (conn.State == System.Data.ConnectionState.Open)
                conn.Close();
        }
        #endregion

        #region Slet Bolig
        public void SletBolig(BoligBLL bolig)
        {
            //SQL QUERY
            string sqlCommandBolig = "DELETE FROM Bolig WHERE BoligID = @BoligID";

            //SQL COMMAND + PARAMETERS
            SqlCommand cmdBolig = new SqlCommand(sqlCommandBolig, conn);
            cmdBolig.Parameters.AddWithValue("@BoligID", bolig.BoligID);

            try
            {
                //OPEN CONNECTION
                if (conn.State == System.Data.ConnectionState.Closed)
                    conn.Open();

                //BEGIN TRANSACTION
                Transactions.BeginRepeatableReadTransaction(conn);

                //EXECUTE QUERY
                cmdBolig.ExecuteNonQuery();

                //COMMIT OR ROLLBACK
                if (!Transactions.Commit(conn))
                    Transactions.Rollback(conn);
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }

            //CLOSE CONNECTION
            if (conn.State == System.Data.ConnectionState.Open)
                conn.Close();
        }
        #endregion
    }
}