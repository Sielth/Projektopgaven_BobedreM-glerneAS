using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektopgaven_BobedreMaeglerneAS.BusinessLogicLayer
{
    class KøberBLL
    {
        public int KøberID { get; private set; }
        public string Vej { get; private set; }
        public int Postnummer { get; private set; }
        public int CPR { get; private set; }
        public string Fnavn { get; private set; }
        public string Enavn { get; private set; }
        public string Email { get; private set; }
        public int Telefon { get; private set; }

        public KøberBLL(int Køberid, string Vej, int Postnummer, int CPR, string Fnavn, string Enavn, string Email, int Telefon)
        {
            this.KøberID = Køberid;
            this.Vej = Vej;
            this.Postnummer = Postnummer;
            this.CPR = CPR;
            this.Fnavn = Fnavn;
            this.Enavn = Enavn;
            this.Email = Email;
            this.Telefon = Telefon;
        }
        public KøberBLL(int køberid)
        {
            this.KøberID = køberid;
        }
    }
}
