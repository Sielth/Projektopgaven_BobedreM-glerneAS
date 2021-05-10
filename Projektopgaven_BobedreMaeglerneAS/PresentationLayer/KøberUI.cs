using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projektopgaven_BobedreMaeglerneAS.DataAccessLayer;
using Projektopgaven_BobedreMaeglerneAS.BusinessLogicLayer;

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
            KøberBLL køberBLL = new KøberBLL(KøberID(), KøberVej(), KøberPostnummer(), KøberCPR(), KøberFornavn(), KøberEfternavn(), KøberEmail(), KøberTelefon());
            KøberDAL køberDAL = new KøberDAL(køberBLL);

            køberDAL.OpretKøber(køberBLL);
        }

        private void FindKøber_knap_Click(object sender, EventArgs e)
        {
            KøberBLL køberBLL = new KøberBLL(KøberID());
            KøberDAL køberDAL = new KøberDAL(køberBLL);
            try
            {
                KøberBLL matchingkøber = køberDAL.FindKøber(køberBLL);
                KøberVej_txt.Text = matchingkøber.Vej;
                KøberPostnummer_txt.Text = matchingkøber.Postnummer.ToString();
                KøberCPR_txt.Text = matchingkøber.CPR.ToString();
                KøberFornavn_txt.Text = matchingkøber.Fnavn;
                KøberEfternavn_txt.Text = matchingkøber.Enavn;
                KøberEmail_txt.Text = matchingkøber.Email;
                KøberTelefon_txt.Text = matchingkøber.Telefon.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void OpdaterKøber_knap_Click(object sender, EventArgs e)
        {
            KøberBLL køberBLL = new KøberBLL(KøberID(), KøberVej(), KøberPostnummer(), KøberCPR(), KøberFornavn(), KøberEfternavn(), KøberEmail(), KøberTelefon());
            KøberDAL køberDAL = new KøberDAL(køberBLL);
            køberDAL.OpdaterKøber(køberBLL);
        }

        private void SletKøber_knap_Click(object sender, EventArgs e)
        {
            KøberBLL køberBLL = new KøberBLL(KøberID(), KøberVej(), KøberPostnummer(), KøberCPR(), KøberFornavn(), KøberEfternavn(), KøberEmail(), KøberTelefon());
            KøberDAL køberDAL = new KøberDAL(køberBLL);
            køberDAL.SletKøber(køberBLL);
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

        #region Convert Textboxes
        public int KøberID()
        {
            int.TryParse(KøberID_txt.Text, out int køberid);
            return køberid;
        }

        public string KøberVej()
        {
            return KøberVej_txt.Text;
        }

        public int KøberPostnummer()
        {
            int.TryParse(KøberPostnummer_txt.Text, out int køberpostnummer);
            return køberpostnummer;
        }

        public string KøberFornavn()
        {
            return KøberFornavn_txt.Text;
        }

        public string KøberEfternavn()
        {
            return KøberEfternavn_txt.Text;
        }

        public int KøberTelefon()
        {
            int.TryParse(KøberTelefon_txt.Text, out int købertelefon);
            return købertelefon;
        }

        public int KøberCPR()
        {
            int.TryParse(KøberCPR_txt.Text, out int køberCPR);
            return køberCPR;
        }

        public string KøberEmail()
        {
            return KøberEmail_txt.Text;
        }
        #endregion

        private void KøberUI_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'køber_bobedredbDataSet.Køber' table. You can move, or remove it, as needed.
            this.køberTableAdapter.Fill(this.køber_bobedredbDataSet.Køber);

        }
    }
}
