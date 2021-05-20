using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projektopgaven_BobedreMaeglerneAS.DataAccessLayer;

namespace Projektopgaven_BobedreMaeglerneAS.BusinessLogicLayer
{
    class StatistikBLL
    {
        public DateTime Handelsdato { get; private set; }
        public int Salgspris { get; private set; }
        public int MæglerID { get; private set; }
        public int Postnummer { get; private set; }
        public string Adresse { get; private set; }
        public StatistikBLL(DateTime Handelsdato, int Salgspris, int MæglerID, int Postnummer, string Adresse)
        {
            this.Handelsdato = Handelsdato;
            this.Salgspris = Salgspris;
            this.MæglerID = MæglerID;
            this.Postnummer = Postnummer;
            this.Adresse = Adresse;
        }
        public void StatsToText()
        {
            //DateTime salgsdato;
            //int price;
            //string broker;
            //string city;
            StatistikDAL StatistikDAL = new StatistikDAL();
            List<StatistikBLL> statistik = new List<StatistikBLL>();
            //statistik = HandelDAL.SoldProperties();

            try
            {
                StreamWriter sw = new StreamWriter(@"Resources/");
                sw.WriteLine("\t Tidsperiode");
                sw.WriteLine("By\t Bolig solgt\t Pris\t Ejendomsmægler");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
