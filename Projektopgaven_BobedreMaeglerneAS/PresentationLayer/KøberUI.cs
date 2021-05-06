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

        private void OpretKøber_knap_Click(object sender, EventArgs e)
        {
            try
            {
                //Conn.open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void FindKøber_knap_Click(object sender, EventArgs e)
        {

        }

        private void OpdaterKøber_knap_Click(object sender, EventArgs e)
        {

        }

        private void SletKøber_knap_Click(object sender, EventArgs e)
        {

        }

        #region Ejendomsmæglerknapper
        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void readToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Sælgerknapper
        private void createToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void readToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void updateToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Køberknapper
        private void createToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void readToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void updateToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void deleteToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Boligknapper
        private void createToolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void readToolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void updateToolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void deleteToolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void KøberUI_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'køber_bobedredbDataSet.Køber' table. You can move, or remove it, as needed.
            this.køberTableAdapter.Fill(this.køber_bobedredbDataSet.Køber);

        }
    }
}
