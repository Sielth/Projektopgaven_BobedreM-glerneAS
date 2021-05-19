using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektopgaven_BobedreMaeglerneAS.BusinessLogicLayer
{
    class KøberBLL : IPerson
    {
        public int KøberID { get; set; }
        public string Vej { get; set; }
        public int Postnummer { get; set; }
        public int CPR { get; set; }
        public string Fnavn { get; set; }
        public string Enavn { get; set; }
        public string Email { get; set; }
        public int Telefon { get; set; }

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
