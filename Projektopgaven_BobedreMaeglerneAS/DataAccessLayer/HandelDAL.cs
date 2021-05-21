using Projektopgaven_BobedreMaeglerneAS.BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projektopgaven_BobedreMaeglerneAS.PresentationLayer;

namespace Projektopgaven_BobedreMaeglerneAS.DataAccessLayer
{
    class HandelDAL
    {
        private HandelBLL HandelBLL;
        private ConnectionSingleton s1;
        private SqlConnection conn;
        private HandelUI HandelUI;
        public HandelDAL(HandelBLL handelBLL)
        {
            this.HandelBLL = handelBLL;
            this.s1 = ConnectionSingleton.Instance(); //creates a new instance of ConnectionSingleton via method Instance
            this.conn = s1.GetConnection(); //get the SqlConnection from ConnectionSingleton method GetConnection
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
        public void OpretHandel(HandelBLL handel)
        {
            //Connection string
            ConnectionSingleton s1 = ConnectionSingleton.Instance();
            SqlConnection conn = s1.GetConnection();

            string sqlCommandHandel = $"INSERT INTO Handel VALUES (@HandelID, @Handelsdato, @Salgspris, @SagsID, @KøberID)";

            SqlCommand commandHandel = new SqlCommand(sqlCommandHandel, conn);

            commandHandel.Parameters.AddWithValue("@HandelID", handel.HandelID);
            commandHandel.Parameters.AddWithValue("@Handelsdato", handel.Handelsdato);
            commandHandel.Parameters.AddWithValue("@Salgspris", handel.Salgspris);
            commandHandel.Parameters.AddWithValue("@SagsID", handel.SagsID);
            commandHandel.Parameters.AddWithValue("@KøberID", handel.KøberID);

            try
            {
                //if (conn.State == System.Data.ConnectionState.Closed)
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

            finally
            {
                if (conn != null)
                    conn.Close();
            }
        }


        public HandelBLL FindHandel(HandelBLL handel)
        {
            //Connection string
            ConnectionSingleton s1 = ConnectionSingleton.Instance();
            SqlConnection conn = s1.GetConnection();

            string sqlCommandHandel = "SELECT * FROM Handel WHERE HandelID = @HandelID";

            SqlCommand commandHandel = new SqlCommand(sqlCommandHandel, conn);

            commandHandel.Parameters.AddWithValue("@HandelID", handel.HandelID);

            try
            {
                conn.Open();

                Transactions.BeginReadCommittedTransaction(conn);
                commandHandel.ExecuteNonQuery();

                if (!Transactions.Commit(conn))
                    Transactions.Rollback(conn);

                using (SqlDataReader reader = commandHandel.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        HandelBLL matchinghandel = new HandelBLL((int)reader["HandelID"],
                            (DateTime)reader["Handelsdato"],
                            (int)reader["Salgspris"],
                            (int)reader["SagsID"],
                            (int)reader["KøberID"]);

                        return matchinghandel;
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


        public void OpdaterHandel(HandelBLL handel)
        {
            //Connection string
            ConnectionSingleton s1 = ConnectionSingleton.Instance();
            SqlConnection conn = s1.GetConnection();

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

            finally
            {
                if (conn != null)
                    conn.Close();
            }
        }


        public void SletHandel(HandelBLL handel)
        {
            //Connection string
            ConnectionSingleton s1 = ConnectionSingleton.Instance();
            SqlConnection conn = s1.GetConnection();

            string sqlCommandHandel = $"DELETE FROM Handel WHERE HandelID = @HandelID";

            SqlCommand commandHandel = new SqlCommand(sqlCommandHandel, conn);

            commandHandel.Parameters.AddWithValue("@HandelID", handel.HandelID);

            try
            {
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

            finally
            {
                if (conn != null)
                    conn.Close();
            }

        }
    }
}
