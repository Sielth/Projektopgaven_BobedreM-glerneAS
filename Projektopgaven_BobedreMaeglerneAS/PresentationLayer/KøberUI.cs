using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projektopgaven_BobedreMaeglerneAS.PresentationLayer
{
    public partial class KøberUI : Form
    {
        public KøberUI()
        {
            InitializeComponent();
        }
        #region Ejendomsmæglerknapper
        private void uyhgfToolStripMenuItem_Click(object sender, EventArgs e) //Create
        {
            
        }

        private void readToolStripMenuItem_Click(object sender, EventArgs e) //Read
        {
            
        }
        private void updateToolStripMenuItem_Click(object sender, EventArgs e) //Update
        {

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e) //Delete
        {

        }
        #endregion
        #region Køberknapper
        private void createToolStripMenuItem_Click(object sender, EventArgs e) //Create
        {
            MenuBarKnapper.KøberCreate();
        }

        private void readToolStripMenuItem1_Click(object sender, EventArgs e) //Read
        {
            MenuBarKnapper.KøberRead();
        }

        private void updateToolStripMenuItem1_Click(object sender, EventArgs e) //Update
        {

        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e) //Delete
        {

        }
        #endregion
        #region Sælgerknapper
        private void createToolStripMenuItem1_Click(object sender, EventArgs e) //Create
        {

        }

        private void readToolStripMenuItem2_Click(object sender, EventArgs e) //Read
        {

        }

        private void updateToolStripMenuItem2_Click(object sender, EventArgs e) //Update
        {

        }

        private void deleteToolStripMenuItem2_Click(object sender, EventArgs e) //Delete
        {

        }
        #endregion
        #region Boligknapper
        private void createToolStripMenuItem2_Click(object sender, EventArgs e) //Create
        {

        }

        private void readToolStripMenuItem3_Click(object sender, EventArgs e) //Read
        {

        }

        private void updateToolStripMenuItem3_Click(object sender, EventArgs e) //Update
        {

        }

        private void deleteToolStripMenuItem3_Click(object sender, EventArgs e) //Delete
        {

        }
        #endregion

        private void KøberID_txt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
