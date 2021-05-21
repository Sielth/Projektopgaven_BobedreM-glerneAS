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
        private WorksOnBLL WorksOnBLL;

        private ConnectionSingleton s1;
        private SqlConnection conn;

        public WorksOnDAL(WorksOnBLL worksOnBLL)
        {
            this.WorksOnBLL = worksOnBLL;

            this.s1 = ConnectionSingleton.Instance(); //creates a new instance of ConnectionSingleton via method Instance
            this.conn = s1.GetConnection(); //get the SqlConnection from ConnectionSingleton method GetConnection
        }

        public void IndsætTimer(WorksOnBLL worksOn)
        {
            using (var conn = new SqlConnection(ConnectionSingleton.ConnectionString))
            {
                //SQL QUERY
                string sqlCommandWorksOn = "INSERT INTO WORKS_ON (@HandelID, @TotHours)";

                //SQL COMMAND + PARAMETERS
                SqlCommand cmdWorksOn = new SqlCommand(sqlCommandWorksOn, conn);
                cmdWorksOn.Parameters.AddWithValue("@HandelID", worksOn.HandelID);
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
        }

        public EjendomsmæglerBLL HentMægler(int sagsid, int handelid)
        {
            EjendomsmæglerBLL ejendomsmægler = null;

            using (var conn = new SqlConnection(ConnectionSingleton.ConnectionString))
            {
                //SQL QUERY
                string sqlCommand = "SELECT Sag.MæglerID, Ejendomsmægler.Fnavn, Ejendomsmægler.Enavn " +
                    "FROM Handel " +
                    "INNER JOIN Sag ON Sag.SagsID = Handel.SagsID " +
                    "inner join Ejendomsmægler on Ejendomsmægler.MæglerID = Sag.MæglerID" +
                    "WHERE Sag.SagsID = @SagsID " +
                    "AND Handel.HandelID = @HandelID " +
                    "AND sag.Status = 'Lukket (solgt bolig)'";

                //SQL COMMAND + PARAMETERS
                SqlCommand cmd = new SqlCommand(sqlCommand, conn);
                cmd.Parameters.AddWithValue("@SagsID", sagsid);
                cmd.Parameters.AddWithValue("@HandelID", handelid);

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

                    return ejendomsmægler;
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
            return ejendomsmægler;

        }

        public int HentSalgspris(string sagsid)
        {
            //INITIALIZATION OF INT PRIS
            int pris = 0;

            using (var conn = new SqlConnection(ConnectionSingleton.ConnectionString))
            {
                //SQL QUERY
                string sqlCommand = "select Handel.Salgspris from Handel, Sag where Handel.SagsID = @SagsID";

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
            }

            return pris;
        }
    }
}
