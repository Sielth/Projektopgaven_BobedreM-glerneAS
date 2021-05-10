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
        private static ConnectionSingleton _instance = new ConnectionSingleton();
        public static string ConnectionString; // = "Server=den1.mssql7.gear.host; Database=bobedredb; User ID=bobedredb; Password=Xw8gM?O3doQ_";

        // Constructor is 'protected'
        static ConnectionSingleton()
        {
        }

        private ConnectionSingleton()
        {
            ConnectionString = "Server=den1.mssql7.gear.host; Database=bobedredb; User ID=bobedredb; Password=Xw8gM?O3doQ_";
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
    }
}