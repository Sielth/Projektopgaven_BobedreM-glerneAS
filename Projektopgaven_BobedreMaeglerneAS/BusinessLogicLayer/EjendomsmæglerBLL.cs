using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektopgaven_BobedreMaeglerneAS.BusinessLogicLayer
{
    class EjendomsmæglerBLL
    {
        //Connection string -
        string strconn = "Server=den1.mssql7.gear.host; Database=bobedredb; User ID=bobedredb; Password=Xw8gM?O3doQ_";
        //SqlConnection conn = new SqlConnection(strconn);
        private int MæglerID { get; set; }
        private int CPR { get; set; }
        private int Telefon { get; set; }
        private string Email { get; set; }
        private string Fnavn { get; set; }
        private string Enavn { get; set; }
        private string Vej { get; set; }
        private int Postnummer { get; set; }

        public EjendomsmæglerBLL(int mæglerID, int cpr, int telefon, string email, string fnavn, string enavn, string vej, int postnummer)
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
    }
}
