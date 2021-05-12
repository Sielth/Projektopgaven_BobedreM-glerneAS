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

namespace Projektopgaven_BobedreMaeglerneAS.PresentationLayer
{
    public partial class SagUI : Form
    {
        BoligDAL bolig = new BoligDAL(new BoligBLL());
        SælgerDAL sælger = new SælgerDAL(new SælgerBLL());

        public SagUI()
        {
            InitializeComponent();

            foreach (BoligBLL bolig in bolig.HentBoligID_cbox())
                sag_boligID_cbox.Items.Add(bolig);

            foreach (SælgerBLL sælger in sælger.HentSælgerID_cbox()) 
                sag_sælgerID_cbox.Items.Add(sælger);
        }

        private void btn_OpretSag_Click(object sender, EventArgs e)
        {
            SagBLL sagBLL = new SagBLL(SagsID(), SagsStatus(), SagsBoligID(), SagsSælgerID(), SagsMæglerID());
            SagDAL sagDAL = new SagDAL(sagBLL);

            //Kalder metoden: OpretSag
            sagDAL.OpretSag(sagBLL);

            //Loader data fra databasen ind i datagridview
            //SagsUI_Load(sender, e);

        }

        private void btn_HentSag_Click(object sender, EventArgs e)
        {

        }

        private void btn_OpdaterSag_Click(object sender, EventArgs e)
        {

        }

        private void btn_SletSag_Click(object sender, EventArgs e)
        {

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
            int.TryParse(sag_boligID_cbox.Text, out int sagsboligid);
            return sagsboligid;
        }

        public int SagsSælgerID()
        {
            int.TryParse(sag_sælgerID_cbox.Text, out int sagssælgerid);
            return sagssælgerid;
        }

        public int SagsMæglerID()
        {
            int.TryParse(sag_ejendomsmæglerID_cbox.Text, out int sagsmæglerid);
            return sagsmæglerid;
        }
        #endregion

        private void SagUI_Load(object sender, EventArgs e)
        {

        }
    }
}
