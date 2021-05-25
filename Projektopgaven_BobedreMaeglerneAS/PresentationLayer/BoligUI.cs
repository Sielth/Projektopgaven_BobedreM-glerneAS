using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using Projektopgaven_BobedreMæglerneAS;
using Projektopgaven_BobedreMaeglerneAS.DataAccessLayer;

//MEMO
//REMEMBER TO FIND A WAY TO SHOW SOME TRICKY ATTRIBUTES WHEN YOU PRESS HENT BUTTON
//REMEMBER TO ADD TO THE SWITCH CASE SOME TRICKY FILTER CRITERIA

namespace Projektopgaven_BobedreMaeglerneAS.PresentationLayer
{
    public partial class BoligUI : Form
    {
        public BoligUI()
        {
            InitializeComponent();
        }

        //method to refresh DataGridView
        private void BoligUI_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bolig_bobedredbDataSet.Bolig' table. You can move, or remove it, as needed.
            //this.boligTableAdapter.Fill(this.bolig_bobedredbDataSet.Bolig);
        }

        //method to show the number of rooms as a ToolTip on the TrackBar 
        private void boligVærelser_tbar_Scroll(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(boligVærelser_tbar, boligVærelser_tbar.Value.ToString());
        }

        //method to show the number of floor as a ToolTip on the TrackBar 
        private void boligEtager_tbar_Scroll(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(boligEtager_tbar, boligEtager_tbar.Value.ToString());
        }

        //method enable or disable DateTimePicker for BoligRenoveringsÅr through the boligRenoveret Checkbox
        private void boligRenoveret_ckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (boligRenoveret_ckbox.Checked)
                boligRenoveringsÅr_dtp.Enabled = true;
            else
                boligRenoveringsÅr_dtp.Enabled = false;
        }

        private void boligBygningsÅr_dtp_ValueChanged(object sender, EventArgs e)
        {
            boligRenoveringsÅr_dtp.Value = boligBygningsÅr_dtp.Value;
        }

        #region Opret Bolig
        //method to create a new Bolig
        private void btn_OpretBolig_Click(object sender, EventArgs e)
        {
            //initializes BoligBLL and BoligDAL
            BoligBLL boligBLL = new BoligBLL(BoligID(), BoligVej(), BoligPostnr(), BoligType(), BoligVærelser(), BoligEtager(), BoligKvm(), BoligHave(), BoligBygningsÅr(), BoligRenoveringsÅr());
            //BoligDAL boligDAL = new BoligDAL(boligBLL);

            try
            {
                //creates a new BoligBLL in DB
                boligBLL.OpretBolig(boligBLL);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                //retrieves Bolig ID from DB
                BoligBLL matchingbolig = boligDAL.HentBolig(boligBLL);

                //shows BoligID in TextBox
                boligID_txt.Text = matchingbolig.BoligID.ToString();
                boligUdbudspris_txt.Text = matchingbolig.Udbudspris.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //load DataGridView
            BoligUI_Load(sender, e);

            //disable all TextBoxes
            DisableAll();
        }

        //method to clear all TextBoxes and enable/disable the ones we need/don't need
        private void btn_Clear_OpretBolig_Click(object sender, EventArgs e)
        {
            //clear all TextBoxes
            ClearAll();

            //enable all TextBoxes
            EnableAll();

            //disable BoligID, RenoveringsÅr, Udbudspris TextBoxes
            boligID_txt.Enabled = false;
            boligRenoveringsÅr_dtp.Enabled = false;
            boligUdbudspris_txt.Enabled = false;
        }
        #endregion

        #region Hent Bolig / Opdater Bolig
        public void HentClick()
        {
            object sender = new object();
            EventArgs e = new EventArgs();

            btn_HentBolig_Click(sender, e);
        }

        //method to retrieve a Bolig from DB and show its attributes on TextBoxes
        private void btn_HentBolig_Click(object sender, EventArgs e)
        {
            //initializes BoligBLL and BoligDAL
            BoligBLL boligBLL = new BoligBLL(BoligID());
            BoligDAL boligDAL = new BoligDAL(boligBLL);

            try
            {
                //retrieve a BoligBLL from DB using BoligID
                BoligBLL matchingbolig = boligDAL.HentBoligViaID(boligBLL);
                
                //shows retrieved Bolig from DB on TextBoxes
                boligVej_txt.Text = matchingbolig.Vej.ToString();
                boligPostnr_txt.Text = matchingbolig.Postnummer.ToString();
                boligType_cbox.Text = matchingbolig.Type.ToString();
                boligVærelser_tbar.Value = matchingbolig.Værelser;
                boligEtager_tbar.Value = matchingbolig.Etager;
                boligKvm_txt.Text = matchingbolig.Kvadratmeter.ToString();
                boligHave_ckBox.Checked = matchingbolig.Have;
                boligBygningsÅr_dtp.Value = matchingbolig.Bygningsår;
                boligRenoveringsÅr_dtp.Value = matchingbolig.RenoveringsÅr;
                boligUdbudspris_txt.Text = matchingbolig.Udbudspris.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //disable BoligID TextBox
            boligID_txt.Enabled = false;
        }
        
        //method to enable all TextBoxes to edit a Bolig
        private void allowRedigering_btn_Click(object sender, EventArgs e)
        {
            //enable all TextBoxes
            EnableAll();

            //disable BoligID TextBox
            boligID_txt.Enabled = false;
        }

        //method to confirm the changes in a Bolig (UPDATE)
        private void saveChanges_btn_Click(object sender, EventArgs e)
        {
            //initializes BoligBLL and BoligDAL
            BoligBLL boligBLL = new BoligBLL(BoligID(), BoligVej(), BoligPostnr(), BoligType(), BoligVærelser(), BoligEtager(), BoligKvm(), BoligUdbudspris(), BoligHave(), BoligBygningsÅr(), BoligRenoveringsÅr());
            BoligDAL boligDAL = new BoligDAL(boligBLL);

            try
            {
                //updates a Bolig record
                boligDAL.OpdaterBolig(boligBLL);

                //henter en bolig
                btn_HentBolig_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //load DataGridView
            BoligUI_Load(sender, e);

            //disable all TextBoxes
            DisableAll();
        }

        //method to search and filter DataGridView
        private void search_txt_TextChanged(object sender, EventArgs e)
        {
            //filter criteria from ComboBox
            string input = filterCriteria_cbox.SelectedItem.ToString();

            switch (input)
            {
                case "Bolig ID":
                    this.boligBindingSource.Filter = string.Format("Convert(BoligID, 'System.String') LIKE '*{0}*'", search_txt.Text);
                    break;
                case "Adresse":
                    this.boligBindingSource.Filter = string.Format("Vej LIKE '*{0}*'", search_txt.Text);
                    break;
                case "Postnummer":
                    this.boligBindingSource.Filter = string.Format("Convert(Postnummer, 'System.String') LIKE '%{0}%'", search_txt.Text);
                    break;
                case "Bolig Type":
                    this.boligBindingSource.Filter = string.Format("Type LIKE '*{0}*'", search_txt.Text);
                    break;
                case "Værelser":
                    this.boligBindingSource.Filter = string.Format("Convert(Værelser, 'System.String') LIKE '*{0}*'", search_txt.Text);
                    break;
                case "Etager":
                    this.boligBindingSource.Filter = string.Format("Convert(Etager, 'System.String') LIKE '*{0}*'", search_txt.Text);
                    break;
                case "Kvadratmeter":
                    this.boligBindingSource.Filter = string.Format("Convert(Kvadratmeter, 'System.String') LIKE '*{0}*'", search_txt.Text);
                    break;
                case "Bygningsår":
                    this.boligBindingSource.Filter = string.Format("Convert(Bygningsår, 'System.String') LIKE '*{0}*'", search_txt.Text);
                    break;
                case "Renoveringsår":
                    this.boligBindingSource.Filter = string.Format("Convert(RenoveringsÅr, 'System.String') LIKE '*{0}*'", search_txt.Text);
                    break;
                case "Udbudspris (lower than)":
                    this.boligBindingSource.Filter = string.Format("Convert(Udbudspris, 'System.String') <= '*{0}*'", search_txt.Text);
                    break;
                case "Udbudspris (higher than)": 
                    this.boligBindingSource.Filter = string.Format("Convert(Udbudspris, 'System.String') >= '*{0}*'", search_txt.Text);
                    break;
            }
        }

        //method to clear all TextBoxes and enable/disable the ones we need/don't need
        private void btn_Clear_HentBolig_Click(object sender, EventArgs e)
        {
            //clear all TextBoxes
            ClearAll();

            //disable all TextBoxes
            DisableAll();

            //enable BoligID TextBox
            boligID_txt.Enabled = true;
        }
        #endregion

        #region Slet Bolig
        //method to delete a Bolig from DB
        private void btn_SletBolig_Click(object sender, EventArgs e)
        {
            //initializes BoligBLL and BoligDAL
            BoligBLL boligBLL = new BoligBLL(BoligID(), BoligVej(), BoligPostnr(), BoligType(), BoligVærelser(), BoligEtager(), BoligKvm(), BoligHave(), BoligBygningsÅr(), BoligRenoveringsÅr());
            BoligDAL boligDAL = new BoligDAL(boligBLL);

            try
            {
                //delete a Bolig from DB
                boligDAL.SletBolig(boligBLL);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //load DataGridView
            BoligUI_Load(sender, e);

            //clear all TextBoxes
            ClearAll();

            //disable all TextBoxes
            DisableAll();

            //enable BoligID TextBox
            boligID_txt.Enabled = true;
        }
        #endregion

        #region Validating BoligID
        private void boligID_txt_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;

            if (!ValidBoligId(boligID_txt.Text, out errorMsg))
            {
                //Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                boligID_txt.Select(0, boligID_txt.Text.Length);

                //Set the ErrorProvider error with the text to display. 
                this.errorProvider1.SetError(boligID_txt, errorMsg);
            }
        }

        private void boligID_txt_Validated(object sender, EventArgs e)
        {
            //If all conditions have been met, clear the ErrorProvider of errors.
            errorProvider1.SetError(boligID_txt, "");
        }

        //Method to check whether BoligID is valid or not
        //It must be only numbers
        //It CAN be empty (be careful when casting to int)
        //CANNOT be bigger than 4
        public bool ValidBoligId(string boligid, out string errorMsg)
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

            errorMsg = "Bolig ID kan kun indeholde numre";
            return false;
        }
        #endregion

        #region Validating BoligVej
        private void boligVej_txt_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;

            if (!ValidBoligVej(boligVej_txt.Text, out errorMsg))
            {
                //Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                boligVej_txt.Select(0, boligVej_txt.Text.Length);

                //Set the ErrorProvider error with the text to display. 
                this.errorProvider1.SetError(boligVej_txt, errorMsg);
            }
        }

        private void boligVej_txt_Validated(object sender, EventArgs e)
        {
            //If all conditions have been met, clear the ErrorProvider of errors.
            errorProvider1.SetError(boligVej_txt, "");
        }

        //Method to check whether BoligVej is valid or not
        //It must be only characters
        //It CAN be empty
        //CANNOT be bigger than 30
        public bool ValidBoligVej(string boligvej, out string errorMsg)
        {
            if (!Regex.IsMatch(boligvej, "^(?:[-a-zA-ZæÆåÅøØ0-9., ]|)+$"))
            {
                errorMsg = "De karakter indtastet er ikke gyldig";
                return false;
            }

            if (boligvej.Length < 30 || string.IsNullOrEmpty(boligvej))
            {
                errorMsg = "";
                return true;
            }

            errorMsg = "Adresse kan kun indeholde 30 karakter";
            return false;
        }
        #endregion

        #region Validating Bolig Postnummer
        private void boligPostnr_txt_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;

            if (!ValidBoligPostnr(boligPostnr_txt.Text, out errorMsg))
            {
                //Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                boligPostnr_txt.Select(0, boligPostnr_txt.Text.Length);

                //Set the ErrorProvider error with the text to display. 
                this.errorProvider1.SetError(boligPostnr_txt, errorMsg);
            }
        }

        private void boligPostnr_txt_Validated(object sender, EventArgs e)
        {
            //If all conditions have been met, clear the ErrorProvider of errors.
            errorProvider1.SetError(boligPostnr_txt, "");
        }

        //Method to check whether BoligPostnr is valid or not
        //It must be only numbers
        //It CAN be empty (be careful when casting to int)
        //CANNOT be bigger than 4
        private bool ValidBoligPostnr(string boligpostnr, out string errorMsg)
        {
            if (boligpostnr.Length > 4)
            {
                errorMsg = "Det indtastet postnummer er ikke gyldig i DK";
                return false;
            }

            if (int.TryParse(boligpostnr, out int result) || string.IsNullOrEmpty(boligpostnr))
            {
                errorMsg = "";
                return true;
            }

            errorMsg = "Postnummer kan kun indeholde numre";
            return false;
        }
        #endregion

        #region Validating Bolig Kvadratmeter
        private void boligKvm_txt_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;

            if (!ValidBoligKvm(boligKvm_txt.Text, out errorMsg))
            {
                //Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                boligKvm_txt.Select(0, boligKvm_txt.Text.Length);

                //Set the ErrorProvider error with the text to display. 
                this.errorProvider1.SetError(boligKvm_txt, errorMsg);
            }
        }

        private void boligKvm_txt_Validated(object sender, EventArgs e)
        {
            //If all conditions have been met, clear the ErrorProvider of errors.
            errorProvider1.SetError(boligKvm_txt, "");
        }

        //Method to check whether BoligKvm is valid or not
        //It must be only numbers
        //It CAN be empty (be careful when casting to int)
        //CANNOT be bigger than 3
        private bool ValidBoligKvm(string boligkvm, out string errorMsg)
        {
            if (boligkvm.Length > 3)
            {
                errorMsg = "Indtast antal kvadratmeter mellem 1-999";
                return false;
            }

            if (int.TryParse(boligkvm, out int result) || string.IsNullOrEmpty(boligkvm))
            {
                errorMsg = "";
                return true;
            }

            errorMsg = "Kvadratmeter kan kun indeholde numre";
            return false;
        }
        #endregion

        #region Convert Textboxes
        private int BoligID()
        {
            int.TryParse(boligID_txt.Text, out int boligid);
            return boligid;
        }

        private string BoligVej()
        {
            return boligVej_txt.Text;
        }

        private int BoligPostnr()
        {
            int.TryParse(boligPostnr_txt.Text, out int boligpostnr);
            return boligpostnr;
        }

        private string BoligType()
        {
            if (boligType_cbox.SelectedItem != null)
                return boligType_cbox.SelectedItem.ToString();
            else
                return null;
        }

        private int BoligVærelser()
        {
            return boligVærelser_tbar.Value;
        }

        private int BoligEtager()
        {
            return boligEtager_tbar.Value;
        }

        private int BoligKvm()
        {
            int.TryParse(boligKvm_txt.Text, out int boligkvm);
            return boligkvm;
        }

        private DateTime BoligBygningsÅr()
        {
            return boligBygningsÅr_dtp.Value;
        }

        private DateTime BoligRenoveringsÅr()
        {
            return boligRenoveringsÅr_dtp.Value;
        }

        private bool BoligHave()
        {
            if (boligHave_ckBox.Checked)
                return true;
            else
                return false;
        }

        private int BoligUdbudspris()
        {
            int.TryParse(boligUdbudspris_txt.Text, out int boligudbudspris);
            return boligudbudspris;
        }
        #endregion

        #region Links to Other Windows
        //EJENDOMSMÆGLER
        private void ejendomsmægler_createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuBarKnapper.EjendomsmælgerOpret();
        }

        private void ejendomsmægler_readToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuBarKnapper.EjendomsmæglerHent();
        }

        private void ejendomsmægler_updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuBarKnapper.EjendomsmæglerOpdater();
        }

        private void ejendomsmægler_deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuBarKnapper.EjendomsmæglerSlet();
        }

        //SÆLGER
        private void sælger_createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuBarKnapper.SælgerOpret();
        }

        private void sælger_readToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuBarKnapper.SælgerHent();
        }

        private void sælger_updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuBarKnapper.SælgerOpdater();
        }

        private void sælger_deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuBarKnapper.SælgerSlet();
        }

        //KØBER
        private void køber_createToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MenuBarKnapper.KøberCreate();
        }

        private void køber_readToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MenuBarKnapper.KøberRead();
        }

        private void køber_updateToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MenuBarKnapper.KøberUpdate();
        }

        private void køber_deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MenuBarKnapper.KøberDelete();
        }

        //BOLIG
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

        private void komTilÅbentHusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuBarKnapper.ÅbentHus();
        }

        //SAG
        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuBarKnapper.SagOpret();
        }

        private void readToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuBarKnapper.SagHent();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuBarKnapper.SagOpdater();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuBarKnapper.SagSlet();
        }

        //HANDEL
        private void createToolStripMenuItem1_Click(object sender, EventArgs e) //Opret handel
        {
            MenuBarKnapper.HandelOpret();
        }

        private void readToolStripMenuItem1_Click(object sender, EventArgs e) //Hent handel
        {
            MenuBarKnapper.HandelHent();
        }

        private void updateToolStripMenuItem_Click_1(object sender, EventArgs e) //Opdater handel
        {
            MenuBarKnapper.HandelOpdater();
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e) //Slet handel
        {
            MenuBarKnapper.HandelSlet();
        }

        #endregion

    }
}