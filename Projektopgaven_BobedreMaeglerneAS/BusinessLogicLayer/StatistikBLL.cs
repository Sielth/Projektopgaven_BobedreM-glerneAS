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
        public static void StatsToText(DateTime startdate, DateTime Enddate)
        {
            //DateTime salgsdato;
            //int price;
            //string broker;
            //string city;
            StatistikDAL StatistikDAL = new StatistikDAL();
            List<StatistikBLL> statistik = new List<StatistikBLL>();
            statistik = StatistikDAL.SoldProperties(startdate, Enddate);

            StreamWriter Stream = null;
            string path = @"Resources/text.txt";

            try
            {
                Stream = new StreamWriter(path);

                Stream.WriteLine("\t Tidsperiode:"); //tilføj tidsperiode man har sorteret efter
                Stream.WriteLine("Adresse\t Postnummer\t Mægler\t Pris\t Handelsdato");
                
                foreach (StatistikBLL a in statistik)
                {
                    Stream.WriteLine(a.ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Stream.Close();
            }
        }

        public override string ToString()
        {
            return $"{Vej}\t{Postnummer, 15}\t{MæglerID}\t{Salgspris}\t{Handelsdato.ToShortDateString()}";
        }
    }
}
