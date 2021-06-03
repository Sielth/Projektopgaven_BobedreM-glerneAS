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

        public static void StatsToText(DateTime startdate, DateTime enddate)
        {
            //DateTime salgsdato;
            //int price;
            //string broker;
            //string city;

            StatistikDAL StatistikDAL = new StatistikDAL();
            List<StatistikBLL> statistik = StatistikDAL.SoldProperties(startdate, enddate);

            StreamWriter Stream = null;
            string path = @"Resources/Salgsoversigt.txt";

            string a = $"\tTidsperiode: {startdate.ToShortDateString()} - {enddate.ToShortDateString()}";
            string b = $"Adresse\t\tPostnummer\tMægler\tPris\tHandelsdato";

            try
            {
                Stream = new StreamWriter(path);

                Stream.WriteLine(a); //tilføj tidsperiode man har sorteret efter
                Stream.WriteLine(b);
                
                foreach (StatistikBLL s in statistik)
                {
                    Stream.WriteLine(s.ToString().PadRight(70));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (Stream != null)
                    Stream.Close();
            }
        }

        public void SoldPropertiesToListbox(DateTime startdate, DateTime enddate, ListBox output)
        {
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

        public void StatsToTextChooseFilePath(DateTime startdate, DateTime enddate, SaveFileDialog saveFileDialog1)
        {
            List<StatistikBLL> stats = SoldProperties(startdate, enddate);

            saveFileDialog1.Filter = "Txt File (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.Title = "Save a Text File";
            saveFileDialog1.RestoreDirectory = true;

            // If the file name is not an empty string open it for saving.
            if (saveFileDialog1.FileName != "")
            {
                // Saves the File via a FileStream created by the OpenFile method.
                System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog1.OpenFile();

                fs.Close();
            }
            else if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string a = $"\tTidsperiode: {startdate.ToShortDateString()} - {enddate.ToShortDateString()}";
                string b = $"Adresse\t\tPostnummer\tMægler\tPris\tHandelsdato";

                File.AppendAllText(saveFileDialog1.FileName, a + Environment.NewLine);
                File.AppendAllText(saveFileDialog1.FileName, b.PadRight(70) + Environment.NewLine);

                foreach (StatistikBLL s in stats)
                {
                    File.AppendAllText(saveFileDialog1.FileName, s.ToString().PadRight(70) + Environment.NewLine);
                }
            }
        }

        public override string ToString()
        {
            return $"{Vej}\t{Postnummer, 4}\t{MæglerID, 10}\t{Salgspris}\t{Handelsdato.ToShortDateString()}";
        }

        public static string Path()
        {
            return @"Resources\";

            //C:\Users\sielt\Documents\UCL\2SEMESTER\Projektopgaven_BobedreMaeglerneAS\Projektopgaven_BobedreMaeglerneAS\Projektopgaven_BobedreMaeglerneAS\bin\Debug\Resources\
        }
    }
}
