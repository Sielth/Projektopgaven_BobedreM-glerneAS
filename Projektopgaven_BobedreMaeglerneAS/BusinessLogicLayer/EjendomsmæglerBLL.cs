using Projektopgaven_BobedreMæglerneAS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektopgaven_BobedreMaeglerneAS.BusinessLogicLayer
{
    public class EjendomsmæglerBLL : IPerson 
    {
        public int MæglerID { get; set; }
        public long CPR { get; set; }
        public int Telefon { get; set; }
        public string Email { get; set; }
        public string Fnavn { get; set; }
        public string Enavn { get; set; }
        public string Vej { get; set; }
        public int Postnummer { get; set; }

        public EjendomsmæglerBLL(int mæglerID, long cpr, int telefon, string email, string fnavn, string enavn, string vej, int postnummer) //Constructor - bruger vi til opret og opdater
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

        public EjendomsmæglerBLL(string fnavn, string enavn, int tlf, string email) //Constructor - bruges til at vise på hjemmeskærmen
        {
            this.Fnavn = fnavn;
            this.Enavn = enavn;
            this.Telefon = tlf;
            this.Email = email;
        }

        public EjendomsmæglerBLL(int ID, string fnavn, string enavn) //Constructor - bruges til combobox
        {
            this.MæglerID = ID;
            this.Fnavn = fnavn;
            this.Enavn = enavn;
        }

        public EjendomsmæglerBLL() { } //Default constructor

        public override string ToString()
        {
            return ToString("A");
        }

        public string ToString(string fmt) //returnere to forskellige tostring afhængigt af om det er case A eller B
        {
            if (string.IsNullOrEmpty(fmt))
                fmt = "A";

            switch(fmt.ToUpperInvariant())
            {
                case "A":
                    return string.Format($"{MæglerID} - {Fnavn} {Enavn}");
                case "B":
                    return string.Format($"EJENDOMSMÆGLER\n\n" +
                        $"Navn: {Fnavn}\n" +
                        $"Efternavn: {Enavn}\n\n" +
                        $"Telefon: {Telefon}\n" +
                        $"Email: {Email}");
                default:
                    return string.Format($"EJENDOMSMÆGLER\n\n" +
                        $"Navn: {Fnavn}\n" +
                        $"Efternavn: {Enavn}\n\n" +
                        $"Telefon: {Telefon}\n" +
                        $"Email: {Email}");
            }
        }

        #region CRUD metoder
        public void OpretEjendomsmægler(EjendomsmæglerBLL ejendomsmægler)
        {
            EjendomsmæglerDAL ejendomsmæglerDAL = new EjendomsmæglerDAL(); //Laver et nyt objekt
            ejendomsmæglerDAL.OpretEjendomsmægler(ejendomsmægler);

        }

        public static EjendomsmæglerBLL HentEjendomsmægler(EjendomsmæglerBLL ejendomsmægler)
        {
            return EjendomsmæglerDAL.HentEjendomsmægler(ejendomsmægler);   
        }

        public void OpdaterEjendomsmægler(EjendomsmæglerBLL ejendomsmægler)
        {
            try
            {
                EjendomsmæglerDAL ejendomsmæglerDAL = new EjendomsmæglerDAL(); //Laver et nyt objekt
                ejendomsmæglerDAL.OpdaterEjendomsmægler(ejendomsmægler);
            }
            catch (Exception ex)
            {
                throw; //Sender fejlen videre til EjendomsmæglerUI.cs (knappen)
            }
        }

        public void SletEjendomsmægler(EjendomsmæglerBLL ejendomsmægler)
        {
            EjendomsmæglerDAL ejendomsmæglerDAL = new EjendomsmæglerDAL(); //Laver et nyt objekt
            ejendomsmæglerDAL.SletEjendomsmægler(ejendomsmægler);
        }
        #endregion


        public static bool EjendomsmæglerExists(int mæglerid)
        {
            return EjendomsmæglerDAL.EjendomsmælgerExists(mæglerid);
        }

        public static bool EjendomsmæglerCPRExists(long cpr)
        {
            return EjendomsmæglerDAL.EjendomsmælgerCPRExists(cpr);
        }

    }
}
