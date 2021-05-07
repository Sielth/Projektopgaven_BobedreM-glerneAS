using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projektopgaven_BobedreMaeglerneAS.BusinessLogicLayer;
using Projektopgaven_BobedreMaeglerneAS.DataAccessLayer;

namespace Projektopgaven_BobedreMaeglerneAS.PresentationLayer
{
    public partial class SælgerUI : Form
    {
        public SælgerUI()
        {
            InitializeComponent();
        }

        private void btn_OpretSælger_Click(object sender, EventArgs e)
        {
            SælgerBLL sælgerBLL = new SælgerBLL(SælgerID(), SælgerCPR(), SælgerTelefon(), SælgerEmail(), SælgerFornavn(), SælgerEfternavn(), SælgerVej(), SælgerPostnummer());
            SælgerDAL sælgerDAL = new SælgerDAL(sælgerBLL);
        }

        private void btn_HentSælger_Click(object sender, EventArgs e)
        {

        }

        private void btn_OpdaterSælger_Click(object sender, EventArgs e)
        {

        }

        private void btn_SletSælger_Click(object sender, EventArgs e)
        {

        }

        #region Convert Textboxes
        private int SælgerID()
        {
            int.TryParse(sælgerID_txt.Text, out int sælgerid);
            return sælgerid;
        }

        private int SælgerCPR()
        {
            int.TryParse(sælgerCPR_txt.Text, out int sælgercpr);
            return sælgercpr;
        }

        private string SælgerFornavn()
        {
            return sælgerFornavn_txt.Text;
        }

        private string SælgerEfternavn()
        {
            return sælgerEfternavn_txt.Text;
        }

        private int SælgerTelefon()
        {
            int.TryParse(sælgerTelefon_txt.Text, out int sælgertelefon);
            return sælgertelefon;
        }

        private string SælgerEmail()
        {
            return sælgerEmail_txt.Text;
        }

        private string SælgerVej()
        {
            return sælgerVej_txt.Text;
        }

        private int SælgerPostnummer()
        {
            int.TryParse(sælgerPostnummer_txt.Text, out int sælgerpostnummer);
            return sælgerpostnummer;
        }
        #endregion
    }
}
