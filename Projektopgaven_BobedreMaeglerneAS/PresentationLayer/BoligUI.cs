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

namespace Projektopgaven_BobedreMaeglerneAS.PresentationLayer
{
    public partial class BoligUI : Form
    {
        public BoligUI()
        {
            InitializeComponent();
        }

        // Method to show the number of rooms as a ToolTip on the TrackBar 
        private void boligVærelser_tbar_Scroll(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(boligVærelser_tbar, boligVærelser_tbar.Value.ToString());
        }

        // Method to show the number of floor as a ToolTip on the TrackBar 
        private void boligEtager_tbar_Scroll(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(boligEtager_tbar, boligEtager_tbar.Value.ToString());
        }

        // Method enable or disable DateTimePicker for BoligRenoveringsÅr through the boligRenoveret Checkbox
        private void boligRenoveret_ckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (boligRenoveret_ckbox.Checked)
                boligRenoveringsÅr_dtp.Enabled = true;
            else
                boligRenoveringsÅr_dtp.Enabled = false;
        }

        #region Opret Bolig
        private void btn_OpretBolig_Click(object sender, EventArgs e)
        {
            BoligBLL boligBLL = new BoligBLL(BoligID(), BoligVej(), BoligPostnr(), BoligType(), BoligVærelser(), BoligEtager(), BoligKvm(), BoligHave(), BoligBygningsÅr(), BoligRenoveringsÅr());
            BoligDAL boligDAL = new BoligDAL(boligBLL);

            boligDAL.OpretBolig(boligBLL);
            //boligDAL.HentBolig(boligDAL, SqlConnection conn); //kun id

            BoligUI_Load(sender, e);
            DisableAll();
        }

        private void btn_Clear_OpretBolig_Click(object sender, EventArgs e)
        {
            ClearAll();
            EnableAll();
            boligID_txt.Enabled = false;
            boligRenoveringsÅr_dtp.Enabled = false;
            boligUdbudspris_txt.Enabled = false;
        }
        #endregion

        #region Hent Bolig
        private void btn_HentBolig_Click(object sender, EventArgs e)
        {
            BoligBLL boligBLL = new BoligBLL(BoligID(), BoligVej(), BoligPostnr(), BoligType(), BoligVærelser(), BoligEtager(), BoligKvm(), BoligHave(), BoligBygningsÅr(), BoligRenoveringsÅr());
            BoligDAL boligDAL = new BoligDAL(boligBLL);

            //boligDAL.HentBolig(boligDAL, SqlConnection conn); //fra textbox

            DisableAll();
        }

        private void btn_Clear_HentBolig_Click(object sender, EventArgs e)
        {
            ClearAll();
            EnableAll();
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

        #region Validating Bolig Udbudspris
        private void boligUdbudspris_txt_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;

            if (!ValidBoligId(boligUdbudspris_txt.Text, out errorMsg))
            {
                //Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                boligUdbudspris_txt.Select(0, boligUdbudspris_txt.Text.Length);

                //Set the ErrorProvider error with the text to display. 
                this.errorProvider1.SetError(boligUdbudspris_txt, errorMsg);
            }
        }

        private void boligUdbudspris_txt_Validated(object sender, EventArgs e)
        {
            //If all conditions have been met, clear the ErrorProvider of errors.
            errorProvider1.SetError(boligUdbudspris_txt, "");
        }

        //Method to check whether BoligID is valid or not
        //It must be only numbers
        //It CAN be empty (be careful when casting to int)
        public bool ValidBoligUdbudspris(string boligid, out string errorMsg)
        {
            if (int.TryParse(boligid, out int result) || string.IsNullOrEmpty(boligid))
            {
                errorMsg = "";
                return true;
            }

            errorMsg = "Udbudspris kan kun indeholde numre";
            return false;
        }
        #endregion

        #region Convert Textboxes
        public int BoligID()
        {
            int.TryParse(boligID_txt.Text, out int boligid);
            return boligid;
        }

        public string BoligVej()
        {
            return boligVej_txt.Text;
        }

        public int BoligPostnr()
        {
            int.TryParse(boligPostnr_txt.Text, out int boligpostnr);
            return boligpostnr;
        }

        public string BoligType()
        {
            return boligType_cbox.SelectedItem.ToString();
        }

        public int BoligVærelser()
        {
            return boligVærelser_tbar.Value;
        }

        public int BoligEtager()
        {
            return boligEtager_tbar.Value;
        }

        public int BoligKvm()
        {
            int.TryParse(boligKvm_txt.Text, out int boligkvm);
            return boligkvm;
        }

        public int BoligBygningsÅr()
        {
            return (int)boligBygningsÅr_dtp.Value.Year;
        }

        public int BoligRenoveringsÅr()
        {
            if (boligRenoveret_ckbox.Checked)
            {
                return (int)boligRenoveringsÅr_dtp.Value.Year;
            }

            else
                return 0;
        }

        public int BoligHave()
        {
            if (boligHave_ckBox.Checked)
                return 1;
            else
                return 0;
        }

        public int BoligUdbudspris()
        {
            int.TryParse(boligUdbudspris_txt.Text, out int boligudbudspris);
            return boligudbudspris;
        }
        #endregion

        private void BoligUI_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bobedredbDataSet.Bolig' table. You can move, or remove it, as needed.
            //this.boligTableAdapter.Fill(this.bobedredbDataSet.Bolig);
        }

    }
}
