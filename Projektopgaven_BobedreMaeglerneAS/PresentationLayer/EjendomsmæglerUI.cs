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
using System.Data.SqlClient;

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
            //Connection string - 
            string strconn = "Server=den1.mssql7.gear.host; Database=bobedredb; User ID=bobedredb; Password=Xw8gM?O3doQ_";
            SqlConnection conn = new SqlConnection(strconn);

            EjendomsmæglerBLL ejendomsmæglerBLL = new EjendomsmæglerBLL(MælgerID(), MæglerCPR(), MæglerTelefon(), MæglerEmail(), MæglerFnavn(), MæglerEnavn(), MæglerVej(), MæglerPostnummer());
            EjendomsmæglerDAL ejendomsmæglerDAL = new EjendomsmæglerDAL(ejendomsmæglerBLL);

            //Kalder metoden: OpretEjendomsmægler
            ejendomsmæglerDAL.OpretEjendomsmægler(ejendomsmæglerBLL);

            //Loader data fra databasen ind i datagridview -
            EjendomsmæglerUI_Load(sender, e);
        }


        //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        private void btn_HentEjendomsmægler_Click(object sender, EventArgs e) //NOT WORKING YET
        {
            //Connection string - 
            string strconn = "Server=den1.mssql7.gear.host; Database=bobedredb; User ID=bobedredb; Password=Xw8gM?O3doQ_";
            SqlConnection conn = new SqlConnection(strconn);

            EjendomsmæglerBLL ejendomsmæglerBLL = new EjendomsmæglerBLL(MælgerID(), MæglerCPR(), MæglerTelefon(), MæglerEmail(), MæglerFnavn(), MæglerEnavn(), MæglerVej(), MæglerPostnummer());
            EjendomsmæglerDAL ejendomsmæglerDAL = new EjendomsmæglerDAL(ejendomsmæglerBLL);

            try
            {
                EjendomsmæglerBLL matchingejendomsmægler = ejendomsmæglerDAL.FindEjendomsmægler(ejendomsmæglerBLL);
                CPR_txt.Text = matchingejendomsmægler.CPR.ToString();
                Telefon_txt.Text = matchingejendomsmægler.Telefon.ToString();
                Email_txt.Text = matchingejendomsmægler.Email.ToString();
                Fornavn_txt.Text = matchingejendomsmægler.Fnavn.ToString();
                Efternavn_txt.Text = matchingejendomsmægler.Enavn.ToString();
                Vej_txt.Text = matchingejendomsmægler.Vej.ToString();
                Postnummer_txt.Text = matchingejendomsmægler.Postnummer.ToString();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //Kalder metoden: FindEjendomsmægler
            //ejendomsmæglerDAL.FindEjendomsmægler(ejendomsmæglerBLL);

            //Loader data fra databasen ind i datagridview
            EjendomsmæglerUI_Load(sender, e);
        }

        
        private void btn_OpdaterEjendomsmægler_Click(object sender, EventArgs e) 
        {
            //Connection string - 
            string strconn = "Server=den1.mssql7.gear.host; Database=bobedredb; User ID=bobedredb; Password=Xw8gM?O3doQ_";
            SqlConnection conn = new SqlConnection(strconn);

            EjendomsmæglerBLL ejendomsmæglerBLL = new EjendomsmæglerBLL(MælgerID(), MæglerCPR(), MæglerTelefon(), MæglerEmail(), MæglerFnavn(), MæglerEnavn(), MæglerVej(), MæglerPostnummer());
            EjendomsmæglerDAL ejendomsmæglerDAL = new EjendomsmæglerDAL(ejendomsmæglerBLL);

            //Kalder metoden: OpdaterEjendomsmægler
            ejendomsmæglerDAL.OpdaterEjendomsmægler(ejendomsmæglerBLL);

            //Loader data fra databasen ind i datagridview
            EjendomsmæglerUI_Load(sender, e);
        }


        private void btn_SletEjendomsmægler_Click(object sender, EventArgs e)
        {
            //Connection string - 
            string strconn = "Server=den1.mssql7.gear.host; Database=bobedredb; User ID=bobedredb; Password=Xw8gM?O3doQ_";
            SqlConnection conn = new SqlConnection(strconn);

            EjendomsmæglerBLL ejendomsmæglerBLL = new EjendomsmæglerBLL(MælgerID(), MæglerCPR(), MæglerTelefon(), MæglerEmail(), MæglerFnavn(), MæglerEnavn(), MæglerVej(), MæglerPostnummer());
            EjendomsmæglerDAL ejendomsmæglerDAL = new EjendomsmæglerDAL(ejendomsmæglerBLL);

            //Kalder metoden: SletEjendomsmægler
            ejendomsmæglerDAL.SletEjendomsmægler(ejendomsmæglerBLL);

            //Loader data fra databasen ind i datagridview
            EjendomsmæglerUI_Load(sender, e);
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

        private void EjendomsmæglerUI_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bobedredbDataSet.Ejendomsmægler' table. You can move, or remove it, as needed.
            //this.ejendomsmæglerTableAdapter.Fill(this.bobedredbDataSet.Ejendomsmægler);

        }
    }
}
