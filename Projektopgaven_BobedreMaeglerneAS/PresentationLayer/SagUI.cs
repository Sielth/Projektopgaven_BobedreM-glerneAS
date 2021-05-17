using Projektopgaven_BobedreMaeglerneAS.BusinessLogicLayer;
using Projektopgaven_BobedreMaeglerneAS.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projektopgaven_BobedreMæglerneAS;
using System.Threading;

namespace Projektopgaven_BobedreMaeglerneAS.PresentationLayer
{
    public partial class SagUI : Form
    {
        BoligDAL bolig = new BoligDAL(new BoligBLL());
        SælgerDAL sælger = new SælgerDAL(new SælgerBLL());
        EjendomsmæglerDAL ejendomsmægler = new EjendomsmæglerDAL(new EjendomsmæglerBLL());

        public SagUI()
        {
            InitializeComponent();

            //series of loop that add elements in combobox from methods that return lists of elements

            foreach (BoligBLL bolig in bolig.FetchBolig())
                sag_boligID_cbox.Items.Add(bolig);

            foreach (SælgerBLL sælger in sælger.HentSælgerID_cbox()) 
                sag_sælgerID_cbox.Items.Add(sælger);

            foreach (EjendomsmæglerBLL ejendomsmægler in ejendomsmægler.HentEjendomsmæglerID_cbox())
                sag_ejendomsmæglerID_cbox.Items.Add(ejendomsmægler);
        }

        private void btn_OpretSag_Click(object sender, EventArgs e)
        {
            SagBLL sagBLL = new SagBLL(SagsStatus(), SagsBoligID(), SagsSælgerID(), SagsMæglerID());
            SagDAL sagDAL = new SagDAL(sagBLL);

            //Kalder metoden: OpretSag
            sagDAL.OpretSag(sagBLL);

            //Loader data fra databasen ind i datagridview
            //SagsUI_Load(sender, e);

        }

        private void btn_HentSag_Click(object sender, EventArgs e)
        {
            SagBLL sagBLL = new SagBLL(SagsID(), SagsStatus(), SagsBoligID(), SagsSælgerID(), SagsMæglerID());
            SagDAL sagDAL = new SagDAL(sagBLL);

            try
            {
                SagBLL matchingesag = sagDAL.FindSag(sagBLL);
                sagStatus_cbox.Text = matchingesag.Status.ToString();
                sag_boligID_cbox.Text = matchingesag.BoligID.ToString();
                sag_sælgerID_cbox.Text = matchingesag.SælgerID.ToString();
                sag_ejendomsmæglerID_cbox.Text = matchingesag.MæglerID.ToString();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //Kalder metoden: OpretSag
            sagDAL.OpretSag(sagBLL);

            //Loader data fra databasen ind i datagridview
            //SagsUI_Load(sender, e);
        }

        private void btn_OpdaterSag_Click(object sender, EventArgs e)
        {
            SagBLL sagBLL = new SagBLL(SagsID(), SagsStatus(), SagsBoligID(), SagsSælgerID(), SagsMæglerID());
            SagDAL sagDAL = new SagDAL(sagBLL);

            //Kalder metoden: OpretSag
            sagDAL.OpdaterSag(sagBLL);

            //Loader data fra databasen ind i datagridview
            //SagsUI_Load(sender, e);
        }

        private void btn_SletSag_Click(object sender, EventArgs e)
        {
            SagBLL sagBLL = new SagBLL(SagsID(), SagsStatus(), SagsBoligID(), SagsSælgerID(), SagsMæglerID());
            SagDAL sagDAL = new SagDAL(sagBLL);

            //Kalder metoden: OpretSag
            sagDAL.SletSag(sagBLL);

            //Loader data fra databasen ind i datagridview
            //SagsUI_Load(sender, e);
        }


        #region Konveter Tekstbokse
        public int SagsID()
        {
            int.TryParse(sagID_txt.Text, out int sagsid);
            return sagsid;
        }

        public string SagsStatus()
        {
            return sagStatus_cbox.Text;
        }

        public int SagsBoligID()
        {
            string[] id = sag_boligID_cbox.Text.Split(' ');
            int.TryParse(id[0], out int sagsboligid);
            return sagsboligid;
        }

        public int SagsSælgerID()
        {
            string[] id = sag_sælgerID_cbox.Text.Split(' ');
            int.TryParse(id[0], out int sagssælgerid);

            return sagssælgerid;
        }

        public int SagsMæglerID()
        {
            string[] id = sag_ejendomsmæglerID_cbox.Text.Split(' ');
            int.TryParse(id[0], out int sagsmæglerid);
            return sagsmæglerid;
        }
        #endregion

        private void SagUI_Load(object sender, EventArgs e)
        {

        }
    }
}
