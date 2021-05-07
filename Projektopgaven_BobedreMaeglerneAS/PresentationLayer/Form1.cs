using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projektopgaven_BobedreMaeglerneAS.PresentationLayer;

namespace Projektopgaven_BobedreMaeglerneAS
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }

        private void bolig_createToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            // Create a new instance of the BoligUI class
            BoligUI boligUI = new BoligUI();

            // Show the settings form
            boligUI.Show();

            // Disable not needed buttons
            boligUI.GetHentBoligButton().Visible = false;
            boligUI.GetOpdaterBoligButton().Visible = false;
            boligUI.GetSletBoligButton().Visible = false;

            // Disable not needed textboxes
            boligUI.GetBoligIDTextbox().Enabled = false;
            boligUI.GetBoligRenoveringsÅrDateTimePicker().Enabled = false;
            boligUI.GetBoligUdbudsprisTextbox().Enabled = false;
        }

        private void bolig_readToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            // Create a new instance of the BoligUI class
            BoligUI boligUI = new BoligUI();

            // Show the settings form
            boligUI.Show();

            // Disable not needed buttons
            boligUI.GetOpretBoligButton().Visible = false;
            boligUI.GetOpdaterBoligButton().Visible = false;
            boligUI.GetSælgBoligButton().Visible = false;
            boligUI.GetSletBoligButton().Visible = false;

            boligUI.DisableAll();
            boligUI.GetBoligIDTextbox().Enabled = true;
        }

        private void bolig_updateToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            // Create a new instance of the BoligUI class
            BoligUI boligUI = new BoligUI();

            // Show the settings form
            boligUI.Show();

            // Disable not needed buttons
            boligUI.GetOpretBoligButton().Visible = false;
            boligUI.GetHentBoligButton().Visible = false;
            boligUI.GetSletBoligButton().Visible = false;

            // Disable not needed TextBoxes
            boligUI.GetBoligIDTextbox().Enabled = false;
        }

        private void bolig_deleteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            // Create a new instance of the BoligUI class
            BoligUI boligUI = new BoligUI();

            // Show the settings form
            boligUI.Show();

            // Disable not needed buttons
            boligUI.GetOpretBoligButton().Visible = false;
            boligUI.GetHentBoligButton().Visible = false;
            boligUI.GetOpdaterBoligButton().Visible = false;
            boligUI.GetSælgBoligButton().Visible = false;
        }

        //EJENDOMSMÆGLER
        private void ejendomsmægler_createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create a new instance of the BoligUI class
            EjendomsmæglerUI ejendomsmæglerUI = new EjendomsmæglerUI();

            // Show the settings form
            ejendomsmæglerUI.Show();

            ejendomsmæglerUI.btn_HentEjendomsmægler.Visible = false;
            ejendomsmæglerUI.btn_OpdaterEjendomsmægler.Visible = false;
            ejendomsmæglerUI.btn_SletEjendomsmægler.Visible = false;
        }

        private void ejendomsmægler_readToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create a new instance of the BoligUI class
            EjendomsmæglerUI ejendomsmæglerUI = new EjendomsmæglerUI();

            // Show the settings form
            ejendomsmæglerUI.Show();

            ejendomsmæglerUI.btn_OpretEjendomsmægler.Visible = false;
            ejendomsmæglerUI.btn_OpdaterEjendomsmægler.Visible = false;
            ejendomsmæglerUI.btn_SletEjendomsmægler.Visible = false;
        }

        private void ejendomsmægler_updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create a new instance of the BoligUI class
            EjendomsmæglerUI ejendomsmæglerUI = new EjendomsmæglerUI();

            // Show the settings form
            ejendomsmæglerUI.Show();

            ejendomsmæglerUI.btn_OpretEjendomsmægler.Visible = false;
            ejendomsmæglerUI.btn_HentEjendomsmægler.Visible = false;
            ejendomsmæglerUI.btn_SletEjendomsmægler.Visible = false;
        }

        private void ejendomsmægler_deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create a new instance of the BoligUI class
            EjendomsmæglerUI ejendomsmæglerUI = new EjendomsmæglerUI();

            // Show the settings form
            ejendomsmæglerUI.Show();

            ejendomsmæglerUI.btn_OpretEjendomsmægler.Visible = false;
            ejendomsmæglerUI.btn_HentEjendomsmægler.Visible = false;
            ejendomsmæglerUI.btn_OpdaterEjendomsmægler.Visible = false;
        }

        //KØBER
        private void sælger_createToolStripMenuItem_Click(object sender, EventArgs e) //Opret sælger
        {
            // Create a new instance of the SælgerUI class
            SælgerUI sælgerUI = new SælgerUI();

            // Show the settings form
            sælgerUI.Show();
        }

        private void sælger_readToolStripMenuItem_Click(object sender, EventArgs e) //Hent sælger
        {
            // Create a new instance of the SælgerUI class
            SælgerUI sælgerUI = new SælgerUI();

            // Show the settings form
            sælgerUI.Show();
        }

        private void sælger_updateToolStripMenuItem_Click(object sender, EventArgs e) //Opdater sælger
        {
            // Create a new instance of the SælgerUI class
            SælgerUI sælgerUI = new SælgerUI();

            // Show the settings form
            sælgerUI.Show();
        }

        private void sælger_deleteToolStripMenuItem_Click(object sender, EventArgs e) //Slet sælger
        {
            // Create a new instance of the SælgerUI class
            SælgerUI sælgerUI = new SælgerUI();

            // Show the settings form
            sælgerUI.Show();
        }
    }
}
