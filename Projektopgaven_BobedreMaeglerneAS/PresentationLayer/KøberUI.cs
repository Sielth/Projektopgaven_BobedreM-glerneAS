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
            if (CPRvalidering() && FornavnValidering() && EfternavnValidering() && EmailValidering() && TelefonValidering() && VejValidering() && PostnummerValidering())
            {
                try
                {
                    if (!KøberBLL.KøberCPRExists(KøberCPR()))
                    {
                        køber.OpretKøber(køber);
                    }
                    else
                    {
                        MessageBox.Show("Person findes allerede i databasen");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            KøberUI_Load(sender, e);
        }

        private void FindKøber_knap_Click(object sender, EventArgs e)
        {
            køber = new KøberBLL(KøberID());
            if (IDvalidering())
            {
                try
                {
                    if (KøberBLL.KøberExists(KøberID()))
                    {
                        KøberBLL matchingkøber = KøberBLL.FindKøber(køber);

                        KøberVej_txt.Text = matchingkøber.Vej;
                        KøberVej_txt.Enabled = false;
                        KøberPostnummer_txt.Text = matchingkøber.Postnummer.ToString();
                        KøberPostnummer_txt.Enabled = false;
                        KøberCPR_txt.Text = matchingkøber.CPR.ToString();
                        KøberCPR_txt.Enabled = false;
                        KøberFornavn_txt.Text = matchingkøber.Fnavn;
                        KøberFornavn_txt.Enabled = false;
                        KøberEfternavn_txt.Text = matchingkøber.Enavn;
                        KøberEfternavn_txt.Enabled = false;
                        KøberEmail_txt.Text = matchingkøber.Email;
                        KøberEmail_txt.Enabled = false;
                        KøberTelefon_txt.Text = matchingkøber.Telefon.ToString();
                        KøberTelefon_txt.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Køber findes ikke");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            KøberUI_Load(sender, e);
        }

        private void OpdaterKøber_knap_Click(object sender, EventArgs e)
        {
            køber = new KøberBLL(KøberID(), KøberVej(), KøberPostnummer(), KøberCPR(), KøberFornavn(), KøberEfternavn(), KøberEmail(), KøberTelefon());
            if (CPRvalidering() && FornavnValidering() && EfternavnValidering() && EmailValidering() && TelefonValidering() && VejValidering() && PostnummerValidering())
            {
                try
                {
                    if (KøberBLL.KøberExists(KøberID()) && KøberBLL.KøberCPRExists(KøberCPR()))
                    {
                        køber.OpdaterKøber(køber);
                    }
                    else
                    {
                        MessageBox.Show("Køber findes ikke");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Der opstod fejl i databasen med følgende log: " + ex.Message);
                }
            }
            KøberUI_Load(sender, e);
        }

        private void SletKøber_knap_Click(object sender, EventArgs e)
        {
            køber = new KøberBLL(KøberID());

            try
            {
                if (KøberBLL.KøberExists(KøberID()))
                {
                    køber.SletKøber(køber);
                }
                else
                {
                    MessageBox.Show("Køber findes ikke");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            KøberUI_Load(sender, e);
        }
        private void TilladRedigering_knap_Click(object sender, EventArgs e)
        {
            KøberID_txt.Enabled = false;
            KøberVej_txt.Enabled = true;
            KøberPostnummer_txt.Enabled = true;
            KøberCPR_txt.Enabled = true;
            KøberFornavn_txt.Enabled = true;
            KøberEfternavn_txt.Enabled = true;
            KøberEmail_txt.Enabled = true;
            KøberTelefon_txt.Enabled = true;
        }
        private void Clear_knap_Click(object sender, EventArgs e)
        {
            KøberID_txt.Enabled = true;
            KøberID_txt.Clear();
            KøberVej_txt.Enabled = false;
            KøberVej_txt.Clear();
            KøberPostnummer_txt.Enabled = false;
            KøberPostnummer_txt.Clear();
            KøberCPR_txt.Enabled = false;
            KøberCPR_txt.Clear();
            KøberFornavn_txt.Enabled = false;
            KøberFornavn_txt.Clear();
            KøberEfternavn_txt.Enabled = false;
            KøberEfternavn_txt.Clear();
            KøberEmail_txt.Enabled = false;
            KøberEmail_txt.Clear();
            KøberTelefon_txt.Enabled = false;
            KøberTelefon_txt.Clear();
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
            MenuBarKnapper.SælgerHentOpdater();
        }

        //private void updateToolStripMenuItem1_Click(object sender, EventArgs e) //Opdater sælger
        //{
        //    MenuBarKnapper.SælgerOpdater();
        //}

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

        //private void updateToolStripMenuItem2_Click(object sender, EventArgs e) //Opdater køber
        //{
        //    MenuBarKnapper.KøberUpdate();
        //}

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

        //private void updateToolStripMenuItem5_Click(object sender, EventArgs e) //Opdater handel
        //{
        //    MenuBarKnapper.HandelOpdater();
        //}

        private void deleteToolStripMenuItem5_Click(object sender, EventArgs e) //Slet handel
        {
            MenuBarKnapper.HandelSlet();
        }

        private void udtrækStatistikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuBarKnapper.HandelStatistik();
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

        public long KøberCPR()
        {
            Int64.TryParse(KøberCPR_txt.Text, out long køberCPR);
            return køberCPR;
        }

        public string KøberEmail()
        {
            return KøberEmail_txt.Text;
        }
        #endregion

        private void KøberUI_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'køberDataSet.Køber' table. You can move, or remove it, as needed.
            this.køberTableAdapter.Fill(this.køberDataSet.Køber);
            // TODO: This line of code loads data into the 'køber_bobedredbDataSet.Køber' table. You can move, or remove it, as needed.
            //this.køberTableAdapter.Fill(this.køber_bobedredbDataSet.Køber);

        }
        #region inputvalidering
        private bool IsLetters(string text)
        {
            foreach (char c in text)
            {
                if (!Char.IsLetter(c) && c != ' ')
                {
                    return false;
                }
            }
            return true;
        }
        private bool IsDigits(string tal)
        {
            foreach (char c in tal)
            {
                if (!Char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }
        private bool IsLettersOrDigits(string text)
        {
            foreach (char c in text)
            {
                if (!Char.IsLetterOrDigit(c) && c != ' ')
                {
                    return false;
                }
            }
            return true;
        }
        private bool IDvalidering()
        {
            if (!IsDigits(KøberID_txt.Text))
            {
                MessageBox.Show("ID må kun indeholde tal");
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool CPRvalidering()
        {
            if (!IsDigits(KøberCPR_txt.Text) || KøberCPR_txt.Text.Length != 10)
            {
                MessageBox.Show("CPR skal være ti (10) tal langt");
                return false;
            }
            else if (KøberCPR_txt.Text.Length == 0)
            {
                return true;
            }
            else
            {
                return true;
            }
        }
        private bool FornavnValidering()
        {
            if (!IsLetters(KøberFornavn_txt.Text))
            {
                MessageBox.Show("Fornavn må kun indeholde bogstaver");
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool EfternavnValidering()
        {
            if (!IsLetters(KøberEfternavn_txt.Text))
            {
                MessageBox.Show("Efternavn må kun indeholde bogstaver");
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool EmailValidering()
        {
            foreach (char c in KøberEmail_txt.Text)
            {
                if (!Char.IsLetterOrDigit(c) && c != '@' && c != '.' && c != '-' && c != '_')
                {
                    return false;
                }
            }
            return true;
        }
        private bool TelefonValidering()
        {
            if (!IsDigits(KøberTelefon_txt.Text) || KøberTelefon_txt.Text.Length != 8)
            {
                MessageBox.Show("Telefon skal være otte (8) tal langt");
                return false;
            }
            else if (KøberTelefon_txt.Text.Length == 0)
            {
                return true;
            }
            else
            {
                return true;
            }
        }
        private bool VejValidering()
        {
            if (!IsLettersOrDigits(KøberVej_txt.Text))
            {
                MessageBox.Show("Vej må kun indeholde bogstaver og tal");
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool PostnummerValidering()
        {
            if (!IsDigits(KøberPostnummer_txt.Text) || KøberPostnummer_txt.Text.Length != 4)
            {
                MessageBox.Show("Postnummer må kun indeholde tal som er fire (4) cifre langt");
                return false;
            }
            else if (KøberPostnummer_txt.Text.Length == 0)
            {
                return true;
            }
            else
            {
                return true;
            }
        }
        #endregion

        private void KøberPostnummer_txt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
