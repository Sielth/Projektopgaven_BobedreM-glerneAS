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

        public static void EjendomsmælgerOpret()
        {
            // Opretter en ny instans af EjendomsmæglerUI klassen
            EjendomsmæglerUI ejendomsmæglerUI = new EjendomsmæglerUI();

            // Show the settings form
            ejendomsmæglerUI.Show();

            ejendomsmæglerUI.GetHentEjendomsmæglerKnap().Visible = false;
            ejendomsmæglerUI.GetOpdaterEjendomsmæglerKnap().Visible = false;
            ejendomsmæglerUI.GetSletEjendomsmæglerKnap().Visible = false;
            ejendomsmæglerUI.GetMæglerIDTekstboks().Enabled = false;
        }

        public static void EjendomsmæglerHent()
        {
            // Opretter en ny instans af EjendomsmæglerUI klassen
            EjendomsmæglerUI ejendomsmæglerUI = new EjendomsmæglerUI();

            // Show the settings form
            ejendomsmæglerUI.Show();

            ejendomsmæglerUI.GetOpretEjendomsmæglerKnap().Visible = false;
            ejendomsmæglerUI.GetOpdaterEjendomsmæglerKnap().Visible = false;
            ejendomsmæglerUI.GetSletEjendomsmæglerKnap().Visible = false;
        }

        public static void EjendomsmæglerOpdater()
        {
            // Opretter en ny instans af EjendomsmæglerUI klassen
            EjendomsmæglerUI ejendomsmæglerUI = new EjendomsmæglerUI();

            // Show the settings form
            ejendomsmæglerUI.Show();

            ejendomsmæglerUI.GetOpretEjendomsmæglerKnap().Visible = false;
            ejendomsmæglerUI.GetHentEjendomsmæglerKnap().Visible = false;
            ejendomsmæglerUI.GetSletEjendomsmæglerKnap().Visible = false;
        }

        public static void EjendomsmæglerSlet()
        {
            // Opretter en ny instans af EjendomsmæglerUI klassen
            EjendomsmæglerUI ejendomsmæglerUI = new EjendomsmæglerUI();

            // Show the settings form
            ejendomsmæglerUI.Show();

            //Skjuler knapper og deaktivere tekstbokse
            ejendomsmæglerUI.GetOpretEjendomsmæglerKnap().Visible = false;
            ejendomsmæglerUI.GetHentEjendomsmæglerKnap().Visible = false;
            ejendomsmæglerUI.GetOpdaterEjendomsmæglerKnap().Visible = false;
            ejendomsmæglerUI.GetCPRTekstboks().Enabled = false;
            ejendomsmæglerUI.GetTelefonTekstboks().Enabled = false;
            ejendomsmæglerUI.GetEmailTekstboks().Enabled = false;
            ejendomsmæglerUI.GetFnavnTekstboks().Enabled = false;
            ejendomsmæglerUI.GetEnavnTekstboks().Enabled = false;
            ejendomsmæglerUI.GetVejTekstboks().Enabled = false;
            ejendomsmæglerUI.GetPostnummerTekstboks().Enabled = false;
        }


        public static void SagOpret()
        {
            //Create a new instance of the SagUI class
            SagUI sagUI = new SagUI();

            // Show the settings form
            sagUI.Show();

            sagUI.GetHentSagKnap().Visible = false;
            sagUI.GetOpdaterSagKnap().Visible = false;
            sagUI.GetSletSagKnap().Visible = false;
            sagUI.GetSagsIDTekstboks().Enabled = false;
        }

        public static void SagHent()
        {
            //Create a new instance of the SagUI class
            SagUI sagUI = new SagUI();

            // Show the settings form
            sagUI.Show();

            sagUI.GetOpretSagKnap().Visible = false;
            sagUI.GetOpdaterSagKnap().Visible = false;
            sagUI.GetSletSagKnap().Visible = false;
        }

        public static void SagOpdater()
        {
            //Create a new instance of the SagUI class
            SagUI sagUI = new SagUI();

            // Show the settings form
            sagUI.Show();

            sagUI.GetOpretSagKnap().Visible = false;
            sagUI.GetHentSagKnap().Visible = false;
            sagUI.GetSletSagKnap().Visible = false;
        }

        public static void SagSlet()
        {
            //Create a new instance of the SagUI class
            SagUI sagUI = new SagUI();

            // Show the settings form
            sagUI.Show();

            sagUI.GetOpretSagKnap().Visible = false;
            sagUI.GetHentSagKnap().Visible = false;
            sagUI.GetOpdaterSagKnap().Visible = false;
            sagUI.GetSagStatusComboboks().Enabled = false;
            sagUI.GetSagBoligIDComboboks().Enabled = false;
            sagUI.GetSagSælgerIDComboboks().Enabled = false;
            sagUI.GetSagMæglerIDComboboks().Enabled = false;
        }


        public static void OpretBolig() { }
        public static void HentOpdaterBolig() { }
        public static void SletBolig() { }
    }
}
