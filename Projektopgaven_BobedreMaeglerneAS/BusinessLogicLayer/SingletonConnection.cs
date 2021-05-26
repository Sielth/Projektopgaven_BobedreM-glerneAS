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
        private static ConnectionSingleton _instance = null;
        private static string ConnectionString = "Server=den1.mssql7.gear.host; Database=bobedredb; User ID=bobedredb; Password=Xw8gM?O3doQ_; MultipleActiveResultSets=false";
        private static SqlConnection conn = new SqlConnection(ConnectionString);

        // Constructor is 'protected'
        static ConnectionSingleton()
        {
            
        }

        private ConnectionSingleton()
        {
            
        }

        public static ConnectionSingleton Instance()
        {
            // Not fully lazy, needs to be initialized.
            // Note: thread safe because of "static Singleton()"
            if (_instance == null)
            {
                _instance = new ConnectionSingleton();
            }

            return _instance;
        }

        public SqlConnection GetConnection()
        {
            return conn;
        }

        public string GetConnectionString()
        {
            return "Server=den1.mssql7.gear.host; Database=bobedredb; User ID=bobedredb; Password=Xw8gM?O3doQ_; MultipleActiveResultSets=false";
        }
    }
}