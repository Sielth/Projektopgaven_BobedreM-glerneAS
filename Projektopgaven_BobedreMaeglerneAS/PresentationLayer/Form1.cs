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

        private void createToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            // Create a new instance of the BoligUI class
            BoligUI boligUI = new BoligUI();

            // Show the settings form
            boligUI.Show();

            boligUI.btn_HentBolig.Visible = false;
            
        }

        private void readToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            // Create a new instance of the BoligUI class
            BoligUI boligUI = new BoligUI();

            // Show the settings form
            boligUI.Show();

            boligUI.btn_OpretBolig.Visible = false;
        }

        private void uyhgfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create a new instance of the BoligUI class
            EjendomsmæglerUI ejendomsmæglerUI = new EjendomsmæglerUI();

            // Show the settings form
            ejendomsmæglerUI.Show();

            ejendomsmæglerUI.btn_HentEjendomsmægler.Visible = false;
            ejendomsmæglerUI.btn_OpdaterEjendomsmægler.Visible = false;
            ejendomsmæglerUI.btn_SletEjendomsmægler.Visible = false;
        }

        private void readToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create a new instance of the BoligUI class
            EjendomsmæglerUI ejendomsmæglerUI = new EjendomsmæglerUI();

            // Show the settings form
            ejendomsmæglerUI.Show();

            ejendomsmæglerUI.btn_OpretEjendomsmægler.Visible = false;
            ejendomsmæglerUI.btn_OpdaterEjendomsmægler.Visible = false;
            ejendomsmæglerUI.btn_SletEjendomsmægler.Visible = false;
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create a new instance of the BoligUI class
            EjendomsmæglerUI ejendomsmæglerUI = new EjendomsmæglerUI();

            // Show the settings form
            ejendomsmæglerUI.Show();

            ejendomsmæglerUI.btn_OpretEjendomsmægler.Visible = false;
            ejendomsmæglerUI.btn_HentEjendomsmægler.Visible = false;
            ejendomsmæglerUI.btn_SletEjendomsmægler.Visible = false;
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create a new instance of the BoligUI class
            EjendomsmæglerUI ejendomsmæglerUI = new EjendomsmæglerUI();

            // Show the settings form
            ejendomsmæglerUI.Show();

            ejendomsmæglerUI.btn_OpretEjendomsmægler.Visible = false;
            ejendomsmæglerUI.btn_HentEjendomsmægler.Visible = false;
            ejendomsmæglerUI.btn_OpdaterEjendomsmægler.Visible = false;
        }
    }
}
