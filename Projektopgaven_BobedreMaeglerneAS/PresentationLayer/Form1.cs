using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using Projektopgaven_BobedreMaeglerneAS.BusinessLogicLayer;
using Projektopgaven_BobedreMaeglerneAS.PresentationLayer;

namespace Projektopgaven_BobedreMaeglerneAS
{
    public partial class Homepage : Form
    {
        private EjendomsmæglerOplysninger ejendomsmæglerOplysninger1;

        public Homepage()
        {
            InitializeComponent();

            //make new instance of EjendomsmæglerOplysninger class with reference to richTextBox1 (should probably change the name)
            ejendomsmæglerOplysninger1 = new EjendomsmæglerOplysninger(richTextBox1);

            //initialize a new thread with ThreadStart calling GenerateEjendomsmægler method
            Thread t1 = new Thread(new ThreadStart(ejendomsmæglerOplysninger1.GenerateEjendomsmægler));

            //t1 is set as Background, so that it doesn't interfere with the main thread running the Application
            //and so that we can close the form without triggering a NullReference exception (thread pointing to null)
            //because since it is working in the background, it is going to be closed as soon as the main thread gets closed
            t1.IsBackground = true;

            //Thread t1 is starting now
            t1.Start();
        }

        //BOLIG
        private void bolig_createToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            // Create a new instance of the BoligUI class
            BoligUI boligUI = new BoligUI();

            // Show the settings form
            boligUI.Show();

            // Disable not needed buttons
            boligUI.GetHentBoligButton().Visible = false;
            boligUI.GetSletBoligButton().Visible = false;
            boligUI.GetClearHentBoligButton().Visible = false;
            boligUI.GetAllowRedigeringButton().Visible = false;
            boligUI.GetSaveChangesButton().Visible = false;

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
            boligUI.GetSletBoligButton().Visible = false;
            boligUI.GetClearOpretBoligButton().Visible = false;

            boligUI.DisableAll();
            boligUI.GetBoligIDTextbox().Enabled = true;
        }

        private void bolig_updateToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            // Create a new instance of the BoligUI class
            //BoligUI boligUI = new BoligUI();

            //// Show the settings form
            //boligUI.Show();

            //// Disable not needed buttons
            //boligUI.GetOpretBoligButton().Visible = false;
            //boligUI.GetHentBoligButton().Visible = false;
            //boligUI.GetSletBoligButton().Visible = false;

            //// Disable not needed TextBoxes
            //boligUI.GetBoligIDTextbox().Enabled = false;
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
            boligUI.GetClearOpretBoligButton().Visible = false;
            boligUI.GetClearHentBoligButton().Visible = false;
            boligUI.GetAllowRedigeringButton().Visible = false;
            boligUI.GetSaveChangesButton().Visible = false;

            // Disable not needed TextBoxes
            boligUI.DisableAll();
            boligUI.GetBoligIDTextbox().Enabled = true;
        }

        //EJENDOMSMÆGLER
        private void ejendomsmægler_createToolStripMenuItem_Click(object sender, EventArgs e) //Ejendomsmægler Opret
        {
            MenuBarKnapper.EjendomsmælgerOpret();
        }

        private void ejendomsmægler_readToolStripMenuItem_Click(object sender, EventArgs e) //Ejendomsmægler hent
        {
            MenuBarKnapper.EjendomsmæglerHent();
        }

        private void ejendomsmægler_updateToolStripMenuItem_Click(object sender, EventArgs e) //Ejendomsmægler opdater
        {
            MenuBarKnapper.EjendomsmæglerOpdater();
        }

        private void ejendomsmægler_deleteToolStripMenuItem_Click(object sender, EventArgs e) //Ejendomsmægler slet
        {
            MenuBarKnapper.EjendomsmæglerSlet();
        }

        //SÆLGER
        private void sælger_createToolStripMenuItem_Click(object sender, EventArgs e) //Opret sælger
        {
            // Create a new instance of the SælgerUI class
            SælgerUI sælgerUI = new SælgerUI();

            // Show the settings form
            sælgerUI.Show();

            sælgerUI.GetHentSælgerKnap().Visible = false;
            sælgerUI.GetOpdaterSælgerKnap().Visible = false;
            sælgerUI.GetSletSælgerKnap().Visible = false;
            sælgerUI.GetSælgerIDTekstboks().Enabled = false;
        }

        private void sælger_readToolStripMenuItem_Click(object sender, EventArgs e) //Hent sælger
        {
            // Create a new instance of the SælgerUI class
            SælgerUI sælgerUI = new SælgerUI();

            // Show the settings form
            sælgerUI.Show();

            sælgerUI.GetOpretSælgerKnap().Visible = false;
            sælgerUI.GetOpdaterSælgerKnap().Visible = false;
            sælgerUI.GetSletSælgerKnap().Visible = false;

        }

        private void sælger_updateToolStripMenuItem_Click(object sender, EventArgs e) //Opdater sælger
        {
            // Create a new instance of the SælgerUI class
            SælgerUI sælgerUI = new SælgerUI();

            // Show the settings form
            sælgerUI.Show();

            sælgerUI.GetOpretSælgerKnap().Visible = false;
            sælgerUI.GetHentSælgerKnap().Visible = false;
            sælgerUI.GetSletSælgerKnap().Visible = false;
        }

        private void sælger_deleteToolStripMenuItem_Click(object sender, EventArgs e) //Slet sælger
        {
            // Create a new instance of the SælgerUI class
            SælgerUI sælgerUI = new SælgerUI();

            // Show the settings form
            sælgerUI.Show();

            sælgerUI.GetOpretSælgerKnap().Visible = false;
            sælgerUI.GetHentSælgerKnap().Visible = false;
            sælgerUI.GetOpdaterSælgerKnap().Visible = false;
            sælgerUI.GetSælgerCPRTekstboks().Enabled = false;
            sælgerUI.GetSælgerTelefonTekstboks().Enabled = false;
            sælgerUI.GetSælgerEmailTekstboks().Enabled = false;
            sælgerUI.GetSælgerFnavnTekstboks().Enabled = false;
            sælgerUI.GetSælgerEnavnTekstboks().Enabled = false;
            sælgerUI.GetSælgerVejTekstboks().Enabled = false;
            sælgerUI.GetSælgerPostnummerTekstboks().Enabled = false;
        }

        //KØBER
        private void køber_createToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MenuBarKnapper.KøberCreate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ejendomsmæglerOplysninger1 = new EjendomsmæglerOplysninger(richTextBox1);
            //Thread t1 = new Thread(new ThreadStart(ejendomsmæglerOplysninger1.GenerateEjendomsmægler));
            //t1.IsBackground = true;
            //t1.Start();
        }

        //SAG
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

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e) //Delete sag
        {
            MenuBarKnapper.SagSlet();
        }


        private void Homepage_Load(object sender, EventArgs e)
        {

        }
    }
}
