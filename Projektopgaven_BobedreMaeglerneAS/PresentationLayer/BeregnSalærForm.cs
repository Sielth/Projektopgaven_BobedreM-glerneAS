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
            InitializeComponent();

            sag = new SagDAL(beregn_sagsID_cbox);
            Thread t2 = new Thread(new ThreadStart(sag.GenerateSag));
            t2.IsBackground = true;
            t2.Start();

            beregn_mæglerID_txt.Enabled = false;
        }

        private void btn_indsæt_Click(object sender, EventArgs e)
        {
            worksOn = new WorksOnBLL(SagsID(), TotHours());

            beregn_hentData_btn_Click(sender, e);

            try
            {
                if (!WorksOnBLL.RecordExists(SagsID())) //if there is no record in the db then create new
                    worksOn.IndsætTimer(worksOn);
                else //else update the existing record
                    worksOn.Update(worksOn);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (HandelDAL.HandelExists(SagsID())) //if there is a handel record in the Handel tabel
                result_txt.Text = worksOn.BeregnSalær(WorksOnBLL.HentSalgspris(SagsID().ToString()), TotHours()); //beregn salær med en procentsats af boligens salgspris
            else 
                result_txt.Text = worksOn.BeregnSalær(0, TotHours()); //else beregn TotHours * 150 kr
        }

        private void beregn_hentData_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (SagBLL.SagExists(SagsID()))
                    ejendomsmægler = WorksOnDAL.HentMægler(SagsID());

                if (ejendomsmægler != null)
                    beregn_mæglerID_txt.Text = ejendomsmægler.ToString();
                else
                    MessageBox.Show("Husk at lukke sagen, før at beregne din salær!" +
                        "\nEller, prøv at vælge en sag fra boxen \"SagsID\"...");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            ClearAll();
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

        #region Validating AntalTimer
        private void antalTimer_txt_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;

            if (!ValidAntalTimer(antalTimer_txt.Text, out errorMsg))
            {
                //Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                antalTimer_txt.Select(0, antalTimer_txt.Text.Length);

                //Set the ErrorProvider error with the text to display. 
                this.errorProvider1.SetError(antalTimer_txt, errorMsg);
            }
        }

        private void antalTimer_txt_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(antalTimer_txt, "");
        }

        //Method to check whether AntalTimer is valid or not
        //It must be only numbers
        //It CAN be empty
        //CANNOT be bigger than 4
        public bool ValidAntalTimer(string antalTimer, out string errorMsg)
        {
            if (antalTimer.Length > 4)
            {
                errorMsg = "Indtast en antal timer mellem 1-999";
                return false;
            }

            if (int.TryParse(antalTimer, out int result) || string.IsNullOrEmpty(antalTimer))
            {
                errorMsg = "";
                return true;
            }

            errorMsg = "Antal timer kan kun indeholde numre, og den kan ikke være tom";
            return false;
        }
        #endregion
    }
}
