using Projektopgaven_BobedreMaeglerneAS.BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Projektopgaven_BobedreMaeglerneAS.DataAccessLayer
{
    class SagDAL
    {
        private static ConnectionSingleton s1 = ConnectionSingleton.Instance(); //creates a new instance of ConnectionSingleton via method Instance
        private static SqlConnection conn = s1.GetConnection(); //get the SqlConnection from ConnectionSingleton method GetConnection

        private ComboBox output;

        public SagDAL()
        {

        }

        public SagDAL(ComboBox cBox)
        {
            output = cBox;
        }

        #region Threads
        protected delegate void DisplayDelegate(List<SagBLL> sager);

        protected virtual void DisplaySag(List<SagBLL> sager)
        {
            //CLEAR OUTPUT EVERY TIME
            //so that we don't have an infinite list
            //output.Items.Clear();

            if (output.Items.Count == 0)
            {
                foreach (SagBLL sag in sager)
                    output.Items.Add(sag.ToString());
            }
            else
            {
                SagBLL lastIndexItem = SagBLL.FromString(output.Items[output.Items.Count - 1].ToString());

                //FOREACH ITEM IN THE LIST
                //ADD ITEM TO OUTPUT
                foreach (SagBLL sag in sager)
                {
                    if (sag.SagsID > lastIndexItem.SagsID)
                        output.Items.Add(sag.ToString());
                }
            }
        }

        //method to retrieve all BoligID to show in the ComboBox of SagUI
        //returns a List of BoligBLL
        protected virtual List<SagBLL> FetchSag()
        {
            //INITIALIZE List OF BoligBLL boliger
            List<SagBLL> sager = new List<SagBLL>();

            using (var conn = new SqlConnection(s1.GetConnectionString()))
            {
                //SQL QUERY
                string sqlCommand = "SELECT * FROM Sag ORDER BY SagsID";

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
                            sager.Add(new SagBLL((int)reader["SagsID"], reader["Status"].ToString()));
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
            return sager;
        }

        public virtual void GenerateSag()
        {
            while (true) //ALWAYS
            {
                //CHECK IF OUTPUT IS NOT DISPOSED
                if (!output.IsDisposed)
                {
                    //THREAD THAT CALLS FetchBolig WITH A LAMBA FUNCTION (since the method has a return argument)
                    //this will give the user a list of BoligBLL always up to date
                    ThreadStart start = new ThreadStart(() => FetchSag());
                    Thread t1 = new Thread(start);

                    //the list from FetchBoliger is saved in boliger

                    List<SagBLL> sager = FetchSag();

                    try
                    {
                        //CHECK IF OUTPUT HANDLE HAS NOT BEEN CREATED
                        if (!output.IsHandleCreated)
                            output.CreateControl(); //CREATES OUPUT CONTROL

                        //invoking DisplayBolig
                        output.Invoke(new DisplayDelegate(DisplaySag), new object[] { sager });
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

        #region Opret Sag
        public void OpretSag(SagBLL sag)
        {
            string sqlCommandSag = $"INSERT INTO Sag VALUES(@Status, @BoligID, @SælgerID, @MæglerID)";

            SqlCommand commandSag = new SqlCommand(sqlCommandSag, conn);

            commandSag.Parameters.AddWithValue("@Status", sag.Status);
            commandSag.Parameters.AddWithValue("@BoligID", sag.BoligID);
            commandSag.Parameters.AddWithValue("@SælgerID", sag.SælgerID);
            commandSag.Parameters.AddWithValue("@MæglerID", sag.MæglerID);

            try
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                conn.Open();

                Transactions.BeginRepeatableReadTransaction(conn);

                commandSag.ExecuteNonQuery();

                if (!Transactions.Commit(conn))
                    Transactions.Rollback(conn);
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }

            if (conn.State == System.Data.ConnectionState.Open)
                conn.Close();
        }
        #endregion

        #region Hent / Opdater Sag
        public static SagBLL HentSagViaID(SagBLL sagToFind)
        {
            SagBLL matchingsag = null;

            string sqlCommandSag = "SELECT * FROM Sag WHERE SagsID = @SagsID";

            SqlCommand commandSag = new SqlCommand(sqlCommandSag, conn);
            commandSag.Parameters.AddWithValue("@SagsID", sagToFind.SagsID);

            try
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                    conn.Open();

                Transactions.BeginReadCommittedTransaction(conn);

                using (SqlDataReader reader = commandSag.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        matchingsag = new SagBLL((int)reader["SagsID"],
                            reader["Status"].ToString(),
                            (int)reader["BoligID"],
                            (int)reader["SælgerID"],
                            (int)reader["MæglerID"]);
                    }

                    //CLOSE READER
                    if (reader != null)
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

            //RETURN
            return matchingsag;
        }

        public static SagBLL HentSag(SagBLL sagToFind)
        {
            //initialize SagBLL matchingsag
            SagBLL matchingsag = null;

            //SQL QUERY
            string sqlCommandSag = "SELECT * FROM Sag WHERE " +
                "SagsID LIKE @SagsID OR " +
                "Status LIKE @Status AND " +
                "BoligID LIKE @BoligID AND " +
                "SælgerID LIKE @SælgerID AND " +
                "MæglerID LIKE @MæglerID ";

            //SQL COMMAND + PARAMETERS
            SqlCommand cmdSag = new SqlCommand(sqlCommandSag, conn);
            cmdSag.Parameters.AddWithValue("@SagsID", sagToFind.SagsID);
            cmdSag.Parameters.AddWithValue("@Status", sagToFind.Status);
            cmdSag.Parameters.AddWithValue("@BoligID", sagToFind.BoligID);
            cmdSag.Parameters.AddWithValue("@SælgerID", sagToFind.SælgerID);
            cmdSag.Parameters.AddWithValue("@MæglerID", sagToFind.MæglerID);

            try
            {
                //OPEN CONNECTION
                if (conn.State == System.Data.ConnectionState.Closed)
                    conn.Open();

                //BEGIN TRANSACTION
                Transactions.BeginReadCommittedTransaction(conn);

                //EXECUTE READER (QUERY)
                using (SqlDataReader reader = cmdSag.ExecuteReader())
                {
                    //RETRIEVE SagBLL AND SAVE IN matchingsag
                    while (reader.Read())
                    {
                        matchingsag = new SagBLL((int)reader["SagsID"],
                            reader["Status"].ToString(),
                            (int)reader["BoligID"],
                            (int)reader["SælgerID"],
                            (int)reader["MæglerID"]);
                    }

                    //CLOSE READER
                    if (reader != null)
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

            //RETURN
            return matchingsag;
        }

        public void OpdaterSag(SagBLL sag)
        {
            //Tjekker om tekstboxe var tomme og undlader at opdaterer informationer for dem der er tomme
            string sqlCommandSag = "UPDATE Sag SET " +
                "Status = IsNull(NullIf(@Status, ''), Status), " +
                "BoligID = IsNull(NullIf(@BoligID, ''), BoligID), " +
                "SælgerID = IsNull(NullIf(@SælgerID, ''), SælgerID), " +
                "MæglerID = IsNull(NullIf(@MæglerID, ''), MæglerID) " +
                "WHERE SagsID = @SagsID";
            
            //Sender input til database for at opdatere
            SqlCommand commandSag = new SqlCommand(sqlCommandSag, conn);
         
            commandSag.Parameters.AddWithValue("@Status", sag.Status);
            commandSag.Parameters.AddWithValue("@BoligID", sag.BoligID);
            commandSag.Parameters.AddWithValue("@SælgerID", sag.SælgerID);
            commandSag.Parameters.AddWithValue("@MæglerID", sag.MæglerID);
            commandSag.Parameters.AddWithValue("@SagsID", sag.SagsID);

            try
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                    conn.Open();

                Transactions.BeginReadCommittedTransaction(conn);

                commandSag.ExecuteNonQuery();

                if (!Transactions.Commit(conn))
                    Transactions.Rollback(conn);
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }

            if (conn.State == System.Data.ConnectionState.Open)
                conn.Close();
        }
        #endregion

        #region Slet Sag
        public void SletSag(SagBLL sag)
        {
            string sqlCommandSag = $"DELETE FROM Sag WHERE SagsID = @SagsID";

            SqlCommand commandSag = new SqlCommand(sqlCommandSag, conn);

            commandSag.Parameters.AddWithValue("@SagsID", sag.SagsID);

            try
            {
                //OPEN CONNECTION
                if (conn.State == System.Data.ConnectionState.Closed)
                    conn.Open();

                //BEGIN TRANSACTION
                Transactions.BeginRepeatableReadTransaction(conn);

                //EXECUTE QUERY
                commandSag.ExecuteNonQuery();

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

        //check if the recor with the SagsID passed as a parameter exists in the Sag table
        public static bool SagExists(int sagsid)
        {
            int userCount = 0;

            //SQL QUERY
            string sqlcommand = "SELECT COUNT (*) FROM Sag WHERE SagsID like @SagsID";

            //SQL COMMAND + PARAMETERS
            SqlCommand cmd = new SqlCommand(sqlcommand, conn);
            cmd.Parameters.AddWithValue("@SagsID", sagsid);

            try
            {
                //OPEN CONNECTION
                if (conn.State == System.Data.ConnectionState.Closed)
                    conn.Open();

                //BEGIN TRANSACTION
                Transactions.BeginReadCommittedTransaction(conn);

                userCount = (int)cmd.ExecuteScalar();

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

            if (userCount > 0)
                return true;
            else
                return false;
        }
    }
}
