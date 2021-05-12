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

namespace Projektopgaven_BobedreMaeglerneAS.PresentationLayer
{
    public partial class SagUI : Form
    {
        public SagUI()
        {
            InitializeComponent();
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
    }
}
