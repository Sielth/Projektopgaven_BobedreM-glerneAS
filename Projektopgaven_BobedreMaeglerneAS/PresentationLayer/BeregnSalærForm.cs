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
        EjendomsmæglerDAL ejendomsmægler;
        SagDAL sag;

        public BeregnSalærForm()
        {
            InitializeComponent();

            ejendomsmægler = new EjendomsmæglerDAL(beregn_mæglerID_cbox);
            Thread t1 = new Thread(new ThreadStart(ejendomsmægler.GenerateEjendomsmægler));
            t1.IsBackground = true;
            t1.Start();

            sag = new SagDAL(beregn_sagsID_cbox);
            Thread t2 = new Thread(new ThreadStart(sag.GenerateSag));
            t2.IsBackground = true;
            t2.Start();
        }

        private void btn_indsæt_Click(object sender, EventArgs e)
        {
            WorksOnBLL worksOnBLL = new WorksOnBLL(HandelID(), TotHours());
            WorksOnDAL worksOnDAL = new WorksOnDAL(worksOnBLL);

            try
            {
                worksOnDAL.IndsætTimer(worksOnBLL);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            result_txt.Text = BeregnSalær(worksOnDAL.HentSalgspris(SagsID().ToString()), TotHours());

        }

        private void beregn_hentData_btn_Click(object sender, EventArgs e)
        {
            WorksOnBLL worksOnBLL = new WorksOnBLL();
            WorksOnDAL worksOnDAL = new WorksOnDAL(worksOnBLL);

            try
            {
                EjendomsmæglerBLL ejendomsmægler = worksOnDAL.HentMægler(SagsID(), HandelID());

                beregn_mæglerID_cbox.Text = ejendomsmægler.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private string BeregnSalær(int salgspris, int antalTimer)
        {
            int salær = antalTimer * 150;

            salær += salgspris / 100 * 2;

            return salær.ToString();
        }

        //private void btn_beregnSalær_Click(object sender, EventArgs e)
        //{
        //    string sagsid = null;
        //    handel = new HandelDAL();

        //    if (sagID_txt != null)
        //        sagsid = sagID_txt.Text;

        //    int salgspris = handel.HentSalgsPris(sagsid);
        //    int.TryParse(antalTimer_txt.Text, out int antaltimer);

        //    resut_txt.Text = BeregnSalær(salgspris, antaltimer);

        //}

        #region Convert TextBoxes
        private int HandelID()
        {
            string[] handelID_txt = beregn_handleID_cbox.SelectedIndex.ToString().Split(' ');
            int.TryParse(handelID_txt[0], out int handelID);
            return handelID;
        }

        private int MæglerID()
        {
            string[] mælgerID_txt = beregn_mæglerID_cbox.SelectedItem.ToString().Split(' ');
            int.TryParse(mælgerID_txt[0], out int mælgerID);
            return mælgerID;
        }

        private int SagsID()
        {
            string[] sagsID_txt = beregn_sagsID_cbox.SelectedItem.ToString().Split(' ');
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
