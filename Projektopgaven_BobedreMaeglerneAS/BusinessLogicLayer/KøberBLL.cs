using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projektopgaven_BobedreMaeglerneAS.DataAccessLayer;

namespace Projektopgaven_BobedreMaeglerneAS.BusinessLogicLayer
{
    class KøberBLL : IPerson
    {
        public int KøberID { get; set; }
        public string Vej { get; set; }
        public int Postnummer { get; set; }
        public long CPR { get; set; }
        public string Fnavn { get; set; }
        public string Enavn { get; set; }
        public string Email { get; set; }
        public int Telefon { get; set; }

        public KøberBLL(int Køberid, string Vej, int Postnummer, long CPR, string Fnavn, string Enavn, string Email, int Telefon)
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
        
        public KøberBLL(int køberid, string fnavn, string enavn)
        {
            this.KøberID = køberid;
            this.Fnavn = fnavn;
            this.Enavn = enavn;
        }

        public KøberBLL(int køberid)
        {
            this.KøberID = køberid;
        }

        public override string ToString()
        {
            return $"{KøberID} - {Fnavn} {Enavn}";
        }

        public static KøberBLL FromString(string input)
        {
            string[] køber = input.Split(' ');

            return new KøberBLL(Convert.ToInt32(køber[0]), køber[2], køber[3]);
        }

        public void OpretKøber(KøberBLL køber)
        {
            KøberDAL køberDAL = new KøberDAL();
            køberDAL.OpretKøber(køber);
        }

        public static KøberBLL FindKøber(KøberBLL køberToFind)
        {
            return KøberDAL.FindKøber(køberToFind);
        }

        public void OpdaterKøber(KøberBLL køber)
        {
            KøberDAL køberDAL = new KøberDAL();
            køberDAL.OpdaterKøber(køber);
        }

        public void SletKøber(KøberBLL køber)
        {
            KøberDAL køberDAL = new KøberDAL();
            køberDAL.SletKøber(køber);
        }
    }
}
