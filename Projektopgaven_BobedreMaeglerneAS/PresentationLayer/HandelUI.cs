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
    public partial class HandelUI : Form
    {
        public HandelUI()
        {
            InitializeComponent();
        }

        private void btn_oprethandel_Click(object sender, EventArgs e)
        {
            HandelBLL handelBLL = new HandelBLL(HandelID(), Handelsddato(), HandelSalgspris(), HandelSagsID(), HandelKøberID());
            HandelDAL handelDAL = new HandelDAL(handelBLL);

            //Kalder metoden: OpretHandel
            handelDAL.OpretHandel(handelBLL);

            ////Loader data fra databasen ind i datagridview -
            //HandelUI_Load(sender, e);
        }

        private void btn_findhandel_Click(object sender, EventArgs e)
        {
            HandelBLL handelBLL = new HandelBLL(HandelID(), Handelsddato(), HandelSalgspris(), HandelSagsID(), HandelKøberID());
            HandelDAL handelDAL = new HandelDAL(handelBLL);

            //Kalder metoden: OpretHandel
            handelDAL.FindHandel(handelBLL);

            ////Loader data fra databasen ind i datagridview -
            //HandelUI_Load(sender, e);
        }

        private void btn_opdaterhandel_Click(object sender, EventArgs e)
        {
            HandelBLL handelBLL = new HandelBLL(HandelID(), Handelsddato(), HandelSalgspris(), HandelSagsID(), HandelKøberID());
            HandelDAL handelDAL = new HandelDAL(handelBLL);

            //Kalder metoden: OpretHandel
            handelDAL.OpdaterHandel(handelBLL);

            ////Loader data fra databasen ind i datagridview -
            //HandelUI_Load(sender, e);
        }

        private void btn_slethandel_Click(object sender, EventArgs e)
        {
            HandelBLL handelBLL = new HandelBLL(HandelID(), Handelsddato(), HandelSalgspris(), HandelSagsID(), HandelKøberID());
            HandelDAL handelDAL = new HandelDAL(handelBLL);

            //Kalder metoden: OpretHandel
            handelDAL.SletHandel(handelBLL);

            ////Loader data fra databasen ind i datagridview -
            //HandelUI_Load(sender, e);
        }


        #region Konveter Tekstbokse
        public int HandelID()
        {
            int.TryParse(handelID_txt.Text, out int handelid);
            return handelid;
        }

        public DateTime Handelsddato()
        {
            DateTime.TryParse(dateTimePicker1.Text, out DateTime handelsdato);
            return handelsdato;
        }

        public int HandelSalgspris()
        {
            int.TryParse(handelSalgspris_txt.Text, out int handelsalgspris);
            return handelsalgspris;
        }

        public int HandelSagsID()
        {
            int.TryParse(handelSalgsID_cbox.Text, out int handelsalgsid);
            return handelsalgsid;
        }

        public int HandelKøberID()
        {
            int.TryParse(handelKøberID_txt.Text, out int handelkøberid);
            return handelkøberid;
        }
        #endregion
    }
}
