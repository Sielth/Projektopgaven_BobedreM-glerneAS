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

        public EjendomsmæglerBLL(string fnavn, string enavn, int tlf)
        {
            this.Fnavn = fnavn;
            this.Enavn = enavn;
            this.Telefon = tlf;
        }

        public EjendomsmæglerBLL(int ID, string fnavn, string enavn)
        {
            this.MæglerID = ID;
            this.Fnavn = fnavn;
            this.Enavn = enavn;
        }

        //public string ToString(string format)
        //{
        //    return this.ToString(format);
        //    //$"{MæglerID} - {Fnavn} {Enavn}";
        //}


        public EjendomsmæglerBLL() { }

        public override string ToString()
        {
            return ToString("A");
        }

        public string ToString(string fmt)
        {
            if (string.IsNullOrEmpty(fmt))
                fmt = "A";

            switch(fmt.ToUpperInvariant())
            {
                case "A":
                    return string.Format($"{MæglerID} - {Fnavn} {Enavn}");
                case "B":
                    return string.Format($"STILLING: ejendomsmægler\n" +
                        $"Navn: {Fnavn}\n" +
                        $"Efternavn: {Enavn}\n" +
                        $"Telefon: {Telefon}");
                default:
                    return string.Format($"STILLING: ejendomsmægler\n" +
                        $"Navn: {Fnavn}\n" +
                        $"Efternavn: {Enavn}\n" +
                        $"Telefon: {Telefon}");
            }
        }
    }
}
