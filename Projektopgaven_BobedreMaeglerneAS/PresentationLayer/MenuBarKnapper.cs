using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projektopgaven_BobedreMaeglerneAS.PresentationLayer
{
    class MenuBarKnapper
    {
        public static void KøberCreate()
        {
            //if (Application.OpenForms.OfType<KøberUI>().Count() == 0)
            //{
            //    KøberUI køberUI = new KøberUI();
            //    køberUI.Show();
            //}
            KøberUI køberUI = new KøberUI();
            køberUI.Show();
            køberUI.KøberID_txt.Enabled = true;
            køberUI.KøberCPR_txt.Enabled = true;
            køberUI.KøberFornavn_txt.Enabled = true;
            køberUI.KøberEfternavn_txt.Enabled = true;
            køberUI.KøberEmail_txt.Enabled = true;
            køberUI.KøberTelefon_txt.Enabled = true;
            køberUI.KøberVej_txt.Enabled = true;
            køberUI.KøberPostnummer_txt.Enabled = true;
            //køberUI.OpretKøber_knap.Visible = true;
            //køberUI.SletKøber_knap.Visible = false;
            //køberUI.OpdaterKøber_knap.Visible = false;
            //køberUI.FindKøber_knap.Visible = false;
        }
        public static void KøberRead()
        {
            KøberUI køberUI = new KøberUI();
            køberUI.Show();
            køberUI.KøberID_txt.Enabled = true;
            køberUI.KøberCPR_txt.Enabled = true;
            køberUI.KøberFornavn_txt.Enabled = true;
            køberUI.KøberEfternavn_txt.Enabled = true;
            køberUI.KøberEmail_txt.Enabled = true;
            køberUI.KøberTelefon_txt.Enabled = true;
            køberUI.KøberVej_txt.Enabled = true;
            køberUI.KøberPostnummer_txt.Enabled = true;
            //køberUI.OpretKøber_knap.Visible = false;
            //køberUI.SletKøber_knap.Visible = false;
            //køberUI.OpdaterKøber_knap.Visible = false;
            //køberUI.FindKøber_knap.Visible = true;
        }
        public static void KøberDelete()
        {
            KøberUI køberUI = new KøberUI();
            køberUI.Show();
            køberUI.KøberID_txt.Enabled = true;
            køberUI.KøberCPR_txt.Enabled = true;
            køberUI.KøberFornavn_txt.Enabled = true;
            køberUI.KøberEfternavn_txt.Enabled = true;
            køberUI.KøberEmail_txt.Enabled = true;
            køberUI.KøberTelefon_txt.Enabled = true;
            køberUI.KøberVej_txt.Enabled = true;
            køberUI.KøberPostnummer_txt.Enabled = true;
            //køberUI.OpretKøber_knap.Visible = false;
            //køberUI.SletKøber_knap.Visible = true;
            //køberUI.OpdaterKøber_knap.Visible = false;
            //køberUI.FindKøber_knap.Visible = false;
        }
        public static void KøberUpdate()
        {
            KøberUI køberUI = new KøberUI();
            køberUI.Show();
            køberUI.KøberID_txt.Enabled = true;
            køberUI.KøberCPR_txt.Enabled = true;
            køberUI.KøberFornavn_txt.Enabled = true;
            køberUI.KøberEfternavn_txt.Enabled = true;
            køberUI.KøberEmail_txt.Enabled = true;
            køberUI.KøberTelefon_txt.Enabled = true;
            køberUI.KøberVej_txt.Enabled = true;
            køberUI.KøberPostnummer_txt.Enabled = true;
            //køberUI.OpretKøber_knap.Visible = false;
            //køberUI.SletKøber_knap.Visible = false;
            //køberUI.OpdaterKøber_knap.Visible = true;
            //køberUI.FindKøber_knap.Visible = false;
        }
    }
}
