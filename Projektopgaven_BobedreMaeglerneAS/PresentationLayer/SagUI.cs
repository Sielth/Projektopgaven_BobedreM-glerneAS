using Projektopgaven_BobedreMaeglerneAS.BusinessLogicLayer;
using Projektopgaven_BobedreMaeglerneAS.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projektopgaven_BobedreMæglerneAS;
using System.Threading;

namespace Projektopgaven_BobedreMaeglerneAS.PresentationLayer
{
    public partial class SagUI : Form
    {
        BoligDAL bolig;
        SælgerDAL sælger;
        EjendomsmæglerDAL ejendomsmægler;
        HandelDAL handel;

        public SagUI()
        {
            InitializeComponent();

            //series of loop that add elements in combobox from methods that return lists of elements
            //uses three different threads to have the list always updated

            bolig = new BoligDAL(sag_boligID_cbox);
            Thread t1 = new Thread(new ThreadStart(bolig.GenerateBolig));
            t1.IsBackground = true;
            t1.Start();

            sælger = new SælgerDAL(sag_sælgerID_cbox);
            Thread t2 = new Thread(new ThreadStart(sælger.GenerateSælger));
            t2.IsBackground = true;
            t2.Start();

            ejendomsmægler = new EjendomsmæglerDAL(sag_ejendomsmæglerID_cbox);
            Thread t3 = new Thread(new ThreadStart(ejendomsmægler.GenerateEjendomsmægler));
            t3.IsBackground = true;
            t3.Start();
        }

        private void sagStatus_cbox_SelectedValueChanged(object sender, EventArgs e)
        {
            string sagsid = null;

            if (sagID_txt != null)
                sagsid = sagID_txt.Text;
            else
                Console.WriteLine("input sagsid");
                

            if (sagStatus_cbox.SelectedItem.ToString() == "Lukket (solgt bolig)")
            {
                MenuBarKnapper.HandlenCreate(sagsid);
            }
        }

        private void btn_beregnSalær_Click(object sender, EventArgs e)
        {
            string sagsid = null;
            handel = new HandelDAL();

            if (sagID_txt != null)
                sagsid = sagID_txt.Text;

            int salgspris = handel.HentSalgsPris(sagsid);
            int.TryParse(antalTimer_txt.Text, out int antaltimer);

            resut_txt.Text = BeregnSalær(salgspris, antaltimer);


        }

        private void btn_OpretSag_Click(object sender, EventArgs e)
        {
            SagBLL sagBLL = new SagBLL(SagsStatus(), SagsBoligID(), SagsSælgerID(), SagsMæglerID());
            SagDAL sagDAL = new SagDAL(sagBLL);

            //Kalder metoden: OpretSag
            sagDAL.OpretSag(sagBLL);

            //Loader data fra databasen ind i datagridview
            //SagsUI_Load(sender, e);

        }

        private void btn_HentSag_Click(object sender, EventArgs e)
        {
            SagBLL sagBLL = new SagBLL(SagsID(), SagsStatus(), SagsBoligID(), SagsSælgerID(), SagsMæglerID());
            SagDAL sagDAL = new SagDAL(sagBLL);

            try
            {
                SagBLL matchingesag = sagDAL.FindSag(sagBLL);
                sagStatus_cbox.Text = matchingesag.Status.ToString();
                sag_boligID_cbox.Text = matchingesag.BoligID.ToString();
                sag_sælgerID_cbox.Text = matchingesag.SælgerID.ToString();
                sag_ejendomsmæglerID_cbox.Text = matchingesag.MæglerID.ToString();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            //Loader data fra databasen ind i datagridview
            //SagsUI_Load(sender, e);
        }

        private void btn_OpdaterSag_Click(object sender, EventArgs e)
        {
            SagBLL sagBLL = new SagBLL(SagsID(), SagsStatus(), SagsBoligID(), SagsSælgerID(), SagsMæglerID());
            SagDAL sagDAL = new SagDAL(sagBLL);

            //Kalder metoden: OpretSag
            sagDAL.OpdaterSag(sagBLL);

            //Loader data fra databasen ind i datagridview
            //SagsUI_Load(sender, e);
        }

        private void btn_SletSag_Click(object sender, EventArgs e)
        {
            SagBLL sagBLL = new SagBLL(SagsID(), SagsStatus(), SagsBoligID(), SagsSælgerID(), SagsMæglerID());
            SagDAL sagDAL = new SagDAL(sagBLL);

            //Kalder metoden: OpretSag
            sagDAL.SletSag(sagBLL);

            //Loader data fra databasen ind i datagridview
            //SagsUI_Load(sender, e);
        }


        #region Konveter Tekstbokse
        public int SagsID()
        {
            int.TryParse(sagID_txt.Text, out int sagsid);
            return sagsid;
        }

        public string SagsStatus()
        {
            return sagStatus_cbox.Text;
        }

        public int SagsBoligID()
        {
            string[] id = sag_boligID_cbox.Text.Split(' ');
            int.TryParse(id[0], out int sagsboligid);
            return sagsboligid;
        }

        public int SagsSælgerID()
        {
            string[] id = sag_sælgerID_cbox.Text.Split(' ');
            int.TryParse(id[0], out int sagssælgerid);

            return sagssælgerid;
        }

        public int SagsMæglerID()
        {
            string[] id = sag_ejendomsmæglerID_cbox.Text.Split(' ');
            int.TryParse(id[0], out int sagsmæglerid);
            return sagsmæglerid;
        }
        #endregion

        private void SagUI_Load(object sender, EventArgs e)
        {

        }


        #region MENUBAREN
        //MENUBAREN
        //SAG MENUBARKNAPPER - I SAG MENU
        private void createToolStripMenuItem_Click(object sender, EventArgs e) //Opret sag
        {
            MenuBarKnapper.SagOpret();
        }

        private void readToolStripMenuItem_Click(object sender, EventArgs e) //Find/hent sag
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

        //EJENDOMSMÆLGER MENUBARKNAPPER - I SAG MENU
        private void ejendomsmægler_createToolStripMenuItem_Click(object sender, EventArgs e) //Opret ejendomsmægler
        {
            MenuBarKnapper.EjendomsmælgerOpret();
        }

        private void ejendomsmægler_readToolStripMenuItem_Click(object sender, EventArgs e) //Find/hent ejendomsmælger
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

        //SÆLGER MENUBARKNAPPER - I SAG MENU
        private void sælger_createToolStripMenuItem_Click(object sender, EventArgs e) //Opret sælger
        {
            MenuBarKnapper.SælgerOpret();
        }

        private void sælger_readToolStripMenuItem_Click(object sender, EventArgs e) //Find/hent sælger
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


        //KØBER MENUBARKNAPPER - I SAG MENU
        private void køber_createToolStripMenuItem1_Click(object sender, EventArgs e) //Opret køber
        {
            MenuBarKnapper.KøberCreate();
        }

        private void køber_readToolStripMenuItem1_Click(object sender, EventArgs e) //Find/hent køber
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

        //BOLIG MENUBARKNAPPER - I SAG MENU
        private void bolig_createToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MenuBarKnapper.OpretBolig();
        }

        private void bolig_readToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MenuBarKnapper.HentOpdaterBolig();
        }

        private void bolig_deleteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MenuBarKnapper.SletBolig();
        }

        //ÅBENT HUS MENUBARKNAPPER - I SAG MENU
        private void komTilÅbentHusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuBarKnapper.ÅbentHus();
        }

        //HANDEL MENUBARKNAPPER - I SAG MENU
        private void createToolStripMenuItem1_Click(object sender, EventArgs e) //Opret handel
        {
            MenuBarKnapper.HandelOpret();
        }

        private void readToolStripMenuItem1_Click(object sender, EventArgs e) //Hent handel
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
        #endregion

        private string BeregnSalær(int salgspris, int antalTimer)
        {
            int salær = antalTimer * 150;

            salær += salgspris / 100 * 2;

            return salær.ToString();
        }


    }
}
