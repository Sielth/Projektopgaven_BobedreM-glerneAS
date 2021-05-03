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
using Projektopgaven_BobedreMæglerneAS;

namespace Projektopgaven_BobedreMaeglerneAS.PresentationLayer
{
    public partial class BoligUI : Form
    {
        public BoligUI()
        {
            InitializeComponent();
        }

        private void btn_OpretBolig_Click(object sender, EventArgs e)
        {

        }

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
        public bool ValidBoligId(string boligid, out string errorMsg)
        {
            if (int.TryParse(boligid, out int result) || boligid == null)
            {
                errorMsg = "";
                return true;
            }

            errorMsg = "id must be numbers";
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

        public bool ValidBoligVej(string boligvej, out string errorMsg)
        {
            if (!Regex.IsMatch(boligvej, "^[-a-zA-ZæÆåÅøØ0-9., ]+$"))
            {
                errorMsg = "contains non valid charachters";
                return false;
            }

            if (boligvej.Length < 30)
            {
                errorMsg = "";
                return true;
            }

            errorMsg = "vej must be shorter than 30";
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

        private bool ValidBoligPostnr(string boligvej, out string errorMsg)
        {
            if (boligvej.Length > 4)
            {
                errorMsg = "postnr is max 4 numbers";
                return false;
            }

            if (int.TryParse(boligvej, out int result))
            {
                errorMsg = "";
                return true;
            }

            errorMsg = "id must be numbers";
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

        private bool ValidBoligKvm(string boligkvm, out string errorMsg)
        {
            if (boligkvm.Length > 3)
            {
                errorMsg = "1wrong kvm";
                return false;
            }

            if (int.TryParse(boligkvm, out int result))
            {
                errorMsg = "";
                return true;
            }
            else if (string.IsNullOrEmpty(boligkvm))
            {
                errorMsg = "";
                return true;
            }


            errorMsg = "kvm must be numbers";
            return false;
        }
        #endregion

        private void boligEtager_tbar_Scroll(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(boligEtager_tbar, boligEtager_tbar.Value.ToString());
        }

        private void boligVærelser_tbar_Scroll(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(boligVærelser_tbar, boligVærelser_tbar.Value.ToString());
        }
    }
}
