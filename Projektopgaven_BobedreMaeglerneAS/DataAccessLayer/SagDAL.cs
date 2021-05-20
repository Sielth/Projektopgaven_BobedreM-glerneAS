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
        private SagBLL SagBLL;
        private ConnectionSingleton s1;
        private SqlConnection conn;

        private ComboBox output;

        public SagDAL(SagBLL sagBLL)
        {
            this.SagBLL = sagBLL;
        }

        public SagDAL(ComboBox cBox)
        {
            output = cBox;
            this.s1 = ConnectionSingleton.Instance(); //creates a new instance of ConnectionSingleton via method Instance
            this.conn = s1.GetConnection(); //get the SqlConnection from ConnectionSingleton method GetConnection
        }

        #region Threads
        protected delegate void DisplayDelegate(List<SagBLL> sager);

        protected virtual void DisplaySag(List<SagBLL> sager)
        {
            //CLEAR OUTPUT EVERY TIME
            //so that we don't have an infinite list
            output.Items.Clear();

            //FOREACH ITEM IN THE LIST
            //ADD ITEM TO OUTPUT
            foreach (SagBLL sag in sager)
                output.Items.Add(sag.ToString());
        }

        //method to retrieve all BoligID to show in the ComboBox of SagUI
        //returns a List of BoligBLL
        protected virtual List<SagBLL> FetchSag()
        {
            //INITIALIZE List OF BoligBLL boliger
            List<SagBLL> sager = new List<SagBLL>();

            using (var conn = new SqlConnection(ConnectionSingleton.ConnectionString))
            {
                //SQL QUERY
                string sqlCommand = "SELECT * FROM Sag";

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

        public void OpretSag(SagBLL sag)
        {
            //Connection string
            ConnectionSingleton s1 = ConnectionSingleton.Instance();
            SqlConnection conn = s1.GetConnection();

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

            finally
            {
                if (conn != null)
                    conn.Close();
            }
        }

        public SagBLL FindSag(SagBLL sag)
        {
            ConnectionSingleton s1 = ConnectionSingleton.Instance();
            SqlConnection conn = s1.GetConnection();

            SagBLL matchingsag = null;

            string sqlCommandSag = "SELECT * FROM Sag WHERE SagsID = @SagsID";

            SqlCommand commandSag = new SqlCommand(sqlCommandSag, conn);

            commandSag.Parameters.AddWithValue("@SagsID", sag.SagsID);

            try
            {
                conn.Open();

                Transactions.BeginReadCommittedTransaction(conn);
                commandSag.ExecuteNonQuery();

                if (!Transactions.Commit(conn))
                    Transactions.Rollback(conn);

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
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }

            finally
            {
                if (conn != null)
                    conn.Close();
            }

            return matchingsag;

        }

        public void OpdaterSag(SagBLL sag)
        {
            ConnectionSingleton s1 = ConnectionSingleton.Instance();
            SqlConnection conn = s1.GetConnection();

            //ConnectionSingleton s1 = ConnectionSingleton.Instance();

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

            finally
            {
                if (conn != null)
                    conn.Close();
            }
        }

        public void SletSag(SagBLL sag)
        {
            //Connection string
            ConnectionSingleton s1 = ConnectionSingleton.Instance();
            SqlConnection conn = s1.GetConnection();

            string sqlCommandSag = $"DELETE FROM Sag WHERE SagsID = @SagsID";

            SqlCommand commandSag = new SqlCommand(sqlCommandSag, conn);

            commandSag.Parameters.AddWithValue("@SagsID", sag.SagsID);

            try
            {
                Transactions.BeginRepeatableReadTransaction(conn);
                commandSag.ExecuteNonQuery();

                if (!Transactions.Commit(conn))
                    Transactions.Rollback(conn);
            }

            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }

            finally
            {
                if (conn != null)
                    conn.Close();
            }
        }
    }
}
