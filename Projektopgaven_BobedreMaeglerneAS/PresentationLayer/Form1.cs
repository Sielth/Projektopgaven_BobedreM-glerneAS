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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_bolig_Click(object sender, EventArgs e)
        {
            // Create a new instance of the BoligUI class
            BoligUI boligUI = new BoligUI();

            // Show the settings form
            boligUI.Show();
        }

        // Initialize new Window when Opret Ny Bolig is selected from Form1 menu
        private void opretNyToolStripMenuItem3_Click(object sender, EventArgs e)
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
        }

        // Initialize new Window when Hent Bolig is selected from Form1 menu
        private void bolig_hentToolStripMenuItem3_Click(object sender, EventArgs e)
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
        }

        // Initialize new Window when Opdater Bolig is selected from Form1 menu
        private void bolig_opdaterToolStripMenuItem3_Click(object sender, EventArgs e)
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

        // Initialize new Window when Slet Bolig is selected from Form1 menu
        private void bolig_sletToolStripMenuItem3_Click(object sender, EventArgs e)
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
    }
}
