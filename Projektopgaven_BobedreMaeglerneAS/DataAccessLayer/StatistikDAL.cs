using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projektopgaven_BobedreMaeglerneAS.BusinessLogicLayer;
using Projektopgaven_BobedreMaeglerneAS.PresentationLayer;

namespace Projektopgaven_BobedreMaeglerneAS.DataAccessLayer
{
    class StatistikDAL
    {
        private StatistikBLL StatistikBLL;
        private ConnectionSingleton s1;
        private SqlConnection conn;
        private HandelUI HandelUI;
        public StatistikDAL(StatistikBLL statistikBLL)
        {
            this.StatistikBLL = statistikBLL;
            this.s1 = ConnectionSingleton.Instance(); //creates a new instance of ConnectionSingleton via method Instance
            this.conn = s1.GetConnection(); //get the SqlConnection from ConnectionSingleton method GetConnection
        }
        public StatistikDAL()
        {
            this.s1 = ConnectionSingleton.Instance(); //creates a new instance of ConnectionSingleton via method Instance
            this.conn = s1.GetConnection(); //get the SqlConnection from ConnectionSingleton method GetConnection
        }

        public List<StatistikBLL> SoldProperties(DateTime startdate, DateTime enddate)
        {
            //HandelUI Handel = new HandelUI();

            List<StatistikBLL> statistik = new List<StatistikBLL>();

            using (var conn = new SqlConnection(ConnectionSingleton.ConnectionString))
            {
                //DateTime startdate = Handel.GetStartDate().Value;
                //DateTime enddate = Handel.GetEndDate().Value;
                //string sqlCommandStatistik = "SELECT * FROM Handel WHERE Handelsdato BETWEEN '" + startdate + "' AND '" + enddate + "+";


                string sqlCommandStatistik = "SELECT Handel.Handelsdato, Handel.Salgspris, Sag.MæglerID, Bolig.Postnummer, Bolig.Vej" +
                    " FROM Handel INNER JOIN Sag ON Sag.SagsID = Handel.SagsID INNER JOIN Bolig ON Bolig.BoligID = Sag.BoligID" +
                    " WHERE Sag.Status = 'Lukket (solgt bolig)' AND Handel.Handelsdato BETWEEN @date1 AND @date2";

                SqlCommand cmd = new SqlCommand(sqlCommandStatistik, conn);

                cmd.Parameters.AddWithValue("@date1", startdate);
                cmd.Parameters.AddWithValue("@date2", enddate);

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
                            statistik.Add(new StatistikBLL(
                                (DateTime)reader["Handelsdato"],
                                (int)reader["Salgspris"],
                                (int)reader["MæglerID"],
                                (int)reader["Postnummer"],
                                reader["Vej"].ToString())
                                );
                        }
                        //CLOSE READER
                        reader.Close();
                    }
                    if (!Transactions.Commit(conn))
                    {
                        Transactions.Rollback(conn);
                    }
                    return statistik;
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }

            return statistik;
        }
    }
}
