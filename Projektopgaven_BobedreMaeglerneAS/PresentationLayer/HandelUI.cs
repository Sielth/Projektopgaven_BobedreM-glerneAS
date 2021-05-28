using Projektopgaven_BobedreMaeglerneAS.BusinessLogicLayer;
using Projektopgaven_BobedreMaeglerneAS.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Projektopgaven_BobedreMaeglerneAS.PresentationLayer
{
    public partial class HandelUI : Form
    {
        KøberDAL køber;
        SagDAL sag;

        HandelBLL handel;
        StatistikBLL statistik;
        SagBLL sagBLL;

        public HandelUI()
        {
            InitializeComponent();

            køber = new KøberDAL(handelKøberID_cbox);
            sag = new SagDAL(handelSalgsID_cbox);

            Thread t1 = new Thread(new ThreadStart(køber.GenerateKøber));
            t1.IsBackground = true;
            t1.Start();

            Thread t2 = new Thread(new ThreadStart(sag.GenerateSag));
            t2.IsBackground = true;
            t2.Start();
        }

        private void btn_oprethandel_Click(object sender, EventArgs e)
        {
            handel = new HandelBLL(HandelID(), Handelsdato(), HandelSalgspris(), HandelSagsID(), HandelKøberID());
            sagBLL = new SagBLL(HandelSagsID());

            try
            {
                //Kalder metoden: OpretHandel
                handel.OpretHandel(handel);

                if (SagBLL.SagExists(HandelSagsID()))
                    sagBLL.LukSag(sagBLL);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                HandelBLL matchinghandel = HandelBLL.FindHandel(handel);

                handelID_txt.Text = matchinghandel.HandelID.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            ////Loader data fra databasen ind i datagridview -
            //HandelUI_Load(sender, e);
        }

        private void btn_findhandel_Click(object sender, EventArgs e)
        {
            handel = new HandelBLL(HandelID());
            
            HandelBLL matchinghandel = HandelBLL.FindHandel(handel);
            //Kalder metoden: OpretHandel

            handelSalgsID_cbox.Text = matchinghandel.SagsID.ToString();
            handelKøberID_cbox.Text = matchinghandel.KøberID.ToString();
            handelSalgspris_txt.Text = matchinghandel.Salgspris.ToString();
            ////Loader data fra databasen ind i datagridview -
            //HandelUI_Load(sender, e);
        }

        private void btn_opdaterhandel_Click(object sender, EventArgs e)
        {
            handel = new HandelBLL(HandelID(), Handelsdato(), HandelSalgspris(), HandelSagsID(), HandelKøberID());

            //Kalder metoden: OpretHandel
            handel.OpdaterHandel(handel);

            ////Loader data fra databasen ind i datagridview -
            //HandelUI_Load(sender, e);
        }

        private void btn_slethandel_Click(object sender, EventArgs e)
        {
            handel = new HandelBLL(HandelID());

            //Kalder metoden: OpretHandel
            handel.SletHandel(handel);

            ////Loader data fra databasen ind i datagridview -
            //HandelUI_Load(sender, e);
        }


        #region Konverter Tekstbokse
        public int HandelID()
        {
            int.TryParse(handelID_txt.Text, out int handelid);
            return handelid;
        }

        public DateTime Handelsdato()
        {
            //DateTime.TryParse(dateTimePicker1.Text, out DateTime handelsdato);
            return GetStartDate().Value;
        }

        public int HandelSalgspris()
        {
            int.TryParse(handelSalgspris_txt.Text, out int handelsalgspris);
            return handelsalgspris;
        }

        private int HandelSagsID()
        {
            if (handelSalgsID_cbox.SelectedItem != null)
            {
                var selected = handelSalgsID_cbox.SelectedItem;
                string[] sagsID_txt = handelSalgsID_cbox.SelectedItem.ToString().Split(' ');
                int.TryParse(sagsID_txt[0], out int sagsID);
                return sagsID;
            }
            else
            {
                int.TryParse(handelSalgsID_cbox.Text, out int sagsID);
                return sagsID;
            }
        }

        public int HandelKøberID()
        {
            var selected = handelKøberID_cbox.SelectedItem;
            string[] køberID_txt = handelKøberID_cbox.Text.ToString().Split(' ');
            int.TryParse(køberID_txt[0], out int køberID);
            return køberID;
        }
        #endregion

        #region MENUBARKNAPPER
        //MENU
        //HANDEL MENUBARKNAPPER - I HANDEL MENU
        private void createToolStripMenuItem1_Click(object sender, EventArgs e) //Opret handel
        {
            MenuBarKnapper.HandelOpret();
        }

        private void readToolStripMenuItem1_Click(object sender, EventArgs e) //Find handel
        {
            MenuBarKnapper.HandelHent();
        }

        //private void updateToolStripMenuItem1_Click(object sender, EventArgs e) //Opdater handel
        //{
        //    MenuBarKnapper.HandelOpdater();
        //}

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e) //Slet handel
        {
            MenuBarKnapper.HandelSlet();
        }
        private void udtrækStatistikToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MenuBarKnapper.HandelStatistik();
        }

        //EJENDOMSMÆGLER MENUBARKNAPPER - I HANDEL MENU
        private void ejendomsmægler_createToolStripMenuItem_Click(object sender, EventArgs e) //Opret ejendomsmægler
        {
            MenuBarKnapper.EjendomsmælgerOpret();
        }

        private void ejendomsmægler_readToolStripMenuItem_Click(object sender, EventArgs e) //Hent ejendomsmægler
        {
            MenuBarKnapper.EjendomsmæglerHentOpdater();
        }

        //private void ejendomsmægler_updateToolStripMenuItem_Click(object sender, EventArgs e) //Opdater ejendomsmægler
        //{
        //    MenuBarKnapper.EjendomsmæglerOpdater();
        //}

        private void ejendomsmægler_deleteToolStripMenuItem_Click(object sender, EventArgs e) //Slet ejendomsmægler
        {
            MenuBarKnapper.EjendomsmæglerSlet();
        }

        //KØBER MENUBARKNAPPER - I HANDEL MENU
        private void køber_createToolStripMenuItem1_Click(object sender, EventArgs e) //Opret køber
        {
            MenuBarKnapper.KøberCreate();
        }

        private void køber_readToolStripMenuItem1_Click(object sender, EventArgs e) //Hent køber
        {
            MenuBarKnapper.KøberRead();
        }

        //private void køber_updateToolStripMenuItem1_Click(object sender, EventArgs e) //Opdater køber
        //{
        //    MenuBarKnapper.KøberUpdate();
        //}

        private void køber_deleteToolStripMenuItem1_Click(object sender, EventArgs e) //Slet køber
        {
            MenuBarKnapper.KøberDelete();
        }

        //SÆLGER MENUBARKNAPPER - I HANDEL MENU
        private void sælger_createToolStripMenuItem_Click(object sender, EventArgs e) //Opret sælger
        {
            MenuBarKnapper.SælgerOpret();
        }

        private void sælger_readToolStripMenuItem_Click(object sender, EventArgs e) //Hent sælger
        {
            MenuBarKnapper.SælgerHentOpdater();
        }

        //private void sælger_updateToolStripMenuItem_Click(object sender, EventArgs e) //Opdater sælger
        //{
        //    MenuBarKnapper.SælgerOpdater();
        //}

        private void sælger_deleteToolStripMenuItem_Click(object sender, EventArgs e) //Slet sælger
        {
            MenuBarKnapper.SælgerSlet();
        }

        //BOLIG MENUBARKNAPPER - I HANDEL MENU
        private void bolig_createToolStripMenuItem2_Click(object sender, EventArgs e) //Opret bolig
        {
            MenuBarKnapper.OpretBolig();
        }

        private void bolig_readToolStripMenuItem2_Click(object sender, EventArgs e) //Hent og opdater bolig
        {
            MenuBarKnapper.HentOpdaterBolig();
        }

        private void bolig_deleteToolStripMenuItem2_Click(object sender, EventArgs e) //Slet bolig
        {
            MenuBarKnapper.SletBolig();
        }

        private void komTilÅbentHusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuBarKnapper.ÅbentHus();
        }

        //SAG MENUBARKNAPPER - I HANDEL MENU
        private void createToolStripMenuItem_Click(object sender, EventArgs e) //Opret sag
        {
            MenuBarKnapper.SagOpret();
        }

        private void readToolStripMenuItem_Click(object sender, EventArgs e) //Hent sag
        {
            MenuBarKnapper.SagHent();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e) //Opdater sag
        {
            MenuBarKnapper.SagOpdater();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e) //Slet sag
        {
            MenuBarKnapper.SagSlet();
        }
        #endregion

        private void button1_Click(object sender, EventArgs e) //udtræk statistik
        {
            //HandelBLL handelBLL = new HandelBLL(HandelID(), Handelsddato(), HandelSalgspris(), HandelSagsID(), HandelKøberID());
            //HandelDAL handelDAL = new HandelDAL(handelBLL);
            //statistik.StatsToText();
            //statistikdal.SoldProperties(dateTimePicker1.Value, dateTimePicker3.Value);

            statistik = new StatistikBLL();
            statistik.SoldPropertiesToListbox(dateTimePicker1.Value, dateTimePicker3.Value, statistik_solgteboliger_lbox);

            //DateTime from, to;

            //try
            //{
            //    DateTime.ParseExact ("yyyy-MM-dd HH:mm:ss:fff", dateTimePicker1, )
            //}

            //List<StatistikBLL> stats = statistikdal.SoldProperties(dateTimePicker1.Value, dateTimePicker3.Value);

            //foreach (StatistikBLL stat in stats)
            //    Console.WriteLine(stat.ToString());

            //var output = statistik_solgteboliger_lbox;

            //output.Items.Add("Adresse\t\tPostnummer\tMægler\tPris\tHandelsdato");
            //foreach (StatistikBLL stat in stats)
            //    output.Items.Add(stat.ToString());
        }

        private void save_Click(object sender, EventArgs e)
        {
            statistik = new StatistikBLL();

            statistik.StatsToTextChooseFilePath(dateTimePicker1.Value, dateTimePicker3.Value, saveFileDialog1);
            //OR
            StatistikBLL.StatsToText(dateTimePicker1.Value, dateTimePicker3.Value);
        }
    }
}
