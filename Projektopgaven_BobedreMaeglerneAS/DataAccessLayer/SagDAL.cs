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
                conn.Open();
                commandSag.ExecuteNonQuery();
            }

            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }

            finally
            {
                conn.Close();
            }
        }
    }
}
