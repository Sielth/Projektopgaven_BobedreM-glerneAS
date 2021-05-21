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
        public string Vej { get; private set; }
        public StatistikBLL(DateTime Handelsdato, int Salgspris, int MæglerID, int Postnummer, string Vej)
        {
            this.Handelsdato = Handelsdato;
            this.Salgspris = Salgspris;
            this.MæglerID = MæglerID;
            this.Postnummer = Postnummer;
            this.Vej = Vej;
        }
        public StatistikBLL()
        {

        }
        public void StatsToText()
        {
            //DateTime salgsdato;
            //int price;
            //string broker;
            //string city;
            StatistikDAL StatistikDAL = new StatistikDAL();
            List<StatistikBLL> statistik = new List<StatistikBLL>();
            //statistik = StatistikDAL.SoldProperties(/*startdate, Enddate*/);

            try
            {
                StreamWriter sw = new StreamWriter(@"Resources/");
                sw.WriteLine("\t Tidsperiode:"); //tilføj tidsperiode man har sorteret efter
                sw.WriteLine("Adresse\t Postnummer\t Mægler\t Pris\t Handelsdato");
                foreach (StatistikBLL a in statistik)
                {
                    Console.WriteLine(a.ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public override string ToString()
        {
            return $"{Vej}\t,{Postnummer}\t,{MæglerID}\t,{Salgspris}\t,{Handelsdato.ToShortDateString()}";
        }
    }
}
