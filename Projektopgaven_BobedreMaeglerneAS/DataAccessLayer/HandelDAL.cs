using Projektopgaven_BobedreMaeglerneAS.BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projektopgaven_BobedreMaeglerneAS.PresentationLayer;
using System.Windows.Forms;
using System.Threading;

namespace Projektopgaven_BobedreMaeglerneAS.DataAccessLayer
{
    class HandelDAL
    {
        private static ConnectionSingleton s1 = ConnectionSingleton.Instance(); //creates a new instance of ConnectionSingleton via method Instance
        private static SqlConnection conn = s1.GetConnection(); //get the SqlConnection from ConnectionSingleton method GetConnection

        ComboBox output;

        public HandelDAL(ComboBox cbox)
        {
            output = cbox;
        }

        public HandelDAL()
        {

        }

        /*public List<HandelBLL> SoldProperties(List<HandelBLL> statistik)
        {
            List<HandelBLL> statistik = new List<HandelBLL>();
            string startdate = HandelUI.GetStartDate().Value.ToShortDateString();
            string enddate = HandelUI.GetEndDate().Value.ToShortDateString();
            string sqlCommandHandel = "SELECT * FROM Handel WHERE Handelsdato BETWEEN '" + startdate + "' AND '" + enddate + "+";
            SqlCommand cmd = new SqlCommand(sqlCommandHandel, conn);
            try
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open();
                }
                Transactions.BeginReadCommittedTransaction(conn);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        statistik.Add(new HandelBLL(
                            (int)reader["HandelID"],
                            (DateTime)reader["Handelsdato"],
                            (int)reader["Salgspris"],
                            (int)reader["SagsID"],
                            (int)reader["KøberID"])
                            );
                    }
                    //CLOSE READER
                    reader.Close();
                }
                if (!Transactions.Commit(conn))
                {
                    Transactions.Rollback(conn);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
            return statistik;
        }*/

        #region Threads
        protected delegate void DisplayDelegate(List<HandelBLL> handler);

        protected virtual void DisplayHandel(List<HandelBLL> handler)
        {

            if (output.Items.Count == 0)
            {
                foreach (HandelBLL handel in handler)
                    output.Items.Add(handel.ToString());
            }
            else
            {
                HandelBLL lastIndexItem = HandelBLL.FromString(output.Items[output.Items.Count - 1].ToString());

                //FOREACH ITEM IN THE LIST
                //ADD ITEM TO OUTPUT
                foreach (HandelBLL handel in handler)
                {
                    if (handel.HandelID > lastIndexItem.HandelID)
                        output.Items.Add(handel.ToString());
                }
            }
        }

        //method to retrieve all BoligID to show in the ComboBox of SagUI
        //returns a List of BoligBLL
        protected virtual List<HandelBLL> FetchHandel()
        {
            //INITIALIZE List OF BoligBLL boliger
            List<HandelBLL> handler = new List<HandelBLL>();

            using (var conn = new SqlConnection(s1.GetConnectionString()))
            {
                //SQL QUERY
                string sqlCommand = "SELECT * FROM Handel";

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
                            handler.Add(new HandelBLL((int)reader["HandelID"]));
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
            }

            //RETURN
            return handler;
        }

        public virtual void GenerateHandel()
        {
            while (true) //ALWAYS
            {
                //CHECK IF OUTPUT IS NOT DISPOSED
                if (!output.IsDisposed)
                {
                    //THREAD THAT CALLS FetchBolig WITH A LAMBA FUNCTION (since the method has a return argument)
                    //this will give the user a list of BoligBLL always up to date
                    ThreadStart start = new ThreadStart(() => FetchHandel());
                    Thread t1 = new Thread(start);

                    //the list from FetchBoliger is saved in boliger

                    List<HandelBLL> boliger = FetchHandel();

                    try
                    {
                        //CHECK IF OUTPUT HANDLE HAS NOT BEEN CREATED
                        if (!output.IsHandleCreated)
                            output.CreateControl(); //CREATES OUPUT CONTROL

                        //invoking DisplayBolig
                        output.Invoke(new DisplayDelegate(DisplayHandel), new object[] { boliger });
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

        public void OpretHandel(HandelBLL handel)
        {
            string sqlCommandHandel = $"INSERT INTO Handel VALUES (@Handelsdato, @Salgspris, @SagsID, @KøberID)";

            SqlCommand commandHandel = new SqlCommand(sqlCommandHandel, conn);

            //commandHandel.Parameters.AddWithValue("@HandelID", handel.HandelID);
            commandHandel.Parameters.AddWithValue("@Handelsdato", handel.Handelsdato);
            commandHandel.Parameters.AddWithValue("@Salgspris", handel.Salgspris);
            commandHandel.Parameters.AddWithValue("@SagsID", handel.SagsID);
            commandHandel.Parameters.AddWithValue("@KøberID", handel.KøberID);

            try
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                conn.Open();

                Transactions.BeginRepeatableReadTransaction(conn);
                
                commandHandel.ExecuteNonQuery();

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

        public static HandelBLL FindHandel(HandelBLL handel)
        {
            HandelBLL matchinghandel = null;

            string sqlCommandHandel = "SELECT * FROM Handel WHERE HandelID = @HandelID";

            SqlCommand commandHandel = new SqlCommand(sqlCommandHandel, conn);
            commandHandel.Parameters.AddWithValue("@HandelID", handel.HandelID);

            try
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open();
                }

                Transactions.BeginReadCommittedTransaction(conn);

                using (SqlDataReader reader = commandHandel.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        matchinghandel = new HandelBLL((int)reader["HandelID"],
                            (DateTime)reader["Handelsdato"],
                            (int)reader["Salgspris"],
                            (int)reader["SagsID"],
                            (int)reader["KøberID"]);
                    }

                    if (reader != null)
                    {
                        reader.Close();
                    }
                }

                if (!Transactions.Commit(conn))
                    Transactions.Rollback(conn);
            }

            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }

            if (conn.State == System.Data.ConnectionState.Open)
                conn.Close();

            return matchinghandel;
        }

        public void OpdaterHandel(HandelBLL handel)
        {
            string sqlCommandHandel = "UPDATE Handel SET " +
                "Handelsdato = IsNull(NullIf(@Handelsdato, ''), Handelsdato), " +
                "Salgspris = IsNull(NullIf(@Salgspris, ''), Salgspris), " +
                "SagsID = IsNull(NullIf(@SagsID, ''), SagsID), " +
                "KøberId = IsNull(NullIf(@KøberID, ''), KøberID) " +
                "WHERE HandelID = @HandelID";

            SqlCommand commandHandel = new SqlCommand(sqlCommandHandel, conn);

            commandHandel.Parameters.AddWithValue("@HandelID", handel.HandelID);
            commandHandel.Parameters.AddWithValue("@Handelsdato", handel.Handelsdato);
            commandHandel.Parameters.AddWithValue("@Salgspris", handel.Salgspris);
            commandHandel.Parameters.AddWithValue("@SagsID", handel.SagsID);
            commandHandel.Parameters.AddWithValue("@KøberID", handel.KøberID);

            try
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                    conn.Open();

                Transactions.BeginReadCommittedTransaction(conn);

                commandHandel.ExecuteNonQuery();

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

        public void SletHandel(HandelBLL handel)
        {
            string sqlCommandHandel = $"DELETE FROM Handel WHERE HandelID = @HandelID";

            SqlCommand commandHandel = new SqlCommand(sqlCommandHandel, conn);

            commandHandel.Parameters.AddWithValue("@HandelID", handel.HandelID);

            try
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                    conn.Open();

                Transactions.BeginRepeatableReadTransaction(conn);
                commandHandel.ExecuteNonQuery();

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
    }
}
