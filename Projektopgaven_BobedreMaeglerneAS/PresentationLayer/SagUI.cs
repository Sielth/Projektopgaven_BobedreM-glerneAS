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

        SagBLL sag;

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

        #region Opret Sag
        //method to create a new Sag
        private void btn_OpretSag_Click(object sender, EventArgs e)
        {
            //Initializes SagBLL and SagDAL
            sag = new SagBLL(SagsStatus(), SagsBoligID(), SagsSælgerID(), SagsMæglerID());

            try
            {
                if (!SagBLL.BoligExistsISag(SagsBoligID()))
                {
                    //creates a new SagBLL in DB
                    sag.OpretSag(sag);

                    //retrieves Sags ID from DB
                    SagBLL matchingsag = SagBLL.HentSag(sag);

                    //show SagsID in TextBox
                    sagID_txt.Text = matchingsag.SagsID.ToString();
                }
                else
                    MessageBox.Show("Der findes allerede en sag med denne bolig ID. Vælg venligst en anden bolig.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //save SagsID in a string
            string sagsid = null;

            if (sagID_txt != null)
                sagsid = sagID_txt.Text;

            //if Sag is beign closed because a house has been sold
            if (sagStatus_cbox.SelectedItem.ToString() == "Lukket (solgt bolig)")
            {
                //user must create a new Handle
                MenuBarKnapper.HandlenCreate(sagsid);
            }

            //Loader data fra databasen ind i datagridview
            SagUI_Load(sender, e);

            //disable alle TextBoxes
            DisableAll();
        }

        //method to clear all TextBoxes and enable/disable the ones we need/don't need
        private void btn_Clear_OpretSag_Click(object sender, EventArgs e)
        {
            //clear all textboxes
            ClearAll();

            //enable all textboxes
            EnableAll();

            //disable SagsID TextBox
            sagID_txt.Enabled = false;
        }
        #endregion

        #region Hent Sag / Opdater Sag
        //method to retrieve a Sag from DB and show its attributes on TextBoxes
        private void btn_HentSag_Click(object sender, EventArgs e)
        {
            //Initializes SagBLL and SagDAL
            sag = new SagBLL(SagsID());

            try
            {
                if (SagBLL.SagExists(SagsID()))
                {
                    //retrieve a SagBLL from DB using SagsID
                    SagBLL matchingesag = SagBLL.HentSagViaID(sag);

                    //shows retrieved Sag from DB on TextBoxes
                    sagStatus_cbox.Text = matchingesag.Status.ToString();
                    sag_boligID_cbox.Text = matchingesag.BoligID.ToString();
                    sag_sælgerID_cbox.Text = matchingesag.SælgerID.ToString();
                    sag_ejendomsmæglerID_cbox.Text = matchingesag.MæglerID.ToString();
                }
                else
                    MessageBox.Show("Der findes ikke nogen bolig i database med dette ID. Prøv venligst med en anden ID.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            sagID_txt.Enabled = false;
        }

        //method to enable all TextBoxes to edit a Bolig
        private void allowRedigering_btn_Click(object sender, EventArgs e)
        {
            //enable all TextBoxes
            EnableAll();

            //disable BoligID TextBox
            sagID_txt.Enabled = false;
            sag_boligID_cbox.Enabled = false;
        }

        //method to update a Sag
        private void btn_OpdaterSag_Click(object sender, EventArgs e)
        {
            //Initializes SagBLL and SagDAL
            sag = new SagBLL(SagsID(), SagsStatus(), SagsBoligID(), SagsSælgerID(), SagsMæglerID());

            try
            {
                if (SagBLL.SagExists(SagsID()))
                {
                    //updates a Sag record
                    sag.OpdaterSag(sag);
                }
                else
                    MessageBox.Show("Der findes ikke nogen bolig i database med dette ID. Prøv venligst med en anden ID.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //if Sag is beign closed because a house has been sold
            if (sagStatus_cbox.SelectedItem.ToString() == "Lukket (solgt bolig)" && !HandelBLL.HandelExists(SagsID()))
            {
                //user must create a new Handle
                MenuBarKnapper.HandlenCreate(SagsID().ToString());
            }

            //Loader data fra databasen ind i datagridview
            SagUI_Load(sender, e);

            //disable all TextBoxes
            DisableAll();
        }

        //method to clear all TextBoxes and enable/disable the ones we need/don't need
        private void btn_Clear_HentSag_Click(object sender, EventArgs e)
        {
            //clear all TextBoxes
            ClearAll();

            //disable all TextBoxes
            DisableAll();

            //enable BoligID TextBox
            sagID_txt.Enabled = true;
        }
        #endregion

        #region Slet Sag
        //method to delete a Sag from DB
        private void btn_SletSag_Click(object sender, EventArgs e)
        {
            //Initializes SagBLL and SagDAL
            sag = new SagBLL(SagsID());

            try
            {
                if (SagBLL.SagExists(SagsID()))
                {
                    //delete a Sag from DB
                    sag.SletSag(sag);
                }
                else
                    MessageBox.Show("Der findes ikke nogen bolig i database med dette ID. Prøv venligst med en anden ID.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //Loader data fra databasen ind i datagridview
            SagUI_Load(sender, e);

            //clear all TextBoxes
            ClearAll();

            //disable all TextBoxes
            DisableAll();

            //enable BoligID TextBox
            sagID_txt.Enabled = true;
        }
        #endregion

        #region Validating SagsID
        private void sagID_txt_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;

            if (!ValidSagsId(sagID_txt.Text, out errorMsg))
            {
                //Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                sagID_txt.Select(0, sagID_txt.Text.Length);

                //Set the ErrorProvider error with the text to display. 
                this.errorProvider1.SetError(sagID_txt, errorMsg);
            }
        }

        private void sagID_txt_Validated(object sender, EventArgs e)
        {
            //If all conditions have been met, clear the ErrorProvider of errors.
            errorProvider1.SetError(sagID_txt, "");
        }

        //Method to check whether BoligID is valid or not
        //It must be only numbers
        //It CAN be empty (be careful when casting to int)
        //CANNOT be bigger than 4
        public bool ValidSagsId(string boligid, out string errorMsg)
        {
            if (boligid.Length > 4)
            {
                errorMsg = "Indtast en Bolig ID mellem 1-999";
                return false;
            }

            if (int.TryParse(boligid, out int result) || string.IsNullOrEmpty(boligid))
            {
                errorMsg = "";
                return true;
            }

            errorMsg = "SagsID kan kun indeholde numre";
            return false;
        }
        #endregion

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

        //SÆLGER MENUBARKNAPPER - I SAG MENU
        private void sælger_createToolStripMenuItem_Click(object sender, EventArgs e) //Opret sælger
        {
            MenuBarKnapper.SælgerOpret();
        }

        private void sælger_readToolStripMenuItem_Click(object sender, EventArgs e) //Find/hent sælger
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


        //KØBER MENUBARKNAPPER - I SAG MENU
        private void køber_createToolStripMenuItem1_Click(object sender, EventArgs e) //Opret køber
        {
            MenuBarKnapper.KøberCreate();
        }

        private void køber_readToolStripMenuItem1_Click(object sender, EventArgs e) //Find/hent køber
        {
            MenuBarKnapper.KøberRead();
        }

        /*private void køber_updateToolStripMenuItem1_Click(object sender, EventArgs e) //Opdater køber
        {
            MenuBarKnapper.KøberUpdate();
        }*/

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

        //private void updateToolStripMenuItem1_Click(object sender, EventArgs e) //Opdater handel
        //{
        //    MenuBarKnapper.HandelOpdater();
        //}

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e) //Slet handel
        {
            MenuBarKnapper.HandelSlet();
        }

        private void udtrækStatistikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuBarKnapper.HandelStatistik();
        }
        #endregion

        private void SagUI_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sagDataSet.Sag' table. You can move, or remove it, as needed.
            this.sagTableAdapter.Fill(this.sagDataSet.Sag);

        }
    }
}
