using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projektopgaven_BobedreMaeglerneAS.BusinessLogicLayer;
using System.Data.SqlClient;

namespace Projektopgaven_BobedreMaeglerneAS.DataAccessLayer
{
    class WorksOnDAL
    {
        private static ConnectionSingleton s1 = ConnectionSingleton.Instance(); //creates a new instance of ConnectionSingleton via method Instance
        private static SqlConnection conn = s1.GetConnection(); //get the SqlConnection from ConnectionSingleton method GetConnection

        public WorksOnDAL()
        {

        }
        
        //method to update a recors in WORKS_ON table
        public void Update(WorksOnBLL worksOn)
        {
            //SQL QUERY
            string sqlCommandUpdate = "UPDATE WORKS_ON SET TotHours = @TotHours WHERE worksOn_SagsID = @SagsID";

            //SQL COMMAND + PARAMETERS
            SqlCommand cmdUpdate = new SqlCommand(sqlCommandUpdate, conn);
            cmdUpdate.Parameters.AddWithValue("@SagsID", worksOn.SagsID);
            cmdUpdate.Parameters.AddWithValue("@TotHours", worksOn.TotHours);

            try
            {
                //OPEN CONNECTION
                if (conn.State == System.Data.ConnectionState.Closed)
                    conn.Open();

                //BEGIN TRANSACTION
                Transactions.BeginRepeatableReadTransaction(conn);

                //EXECUTE QUERY
                cmdUpdate.ExecuteNonQuery();

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

        //method to insert the amount of hour worked on a project
        public void IndsætTimer(WorksOnBLL worksOn)
        {
            //SQL QUERY
            string sqlCommandWorksOn = "INSERT INTO WORKS_ON VALUES(@SagsID, @TotHours)";

            //SQL COMMAND + PARAMETERS
            SqlCommand cmdWorksOn = new SqlCommand(sqlCommandWorksOn, conn);

            cmdWorksOn.Parameters.AddWithValue("@SagsID", worksOn.SagsID);
            cmdWorksOn.Parameters.AddWithValue("@TotHours", worksOn.TotHours);

            try
            {
                //OPEN CONNECTION
                if (conn.State == System.Data.ConnectionState.Closed)
                    conn.Open();

                //BEGIN TRANSACTION
                Transactions.BeginRepeatableReadTransaction(conn);

                //EXECUTE QUERY
                cmdWorksOn.ExecuteNonQuery();


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

        //method to retrieve an ejendomsmægler given SagsID and HandelID parameters
        public static EjendomsmæglerBLL HentMægler(int sagsid)
        {
            EjendomsmæglerBLL ejendomsmægler = null;

            //SQL QUERY
            string sqlCommand = "SELECT Sag.MæglerID, Ejendomsmægler.Fnavn, Ejendomsmægler.Enavn " +
                "FROM Sag " +
                "INNER JOIN Ejendomsmægler ON Ejendomsmægler.MæglerID = Sag.MæglerID " +
                "WHERE Sag.SagsID = @SagsID " +
                "AND (sag.Status = 'Lukket (solgt bolig)' " +
                "OR sag.Status = 'Lukket (andre grunde)')";

            //SQL COMMAND + PARAMETERS
            SqlCommand cmd = new SqlCommand(sqlCommand, conn);
            cmd.Parameters.AddWithValue("@SagsID", sagsid);

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
                    //RETRIEVE BoligBLL AND SAVE IN matchingbolig
                    while (reader.Read())
                    {
                        ejendomsmægler = new EjendomsmæglerBLL((int)reader["MæglerID"],
                            reader["Fnavn"].ToString(),
                            reader["Enavn"].ToString());
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

            //RETURN
            return ejendomsmægler;

        }

        //check if the recor with the SagsID passed as a parameter exists in the WORKS_ON table
        public static bool RecordExists(int sagsid)
        {
            int userCount = 0;

            string sqlcommand = "SELECT COUNT (*) FROM WORKS_ON WHERE worksOn_SagsID like @SagsID";

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

        //method to retrieve the price a house has been sold for
        public static int HentSalgspris(string sagsid)
        {
            //INITIALIZATION OF INT PRIS
            int pris = 0;

            //SQL QUERY
            string sqlCommand = "SELECT Handel.Salgspris FROM Handel, Sag WHERE Handel.SagsID = @SagsID";

            //SQL COMMAND + PARAMETERS
            SqlCommand cmd = new SqlCommand(sqlCommand, conn);
            cmd.Parameters.AddWithValue("@SagsID", sagsid);

            try
            {
                //OPEN CONNECTION
                if (conn.State == System.Data.ConnectionState.Closed)
                    conn.Open();
                    
                //BEGIN TRANSACTION
                Transactions.BeginReadCommittedTransaction(conn);

                //RETRIEVE SALGSPRIS AND SAVE IN INT PRIS
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                        pris = reader.GetInt32(0);

                    //CLOSE READER
                    reader.Close();
                }

                //COMMIT OR ROLLBACK
                if (!Transactions.Commit(conn))
                    Transactions.Rollback(conn);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //CLOSE CONNECTION
            if (conn.State == System.Data.ConnectionState.Open)
                conn.Close();
           
            return pris;
        }
    }
}
