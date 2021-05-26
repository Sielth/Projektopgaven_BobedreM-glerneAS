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
using Projektopgaven_BobedreMaeglerneAS.DataAccessLayer;
using System.Threading;
using Projektopgaven_BobedreMaeglerneAS.BusinessLogicLayer;

namespace Projektopgaven_BobedreMaeglerneAS.PresentationLayer
{
    public partial class BeregnSalærForm : Form
    {
        SagDAL sag;

        WorksOnBLL worksOn;
        EjendomsmæglerBLL ejendomsmægler;

        public BeregnSalærForm()
        {
            InitializeComponent();;

            sag = new SagDAL(beregn_sagsID_cbox);
            Thread t2 = new Thread(new ThreadStart(sag.GenerateSag));
            t2.IsBackground = true;
            t2.Start();
        }

        private void btn_indsæt_Click(object sender, EventArgs e)
        {
            worksOn = new WorksOnBLL(SagsID(), TotHours());

            try
            {
                worksOn.IndsætTimer(worksOn);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (worksOn.HandelExists(SagsID()))
                result_txt.Text = worksOn.BeregnSalær(WorksOnBLL.HentSalgspris(SagsID().ToString()), TotHours());
            else
                result_txt.Text = worksOn.BeregnSalær(0, TotHours());
        }

        private void beregn_hentData_btn_Click(object sender, EventArgs e)
        {
            try
            {
                ejendomsmægler = WorksOnDAL.HentMægler(SagsID());

                beregn_mæglerID_txt.Text = ejendomsmægler.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #region Convert TextBoxes
        private int SagsID()
        {
            string[] sagsID_txt = beregn_sagsID_cbox.Text.ToString().Split(' ');
            int.TryParse(sagsID_txt[0], out int sagsID);
            return sagsID;
        }

        private int TotHours()
        {
            int.TryParse(antalTimer_txt.Text, out int totHours);
            return totHours;
        }
        #endregion
    }
}
