using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projektopgaven_BobedreMæglerneAS;

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

        public static void OpretBolig() 
        {
            // Create a new instance of the BoligUI class
            BoligUI boligUI = new BoligUI();

            // Show the settings form
            boligUI.Show();

            // Disable not needed buttons
            boligUI.GetHentBoligButton().Visible = false;
            boligUI.GetSletBoligButton().Visible = false;
            boligUI.GetClearHentBoligButton().Visible = false;
            boligUI.GetAllowRedigeringButton().Visible = false;
            boligUI.GetSaveChangesButton().Visible = false;

            // Disable not needed textboxes
            boligUI.GetBoligIDTextbox().Enabled = false;
            boligUI.GetBoligRenoveringsÅrDateTimePicker().Enabled = false;
            boligUI.GetBoligUdbudsprisTextbox().Enabled = false;
        }

        public static void HentOpdaterBolig()
        {            
            // Create a new instance of the BoligUI class
            BoligUI boligUI = new BoligUI();

            // Show the settings form
            boligUI.Show();

            // Disable not needed buttons
            boligUI.GetOpretBoligButton().Visible = false;
            boligUI.GetSletBoligButton().Visible = false;
            boligUI.GetClearOpretBoligButton().Visible = false;

            boligUI.DisableAll();
            boligUI.GetBoligIDTextbox().Enabled = true;
        }

        public static void HentOpdaterBolig(string boligid)
        {
            // Create a new instance of the BoligUI class
            BoligUI boligUI = new BoligUI();

            // Show the settings form
            boligUI.Show();

            // Disable not needed buttons
            boligUI.GetOpretBoligButton().Visible = false;
            boligUI.GetSletBoligButton().Visible = false;
            boligUI.GetClearOpretBoligButton().Visible = false;

            boligUI.DisableAll();
            boligUI.GetBoligIDTextbox().Enabled = true;

            boligUI.GetBoligIDTextbox().Text = boligid;
            boligUI.HentClick();
        }

        public static void SletBolig()
        {            
            // Create a new instance of the BoligUI class
            BoligUI boligUI = new BoligUI();

            // Show the settings form
            boligUI.Show();

            // Disable not needed buttons
            boligUI.GetOpretBoligButton().Visible = false;
            boligUI.GetHentBoligButton().Visible = false;
            boligUI.GetClearOpretBoligButton().Visible = false;
            boligUI.GetClearHentBoligButton().Visible = false;
            boligUI.GetAllowRedigeringButton().Visible = false;
            boligUI.GetSaveChangesButton().Visible = false;

            // Disable not needed TextBoxes
            boligUI.DisableAll();
            boligUI.GetBoligIDTextbox().Enabled = true;
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


        public static void SælgerOpret()
        {
            // Create a new instance of the SælgerUI class
            SælgerUI sælgerUI = new SælgerUI();

            // Show the settings form
            sælgerUI.Show();

            sælgerUI.GetHentSælgerKnap().Visible = false;
            sælgerUI.GetOpdaterSælgerKnap().Visible = false;
            sælgerUI.GetSletSælgerKnap().Visible = false;
            sælgerUI.GetSælgerIDTekstboks().Enabled = false;
        }

        public static void SælgerHent()
        {
            // Create a new instance of the SælgerUI class
            SælgerUI sælgerUI = new SælgerUI();

            // Show the settings form
            sælgerUI.Show();

            sælgerUI.GetOpretSælgerKnap().Visible = false;
            sælgerUI.GetOpdaterSælgerKnap().Visible = false;
            sælgerUI.GetSletSælgerKnap().Visible = false;
        }

        public static void SælgerOpdater()
        {
            // Create a new instance of the SælgerUI class
            SælgerUI sælgerUI = new SælgerUI();

            // Show the settings form
            sælgerUI.Show();

            sælgerUI.GetOpretSælgerKnap().Visible = false;
            sælgerUI.GetHentSælgerKnap().Visible = false;
            sælgerUI.GetSletSælgerKnap().Visible = false;
        }

        public static void SælgerSlet()
        {
            // Create a new instance of the SælgerUI class
            SælgerUI sælgerUI = new SælgerUI();

            // Show the settings form
            sælgerUI.Show();

            sælgerUI.GetOpretSælgerKnap().Visible = false;
            sælgerUI.GetHentSælgerKnap().Visible = false;
            sælgerUI.GetOpdaterSælgerKnap().Visible = false;
            sælgerUI.GetSælgerCPRTekstboks().Enabled = false;
            sælgerUI.GetSælgerTelefonTekstboks().Enabled = false;
            sælgerUI.GetSælgerEmailTekstboks().Enabled = false;
            sælgerUI.GetSælgerFnavnTekstboks().Enabled = false;
            sælgerUI.GetSælgerEnavnTekstboks().Enabled = false;
            sælgerUI.GetSælgerVejTekstboks().Enabled = false;
            sælgerUI.GetSælgerPostnummerTekstboks().Enabled = false;
        }

        public static void HandelOpret()
        {
            // Opretter en ny instans af HandelUI klassen
            HandelUI handelUI = new HandelUI();

            // Show the settings form
            handelUI.Show();

            handelUI.GetFindHandelKnap().Visible = false;
            handelUI.GetOpdaterHandelKnap().Visible = false;
            handelUI.GetSletHandelKnap().Visible = false;
            handelUI.GetHandelIDTekstboks().Enabled = false;
        }

        public static void HandelHent()
        {
            // Opretter en ny instans af HandelUI klassen
            HandelUI handelUI = new HandelUI();

            // Show the settings form
            handelUI.Show();

            handelUI.GetOpretHandelKnap().Visible = false;
            handelUI.GetOpdaterHandelKnap().Visible = false;
            handelUI.GetSletHandelKnap().Visible = false;
        }

        public static void HandelOpdater()
        {
            // Opretter en ny instans af HandelUI klassen
            HandelUI handelUI = new HandelUI();

            // Show the settings form
            handelUI.Show();

            handelUI.GetOpretHandelKnap().Visible = false;
            handelUI.GetFindHandelKnap().Visible = false;
            handelUI.GetSletHandelKnap().Visible = false;
        }

        public static void HandelSlet()
        {
            // Opretter en ny instans af HandelUI klassen
            HandelUI handelUI = new HandelUI();

            // Show the settings form
            handelUI.Show();

            handelUI.GetOpretHandelKnap().Visible = false;
            handelUI.GetFindHandelKnap().Visible = false;
            handelUI.GetOpdaterHandelKnap().Visible = false;
            handelUI.GetHandelsdatoDatetime().Enabled = false;
            handelUI.GetHandelSalgsprisTekstboks().Enabled = false;
            handelUI.GetHandelSagsIDComboboks().Enabled = false;
            handelUI.GetHandelKøberIDComboboks().Enabled = false;
        }

        public static void ÅbentHus()
        {
            //create a new instance of the ÅbentHusUI class
            ÅbentHusUI åbentHusUI = new ÅbentHusUI();

            //show the settings form
            åbentHusUI.Show();
        }
    }
}
