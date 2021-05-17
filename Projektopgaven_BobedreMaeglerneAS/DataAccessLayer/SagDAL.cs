using Projektopgaven_BobedreMaeglerneAS.BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektopgaven_BobedreMaeglerneAS.DataAccessLayer
{
    class SagDAL
    {
        private SagBLL SagBLL;

        public SagDAL(SagBLL sagBLL)
        {
            this.SagBLL = sagBLL;
        }



        public void OpretSag(SagBLL sag)
        {
            //Connection string
            ConnectionSingleton s1 = ConnectionSingleton.Instance();
            SqlConnection conn = s1.GetConnection();

            string sqlCommandSag = $"INSERT INTO Sag VALUES (@SagsID, @Status, @BoligID, @SælgerID, @MæglerID)";

            SqlCommand commandSag = new SqlCommand(sqlCommandSag, conn);

            commandSag.Parameters.AddWithValue("@SagsID", sag.SagsID);
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

            string sqlCommandSag = "SELECT * FROM Sag WHERE SagsID = @SagsID";

            SqlCommand commandSag = new SqlCommand(sqlCommandSag, conn);

            commandSag.Parameters.AddWithValue("@SagID", sag.SagsID);
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
                        SagBLL matchingsag = new SagBLL((int)reader["SagsID"],
                            reader["Status"].ToString(),
                            (int)reader["BoligID"],
                            (int)reader["SælgerID"],
                            (int)reader["Mægler"]);

                        return matchingsag;
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
            return null;
        }

        public void OpdaterSag(SagBLL sag)
        {
            ConnectionSingleton s1 = ConnectionSingleton.Instance();
            SqlConnection conn = s1.GetConnection();

            //ConnectionSingleton s1 = ConnectionSingleton.Instance();

            //Tjekker om tekstboxe var tomme og undlader at opdaterer informationer for dem der er tomme
            string sqlCommandSag = "UPDATE Sag SET" +
                "Status = IsNull(NullIf(@Status, ''), Status)," +
                "BoligID = IsNull(NullIf(@BoligID, ''), BolgID)," +
                "SælgerID = IsNull(NullIf(@SælgerID, ''), SælgerID)," +
                "MæglerID = IsNull(NullIf(@MæglerID, ''), MæglerID)," +
                "WHERE SagsID = @SagsID";
            //Sender input til database for at opdatere
            SqlCommand cmdSag = new SqlCommand(sqlCommandSag);
            cmdSag.Parameters.AddWithValue("@Status", sag.Status);
            cmdSag.Parameters.AddWithValue("@BoligID", sag.BoligID);
            cmdSag.Parameters.AddWithValue("@SælgerID", sag.SælgerID);
            cmdSag.Parameters.AddWithValue("@MæglerID", sag.MæglerID);
            try
            {
                conn.Open();

                Transactions.BeginReadCommittedTransaction(conn);
                cmdSag.ExecuteNonQuery();

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
