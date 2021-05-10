using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektopgaven_BobedreMaeglerneAS.BusinessLogicLayer
{
    class SælgerBLL
    {
        public int SælgerID { get; private set; }
        public int CPR { get; private set; }
        public int Telefon { get; private set; }
        public string Email { get; private set; }
        public string Fnavn { get; private set; }
        public string Enavn { get; private set; }
        public string Vej { get; private set; }
        public int Postnummer { get; private set; }

        public SælgerBLL(int sælgerid, int cpr, int telefon, string email, string fnavn, string enavn, string vej, int postnummer)
        {
            this.SælgerID = sælgerid;
            this.CPR = cpr;
            this.Telefon = telefon;
            this.Email = email;
            this.Fnavn = fnavn;
            this.Enavn = enavn;
            this.Vej = vej;
            this.Postnummer = postnummer;
        }

        public SælgerBLL(int sælgerid)
        {
            this.SælgerID = sælgerid;
        }
    }
}
