using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Projektopgaven_BobedreMaeglerneAS.BusinessLogicLayer
{
    class ConnectionSingleton
    {
        private static SqlConnection _instance;
        private static string ConnectionString = "Server=den1.mssql7.gear.host; Database=bobedredb; User ID=bobedredb; Password=Xw8gM?O3doQ_";
        // Constructor is 'protected'
        static ConnectionSingleton()
        {
        }
        private ConnectionSingleton()
        {
            //ConnectionString = "Server=den1.mssql7.gear.host; Database=bobedredb; User ID=bobedredb; Password=Xw8gM?O3doQ_";
        }
        public static SqlConnection Instance()
        {
            // Not fully lazy, needs to be initialized.
            // Note: thread safe because of "static Singleton()"
            //if (_instance == null)
            //{
            //    _instance = new Singleton();
            //}
            _instance = new SqlConnection(ConnectionString);
            try 
            {
                _instance.Open();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return _instance;
        }
    }
}
