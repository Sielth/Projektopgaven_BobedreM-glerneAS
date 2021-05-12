using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projektopgaven_BobedreMaeglerneAS.BusinessLogicLayer;
using System.Data.SqlClient;

namespace Projektopgaven_BobedreMaeglerneAS.DataAccessLayer
{
    class Transactions
    {
        //private ConnectionSingleton s1;
        //private SqlConnection conn;

        //public Transactions()
        //{
        //    this.s1 = ConnectionSingleton.Instance();
        //    this.conn = s1.GetConnection();
        //}

        public static void BeginReadCommittedTransaction(SqlConnection conn)
        {
            try
            {
                //conn.Open();

                string sqlString = "SET TRANSACTION ISOLATION LEVEL READ COMMITTED";
                SqlCommand cmd = new SqlCommand(sqlString, conn);
                cmd.ExecuteNonQuery();

                sqlString = "BEGIN TRANSACTION";
                cmd = new SqlCommand(sqlString, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("READ COMMITTED BEGAN");

            //cmd.Connection.BeginTransaction(IsolationLevel.ReadCommitted);
        }

        public static void BeginRepeatableReadTransaction(SqlConnection conn)
        {

            try
            {
                //conn.Open();

                string sqlString = "SET TRANSACTION ISOLATION LEVEL REPEATABLE READ";
                SqlCommand cmd = new SqlCommand(sqlString, conn);
                cmd.ExecuteNonQuery();

                sqlString = "BEGIN TRANSACTION";
                cmd = new SqlCommand(sqlString, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("REPEATABLE READ BEGAN");

            //cmd.Connection.BeginTransaction(IsolationLevel.Serializable);
        }


        public static bool Commit(SqlConnection conn)
        {
            try
            {
                string sqlString = "COMMIT";
                SqlCommand cmd = new SqlCommand(sqlString, conn);
                cmd.ExecuteNonQuery();

                Console.WriteLine("COMMITTED!");

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public static void Rollback(SqlConnection conn)
        {
            try
            {
                string sqlString = "ROLLBACK";
                SqlCommand cmd = new SqlCommand(sqlString, conn);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("ROLLBACK");
        }
    }
}
