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
        private int MæglerID;
        private int CPR;
        private int Telefon;
        private string Email;
        private string Fnavn;
        private string Enavn;
        private string Vej;
        private int Postnummer;

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
        private void RedigerEjendomsmægler(Ejendomsmægler ejendomsmægler, SqlConnection conn)
        {
        }
        private void OpdaterEjendomsmægler(Ejendomsmægler ejendomsmægler, SqlConnection conn)
        {
        }
        private void SletEjendomsmægler(Ejendomsmægler ejendomsmægler, SqlConnection conn)
        {
        }
    }
}