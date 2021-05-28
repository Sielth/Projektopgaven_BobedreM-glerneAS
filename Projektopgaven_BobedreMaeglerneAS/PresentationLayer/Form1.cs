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
        private Pictures pictures;

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


            //make new instance of Pictures class with reference to pictureBox1 (should probably change the name)
            pictures = new Pictures(pictureBox1);

            //initialize a new thread with ThreadStart calling GeneratePictures method
            Thread t2 = new Thread(new ThreadStart(pictures.GeneratePictures));

            //t2 is set as Background, so that it doesn't interfere with the main thread running the Application
            //and so that we can close the form without triggering a NullReference exception (thread pointing to null)
            //because since it is working in the background, it is going to be closed as soon as the main thread gets closed
            t2.IsBackground = true;

            //Thread t2 is starting now
            t2.Start();
        }

        //method that opens Åbent Hus window when pictureBox1 is clicked
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MenuBarKnapper.ÅbentHus();
        }

        //BOLIG
        private void bolig_createToolStripMenuItem2_Click(object sender, EventArgs e) //Opret bolig
        {
            MenuBarKnapper.OpretBolig();
        }

        private void bolig_readToolStripMenuItem2_Click(object sender, EventArgs e) //Hent og Opdater bolig
        {
            MenuBarKnapper.HentOpdaterBolig();
        }

        private void bolig_deleteToolStripMenuItem2_Click(object sender, EventArgs e) //Slet bolig
        {
            MenuBarKnapper.SletBolig();
        }

        private void komTilÅbentHusToolStripMenuItem_Click(object sender, EventArgs e) //Åbent Hus
        {
            MenuBarKnapper.ÅbentHus();
        }

        //EJENDOMSMÆGLER
        private void ejendomsmægler_createToolStripMenuItem_Click(object sender, EventArgs e) //Opret ejendomsmægler 
        {
            MenuBarKnapper.EjendomsmælgerOpret();
        }

        private void ejendomsmægler_readToolStripMenuItem_Click(object sender, EventArgs e) //Hent ejendomsmægler 
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

        //SÆLGER
        private void sælger_createToolStripMenuItem_Click(object sender, EventArgs e) //Opret sælger
        {
            MenuBarKnapper.SælgerOpret();
        }

        private void sælger_readToolStripMenuItem_Click(object sender, EventArgs e) //Hent sælger
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

        //KØBER
        private void køber_createToolStripMenuItem1_Click(object sender, EventArgs e) //Opret køber
        {
            MenuBarKnapper.KøberCreate();
        }

        private void køber_readToolStripMenuItem1_Click(object sender, EventArgs e) //Hent Køber
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

        //HANDEL
        private void createToolStripMenuItem1_Click(object sender, EventArgs e) //Opret handel
        {
            MenuBarKnapper.HandelOpret();
        }

        private void readToolStripMenuItem1_Click(object sender, EventArgs e) //Find/hent handel
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

        private void beregnSalærToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuBarKnapper.BeregnSalærShow();
        }


    }
}
