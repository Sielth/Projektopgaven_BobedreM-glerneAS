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

            //Kalder metoden: OpretSælger
            sælgerDAL.OpretSælger(sælgerBLL);

            //Loader data fra databasen ind i datagridview
            //SælgerUI_Load(sender, e);
        }

        private void btn_HentSælger_Click(object sender, EventArgs e) //MIGHT WORK?
        {
            SælgerBLL sælgerBLL = new SælgerBLL(SælgerID(), SælgerCPR(), SælgerTelefon(), SælgerEmail(), SælgerFornavn(), SælgerEfternavn(), SælgerVej(), SælgerPostnummer());
            SælgerDAL sælgerDAL = new SælgerDAL(sælgerBLL);

            try
            {
                SælgerBLL matchingeSælger = sælgerDAL.HentSælger(sælgerBLL);
                sælgerCPR_txt.Text = matchingeSælger.CPR.ToString();
                sælgerTelefon_txt.Text = matchingeSælger.Telefon.ToString();
                sælgerEmail_txt.Text = matchingeSælger.Email.ToString();
                sælgerFornavn_txt.Text = matchingeSælger.Fnavn.ToString();
                sælgerEfternavn_txt.Text = matchingeSælger.Enavn.ToString();
                sælgerVej_txt.Text = matchingeSælger.Vej.ToString();
                sælgerPostnummer_txt.Text = matchingeSælger.Postnummer.ToString();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //Kalder metoden: HentSælger
            sælgerDAL.HentSælger(sælgerBLL);
        }

        private void btn_OpdaterSælger_Click(object sender, EventArgs e) //NOT WORKING YET
        {
            SælgerBLL sælgerBLL = new SælgerBLL(SælgerID(), SælgerCPR(), SælgerTelefon(), SælgerEmail(), SælgerFornavn(), SælgerEfternavn(), SælgerVej(), SælgerPostnummer());
            SælgerDAL sælgerDAL = new SælgerDAL(sælgerBLL);

            //Kalder metoden: OpdaterSælger
            sælgerDAL.OpdaterSælger(sælgerBLL);
        }

        private void btn_SletSælger_Click(object sender, EventArgs e)
        {
            SælgerBLL sælgerBLL = new SælgerBLL(SælgerID(), SælgerCPR(), SælgerTelefon(), SælgerEmail(), SælgerFornavn(), SælgerEfternavn(), SælgerVej(), SælgerPostnummer());
            SælgerDAL sælgerDAL = new SælgerDAL(sælgerBLL);

            //Kalder metoden: SletSælger
            sælgerDAL.SletSælger(sælgerBLL);
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
