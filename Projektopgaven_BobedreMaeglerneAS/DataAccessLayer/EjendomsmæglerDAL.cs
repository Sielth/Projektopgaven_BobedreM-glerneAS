using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Projektopgaven_BobedreMæglerneAS;
using Projektopgaven_BobedreMaeglerneAS.BusinessLogicLayer;

namespace Projektopgaven_BobedreMæglerneAS
{
    class EjendomsmæglerDAL
    {
        private void OpretEjendomsmægler(EjendomsmæglerBLL ejendomsmægler, SqlConnection conn)
        {
            //Connection string - 
            //string strconn = "Server=den1.mssql7.gear.host; Database=bobedredb; User ID=bobedredb; Password=Xw8gM?O3doQ_";
            //SqlConnection conn = new SqlConnection(strconn);

            string sqlCommandEjendomsmægler = $"INSERT INTO Ejendomsmægler VALUES (@CPR, @Telefon, @Email, @Fnavn, @Enavn, @Vej, @Postnummer)";

            SqlCommand commandEjendomsmægler = new SqlCommand(sqlCommandEjendomsmægler, conn);

            commandEjendomsmægler.Parameters.AddWithValue("@CPR", ejendomsmægler.CPR);
            commandEjendomsmægler.Parameters.AddWithValue("@Telefon", ejendomsmægler.Telefon);
            commandEjendomsmægler.Parameters.AddWithValue("@Email", ejendomsmægler.Email);
            commandEjendomsmægler.Parameters.AddWithValue("@Fnavn", ejendomsmægler.Fnavn);
            commandEjendomsmægler.Parameters.AddWithValue("@Enavn", ejendomsmægler.Enavn);
            commandEjendomsmægler.Parameters.AddWithValue("@Vej", ejendomsmægler.Vej);
            commandEjendomsmægler.Parameters.AddWithValue("@Postnummer", ejendomsmægler.Postnummer);
        }

        private void FindEjendomsmægler(EjendomsmæglerBLL ejendomsmægler, SqlConnection conn)
        {
            string sqlCommandEjendomsmægler = "SELECT * FROM Ejendomsmægler WHERE MæglerID = @MæglerID";

            SqlCommand commandEjendomsmægler = new SqlCommand(sqlCommandEjendomsmægler, conn);

            commandEjendomsmægler.Parameters.AddWithValue("@MæglerID", ejendomsmægler.MæglerID);
        }

        private void OpdaterEjendomsmægler(EjendomsmæglerBLL ejendomsmægler, SqlConnection conn)
        {
        }

        private void SletEjendomsmægler(EjendomsmæglerBLL ejendomsmægler, SqlConnection conn)
        {
            string sqlCommandEjendomsmægler = $"DELETE FROM Ejendomsmægler WHERE MæglerID = @MæglerID";

            SqlCommand commandEjendomsmægler = new SqlCommand(sqlCommandEjendomsmægler, conn);

            commandEjendomsmægler.Parameters.AddWithValue("@MæglerID", ejendomsmægler.MæglerID);
        }
    }
}