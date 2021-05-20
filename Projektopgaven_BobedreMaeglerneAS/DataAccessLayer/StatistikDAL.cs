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

        }
        public List<StatistikBLL> SoldProperties()
        {
            List<StatistikBLL> statistik = new List<StatistikBLL>();
            string startdate = HandelUI.GetStartDate().Value.ToShortDateString();
            string enddate = HandelUI.GetEndDate().Value.ToShortDateString();
            string sqlCommandStatistik = "SELECT * FROM Handel WHERE Handelsdato BETWEEN '" + startdate + "' AND '" + enddate + "+";
            SqlCommand cmd = new SqlCommand(sqlCommandStatistik, conn);
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
                            reader["Adresse"].ToString())
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
        }
    }
}
