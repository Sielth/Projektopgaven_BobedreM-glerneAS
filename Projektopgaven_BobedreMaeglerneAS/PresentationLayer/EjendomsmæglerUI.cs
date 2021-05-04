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
using Projektopgaven_BobedreMæglerneAS;

namespace Projektopgaven_BobedreMaeglerneAS.PresentationLayer
{
    public partial class EjendomsmæglerUI : Form
    {
        public EjendomsmæglerUI()
        {
            InitializeComponent();
        }

        private void btn_OpretEjendomsmægler_Click(object sender, EventArgs e)
        {
            //EjendomsmæglerBLL ejendomsmæglerBLL = new EjendomsmæglerBLL(MælgerID(), Ejendomsmælgercpr(), telefon(), email(), fnavn(), enavn(), vej(), postnummer());
            //EjendomsmæglerDAL ejendomsmæglerDAL = new EjendomsmæglerDAL(ejendomsmæglerBLL);
        }


        #region Konveter Tekstbokse
        public int MælgerID()
        {
            int.TryParse(MæglerID_txt.Text, out int mæglerid);
            return mæglerid;
        }

        public int MæglerCPR()
        {
            int.TryParse(CPR_txt.Text, out int mæglercpr);
            return mæglercpr;
        }

        public int MæglerTelefon()
        {
            int.TryParse(Telefon_txt.Text, out int mæglertelefon);
            return mæglertelefon;
        }

        public string MæglerEmail()
        {
            return Email_txt.Text;
        }

        public string MæglerFnavn()
        {
            return Fornavn_txt.Text;
        }

        public string MæglerEnavn()
        {
            return Efternavn_txt.Text;
        }

        public string MæglerVej()
        {
            return Vej_txt.Text;
        }

        public int MæglerPostnummer()
        {
            int.TryParse(Postnummer_txt.Text, out int mæglerpostnummer);
            return mæglerpostnummer;
        }

        #endregion


    }
}
