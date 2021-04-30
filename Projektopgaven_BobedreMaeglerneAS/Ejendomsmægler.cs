using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Projektopgaven_BobedreMæglerneAS
{
    class Ejendomsmægler
    {
        //Connection string
        string strconn = "Server=den1.mssql7.gear.host; Database=bobedredb; User ID=bobedredb; Password=Xw8gM?O3doQ_";
        //SqlConnection conn = new SqlConnection(strconn);
        private int MæglerID { get; set; }
        private int CPR { get; set; }
        private int Telefon { get; set; }
        private string Email { get; set; }
        private string Fnavn { get; set; }
        private string Enavn { get; set; }
        private string Vej { get; set; }
        private int Postnummer {get; set;}

        public Ejendomsmægler(int mæglerID, int cpr, int telefon, string email, string fnavn, string enavn, string vej, int postnummer)
        {
            this.MæglerID = mæglerID;
            this.CPR = cpr;
            this.Telefon = telefon;
            this.Email = email;
            this.Fnavn = fnavn;
            this.Enavn = enavn;
            this.Vej = vej;
            this.Postnummer = postnummer;
        }

        private void OpretEjendomsmægler(Ejendomsmægler ejendomsmægler)
        {
            //Connection string
            //string strconn = "Server=den1.mssql7.gear.host; Database=bobedredb; User ID=bobedredb; Password=Xw8gM?O3doQ_";
            SqlConnection conn = new SqlConnection(strconn);

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

        private void FindEjendomsmægler(Ejendomsmægler ejendomsmægler, SqlConnection conn)
        {
            string sqlCommandEjendomsmægler = "SELECT * FROM Ejendomsmægler WHERE MæglerID = @MæglerID";

            SqlCommand commandEjendomsmægler = new SqlCommand(sqlCommandEjendomsmægler, conn);

            commandEjendomsmægler.Parameters.AddWithValue("@MæglerID", ejendomsmægler.MæglerID);
        }

        private void OpdaterEjendomsmægler(Ejendomsmægler ejendomsmægler, SqlConnection conn)
        {
        }

        private void SletEjendomsmægler(Ejendomsmægler ejendomsmægler, SqlConnection conn)
        {
            string sqlCommandEjendomsmægler = $"DELETE FROM Ejendomsmægler WHERE MæglerID = @MæglerID";

            SqlCommand commandEjendomsmægler = new SqlCommand(sqlCommandEjendomsmægler, conn);

            commandEjendomsmægler.Parameters.AddWithValue("@MæglerID", ejendomsmægler.MæglerID);
        }
    }
}