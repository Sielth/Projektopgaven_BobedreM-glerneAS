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
        KøberBLL køber;

        public KøberUI()
        {
            InitializeComponent();
        }

        private void OpretKøber_knap_Click(object sender, EventArgs e)
        {
            køber = new KøberBLL(KøberID(), KøberVej(), KøberPostnummer(), KøberCPR(), KøberFornavn(), KøberEfternavn(), KøberEmail(), KøberTelefon());

            try
            {
                køber.OpdaterKøber(køber);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            KøberUI_Load(sender, e);
        }

        private void FindKøber_knap_Click(object sender, EventArgs e)
        {
            køber = new KøberBLL(KøberID());

            try
            {
                KøberBLL matchingkøber = KøberBLL.FindKøber(køber);

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
                MessageBox.Show(ex.Message);
            }

            KøberUI_Load(sender, e);
        }

        private void OpdaterKøber_knap_Click(object sender, EventArgs e)
        {
            KøberBLL køberBLL = new KøberBLL(KøberID(), KøberVej(), KøberPostnummer(), KøberCPR(), KøberFornavn(), KøberEfternavn(), KøberEmail(), KøberTelefon());

            try
            {
                køber.OpdaterKøber(køber);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            KøberUI_Load(sender, e);
        }

        private void SletKøber_knap_Click(object sender, EventArgs e)
        {
            køber = new KøberBLL(KøberID());

            try
            {
                køber.SletKøber(køber);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            KøberUI_Load(sender, e);
        }


        #region MENUBAREN
        //MENUBAREN
        //EJENDOMSMÆGLER MENUBARKNAPPER - I KØBER MENU
        private void createToolStripMenuItem_Click(object sender, EventArgs e) //Opret ejendomsmægler
        {
            MenuBarKnapper.EjendomsmælgerOpret();
        }

        private void readToolStripMenuItem_Click(object sender, EventArgs e) //Hent ejendomsmægler
        {
            MenuBarKnapper.EjendomsmæglerHentOpdater();
        }

        //private void updateToolStripMenuItem_Click(object sender, EventArgs e) //Opdater ejendomsmælger
        //{
        //    MenuBarKnapper.EjendomsmæglerOpdater();
        //}

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e) //Slet ejendomsmægler
        {
            MenuBarKnapper.EjendomsmæglerSlet();
        }
        
        //SÆLGER MENUBARKNAPPER - I KØBER MENU
        private void createToolStripMenuItem1_Click(object sender, EventArgs e) //Opret sælger
        {
            MenuBarKnapper.SælgerOpret();
        }

        private void readToolStripMenuItem1_Click(object sender, EventArgs e) //Hent sælger
        {
            MenuBarKnapper.SælgerHent();
        }

        private void updateToolStripMenuItem1_Click(object sender, EventArgs e) //Opdater sælger
        {
            MenuBarKnapper.SælgerOpdater();
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e) //Slet sælger
        {
            MenuBarKnapper.SælgerSlet();
        }
        

        //KØBER MENUBARKNAPPER - I KØBER MENU
        private void createToolStripMenuItem2_Click(object sender, EventArgs e) //Opret køber
        {
            MenuBarKnapper.KøberCreate();
        }

        private void readToolStripMenuItem2_Click(object sender, EventArgs e) //Hent køber
        {
            MenuBarKnapper.KøberRead();
        }

        private void updateToolStripMenuItem2_Click(object sender, EventArgs e) //Opdater køber
        {
            MenuBarKnapper.KøberUpdate();
        }

        private void deleteToolStripMenuItem2_Click(object sender, EventArgs e) //Slet køber
        {
            MenuBarKnapper.KøberDelete();
        }


        //BOLIG MENUKNAPPER - I KØBER MENU
        private void createToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            MenuBarKnapper.OpretBolig();
        }

        private void readToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            MenuBarKnapper.HentOpdaterBolig();
        }

        private void deleteToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            MenuBarKnapper.SletBolig();
        }

        //SAG MENUBARKNAPPER - I KØBER MENU
        private void createToolStripMenuItem4_Click(object sender, EventArgs e) //Opret sag
        {
            MenuBarKnapper.SagOpret();
        }

        private void readToolStripMenuItem4_Click(object sender, EventArgs e) //Hent sag
        {
            MenuBarKnapper.SagHent();
        }

        private void updateToolStripMenuItem4_Click(object sender, EventArgs e) //Opdater sag
        {
            MenuBarKnapper.SagOpdater();
        }

        private void deleteToolStripMenuItem4_Click(object sender, EventArgs e) //Slet sag
        {
            MenuBarKnapper.SagSlet();
        }

        //HANDEL MENUKNAPPER - I KØBER MENU
        private void createToolStripMenuItem5_Click(object sender, EventArgs e) //Opret handel
        {
            MenuBarKnapper.HandelOpret();
        }

        private void readToolStripMenuItem5_Click(object sender, EventArgs e) //Hent handel
        {
            MenuBarKnapper.HandelHent();
        }

        private void updateToolStripMenuItem5_Click(object sender, EventArgs e) //Opdater handel
        {
            MenuBarKnapper.HandelOpdater();
        }

        private void deleteToolStripMenuItem5_Click(object sender, EventArgs e) //Slet handel
        {
            MenuBarKnapper.HandelSlet();
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
