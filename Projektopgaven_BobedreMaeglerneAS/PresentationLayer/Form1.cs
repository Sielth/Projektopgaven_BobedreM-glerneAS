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

        //KØBER
        private void køber_createToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MenuBarKnapper.KøberCreate();
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
    }
}
