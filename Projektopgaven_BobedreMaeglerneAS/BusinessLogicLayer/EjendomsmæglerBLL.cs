using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektopgaven_BobedreMaeglerneAS.BusinessLogicLayer
{
    class EjendomsmæglerBLL
    {
        public int MæglerID { get; private set; }
        public int CPR { get; private set; }
        public int Telefon { get; private set; }
        public string Email { get; private set; }
        public string Fnavn { get; private set; }
        public string Enavn { get; private set; }
        public string Vej { get; private set; }
        public int Postnummer { get; private set; }

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
