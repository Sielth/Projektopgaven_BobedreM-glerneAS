using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projektopgaven_BobedreMaeglerneAS.DataAccessLayer;
using System.Windows.Forms;

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
        public List<StatistikBLL> SoldProperties(DateTime startdate, DateTime enddate)
        {
            StatistikDAL statistikdal = new StatistikDAL();
            List<StatistikBLL> stats = statistikdal.SoldProperties(startdate, enddate);
            return stats;
            //foreach (StatistikBLL stat in stats)
            //    Console.WriteLine(stat.ToString());

            //var output = statistik_solgteboliger_lbox;

            //output.Items.Add("Adresse\t\tPostnummer\tMægler\tPris\tHandelsdato");
            //foreach (StatistikBLL stat in stats)
            //    output.Items.Add(stat.ToString());  
        }
        public void SoldPropertiesToListbox(DateTime startdate, DateTime enddate, ListBox output)
        {
            StatistikBLL stat = new StatistikBLL();
            List<StatistikBLL> stats = SoldProperties(startdate, enddate);
            output.Items.Add("\t Tidsperiode: " + startdate.ToShortDateString() + " - " + enddate.ToShortDateString());
            output.Items.Add("Adresse\t\tPostnummer\tMægler\tPris\tHandelsdato");
            foreach (StatistikBLL s in stats)
                output.Items.Add(s.ToString());

            //var output = statistik_solgteboliger_lbox;

            //output.Items.Add("Adresse\t\tPostnummer\tMægler\tPris\tHandelsdato");
            //foreach (StatistikBLL stat in stats)
            //    output.Items.Add(stat.ToString());
        }

        public override string ToString()
        {
            return $"{Vej}\t{Postnummer, 15}\t{MæglerID}\t{Salgspris}\t{Handelsdato.ToShortDateString()}";
        }
    }
}
