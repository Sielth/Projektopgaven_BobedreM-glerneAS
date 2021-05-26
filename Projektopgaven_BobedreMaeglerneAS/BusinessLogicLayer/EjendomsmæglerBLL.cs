﻿using Projektopgaven_BobedreMæglerneAS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektopgaven_BobedreMaeglerneAS.BusinessLogicLayer
{
    class EjendomsmæglerBLL : IPerson 
    {
        public int MæglerID { get; set; }
        public int CPR { get; set; }
        public int Telefon { get; set; }
        public string Email { get; set; }
        public string Fnavn { get; set; }
        public string Enavn { get; set; }
        public string Vej { get; set; }
        public int Postnummer { get; set; }

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

        public EjendomsmæglerBLL(string fnavn, string enavn, int tlf, string email)
        {
            this.Fnavn = fnavn;
            this.Enavn = enavn;
            this.Telefon = tlf;
            this.Email = email;
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


        public void OpretEjendomsmægler(EjendomsmæglerBLL ejendomsmægler)
        {
            EjendomsmæglerDAL ejendomsmæglerDAL = new EjendomsmæglerDAL();
            ejendomsmæglerDAL.OpretEjendomsmægler(ejendomsmægler);

        }

        public static EjendomsmæglerBLL HentEjendomsmægler(EjendomsmæglerBLL ejendomsmægler)
        {
            return EjendomsmæglerDAL.HentEjendomsmægler(ejendomsmægler);   
        }

        public void OpdaterEjendomsmægler(EjendomsmæglerBLL ejendomsmægler)
        {
            EjendomsmæglerDAL ejendomsmæglerDAL = new EjendomsmæglerDAL();
            ejendomsmæglerDAL.OpdaterEjendomsmægler(ejendomsmægler);
        }

        public void SletEjendomsmægler(EjendomsmæglerBLL ejendomsmægler)
        {
            EjendomsmæglerDAL ejendomsmæglerDAL = new EjendomsmæglerDAL();
            ejendomsmæglerDAL.SletEjendomsmægler(ejendomsmægler);
        }
    }
}
