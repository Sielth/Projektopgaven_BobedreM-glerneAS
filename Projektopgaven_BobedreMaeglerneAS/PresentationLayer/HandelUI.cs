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


namespace Projektopgaven_BobedreMaeglerneAS.PresentationLayer
{
    public partial class HandelUI : Form
    {
        KøberDAL køber;
        SagDAL sag;
        StatistikBLL statistik = new StatistikBLL();
        StatistikDAL statistikdal = new StatistikDAL();

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
            HandelBLL handelBLL = new HandelBLL(HandelID(), Handelsddato(), HandelSalgspris(), HandelSagsID(), HandelKøberID());
            HandelDAL handelDAL = new HandelDAL(handelBLL);

            //Kalder metoden: OpretHandel
            handelDAL.OpretHandel(handelBLL);

            ////Loader data fra databasen ind i datagridview -
            //HandelUI_Load(sender, e);
        }

        private void btn_findhandel_Click(object sender, EventArgs e)
        {
            HandelBLL handelBLL = new HandelBLL(HandelID(), Handelsddato(), HandelSalgspris(), HandelSagsID(), HandelKøberID());
            HandelDAL handelDAL = new HandelDAL(handelBLL);

            //Kalder metoden: OpretHandel
            handelDAL.FindHandel(handelBLL);

            ////Loader data fra databasen ind i datagridview -
            //HandelUI_Load(sender, e);
        }

        private void btn_opdaterhandel_Click(object sender, EventArgs e)
        {
            HandelBLL handelBLL = new HandelBLL(HandelID(), Handelsddato(), HandelSalgspris(), HandelSagsID(), HandelKøberID());
            HandelDAL handelDAL = new HandelDAL(handelBLL);

            //Kalder metoden: OpretHandel
            handelDAL.OpdaterHandel(handelBLL);

            ////Loader data fra databasen ind i datagridview -
            //HandelUI_Load(sender, e);
        }

        private void btn_slethandel_Click(object sender, EventArgs e)
        {
            HandelBLL handelBLL = new HandelBLL(HandelID(), Handelsddato(), HandelSalgspris(), HandelSagsID(), HandelKøberID());
            HandelDAL handelDAL = new HandelDAL(handelBLL);

            //Kalder metoden: OpretHandel
            handelDAL.SletHandel(handelBLL);

            ////Loader data fra databasen ind i datagridview -
            //HandelUI_Load(sender, e);
        }


        #region Konverter Tekstbokse
        public int HandelID()
        {
            int.TryParse(handelID_txt.Text, out int handelid);
            return handelid;
        }

        public DateTime Handelsddato()
        {
            //DateTime.TryParse(dateTimePicker1.Text, out DateTime handelsdato);
            return GetStartDate().Value;
        }

        public int HandelSalgspris()
        {
            int.TryParse(handelSalgspris_txt.Text, out int handelsalgspris);
            return handelsalgspris;
        }

        public int HandelSagsID()
        {
            int.TryParse(handelSalgsID_cbox.Text, out int handelsalgsid);
            return handelsalgsid;
        }

        public int HandelKøberID()
        {
            int.TryParse(handelKøberID_cbox.Text, out int handelkøberid);
            return handelkøberid;
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

        private void updateToolStripMenuItem1_Click(object sender, EventArgs e) //Opdater handel
        {
            MenuBarKnapper.HandelOpdater();
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e) //Slet handel
        {
            MenuBarKnapper.HandelSlet();
        }

        //EJENDOMSMÆGLER MENUBARKNAPPER - I HANDEL MENU
        private void ejendomsmægler_createToolStripMenuItem_Click(object sender, EventArgs e) //Opret ejendomsmægler
        {
            MenuBarKnapper.EjendomsmælgerOpret();
        }

        private void ejendomsmægler_readToolStripMenuItem_Click(object sender, EventArgs e) //Hent ejendomsmægler
        {
            MenuBarKnapper.EjendomsmæglerHent();
        }

        private void ejendomsmægler_updateToolStripMenuItem_Click(object sender, EventArgs e) //Opdater ejendomsmægler
        {
            MenuBarKnapper.EjendomsmæglerOpdater();
        }

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

        private void køber_updateToolStripMenuItem1_Click(object sender, EventArgs e) //Opdater køber
        {
            MenuBarKnapper.KøberUpdate();
        }

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
            MenuBarKnapper.SælgerHent();
        }

        private void sælger_updateToolStripMenuItem_Click(object sender, EventArgs e) //Opdater sælger
        {
            MenuBarKnapper.SælgerOpdater();
        }

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

            StatistikDAL statistikdal = new StatistikDAL();

            //DateTime from, to;

            //try
            //{
            //    DateTime.ParseExact ("yyyy-MM-dd HH:mm:ss:fff", dateTimePicker1, )
            //}

            List<StatistikBLL> stats = statistikdal.SoldProperties(dateTimePicker1.Value, dateTimePicker3.Value);

            foreach (StatistikBLL stat in stats)
                Console.WriteLine(stat.ToString());

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
