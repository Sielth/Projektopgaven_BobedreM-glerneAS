using Projektopgaven_BobedreMaeglerneAS.BusinessLogicLayer;
using Projektopgaven_BobedreMaeglerneAS.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Projektopgaven_BobedreMaeglerneAS.PresentationLayer
{
    public partial class HandelUI : Form
    {
        KøberDAL køber;
        SagDAL sag;

        HandelBLL handel;
        StatistikBLL statistik;
        SagBLL sagBLL;

        public HandelUI()
        {
            InitializeComponent();

            køber = new KøberDAL(handelKøberID_cbox);
            sag = new SagDAL(handelSalgsID_cbox);

            Thread t1 = new Thread(new ThreadStart(køber.GenerateKøber));
            t1.IsBackground = true;
            t1.Start();

            Thread t2 = new Thread(new ThreadStart(sag.GenerateSag));
            t2.IsBackground = true;
            t2.Start();
        }

        private void HandelUI_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'handelDataSet.Handel' table. You can move, or remove it, as needed.
            this.handelTableAdapter.Fill(this.handelDataSet.Handel);

        }

        #region Opret Handel
        private void btn_oprethandel_Click(object sender, EventArgs e)
        {
            handel = new HandelBLL(HandelID(), Handelsdato(), HandelSalgspris(), HandelSagsID(), HandelKøberID());
            sagBLL = new SagBLL(HandelSagsID());

            try
            {
                if (!HandelBLL.HandelExists(HandelSagsID())) //if there is no handel with the chosen SagsID
                {
                    //OpretHandel
                    handel.OpretHandel(handel);

                    //retireve HandelID from DB
                    HandelBLL matchinghandel = HandelBLL.FindHandel(handel);

                    handelID_txt.Text = matchinghandel.HandelID.ToString();

                    //Luk sagen
                    if (SagBLL.SagExists(HandelSagsID()))
                        sagBLL.LukSag(sagBLL);
                }
                else
                {
                    MessageBox.Show("En faktura (handel) for denne sag har allerede været oprettet.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //Loader data fra databasen ind i datagridview -
            HandelUI_Load(sender, e);

            //disable all TextBoxes
            DisableAll();
        }

        private void clearOpret_btn_Click(object sender, EventArgs e)
        {
            //clear all TextBoxes
            ClearAll();

            //enable all TextBoxes
            EnableAll();

            //disable BoligID, RenoveringsÅr, Udbudspris TextBoxes
            handelID_txt.Enabled = false;
        }
        #endregion

        #region Hent Handel / Opdater Handel
        private void btn_findhandel_Click(object sender, EventArgs e)
        {
            handel = new HandelBLL(HandelID());

            try
            {
                if (HandelBLL.HandelIDExists(HandelID()))
                {
                    HandelBLL matchinghandel = HandelBLL.FindHandelViaID(handel);
                    //Kalder metoden: OpretHandel

                    handelSalgsID_cbox.Text = matchinghandel.SagsID.ToString();
                    handelKøberID_cbox.Text = matchinghandel.KøberID.ToString();
                    handelSalgspris_txt.Text = matchinghandel.Salgspris.ToString();
                    dateTimePicker1.Value = matchinghandel.Handelsdato;
                }
                else
                    MessageBox.Show("Der findes ikke nogen handel i database med dette ID. Prøv venligst med en anden ID.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            handelID_txt.Enabled = false;

            //Loader data fra databasen ind i datagridview -
            HandelUI_Load(sender, e);
        }

        private void allowRedigering_btn_Click(object sender, EventArgs e)
        {
            //enable all TextBoxes
            EnableAll();

            //disable BoligID TextBox
            handelID_txt.Enabled = false;
        }

        private void btn_opdaterhandel_Click(object sender, EventArgs e)
        {
            handel = new HandelBLL(HandelID(), Handelsdato(), HandelSalgspris(), HandelSagsID(), HandelKøberID());

            try
            {
                if (HandelBLL.HandelIDExists(HandelID()))
                {
                    handel.OpdaterHandel(handel);

                    btn_findhandel_Click(sender, e);
                }
                else
                    MessageBox.Show("Der findes ikke nogen handel i database med dette ID. Prøv venligst med en anden ID.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //Loader data fra databasen ind i datagridview -
            HandelUI_Load(sender, e);

            //disable all TextBoxes
            DisableAll();
        }

        private void clearOpdater_btn_Click(object sender, EventArgs e)
        {
            //clear all TextBoxes
            ClearAll();

            //disable all TextBoxes
            DisableAll();

            //enable BoligID TextBox
            handelID_txt.Enabled = true;
        }
        #endregion

        #region Slet Handel
        private void btn_slethandel_Click(object sender, EventArgs e)
        {
            handel = new HandelBLL(HandelID());

            try
            {
                if (HandelBLL.HandelIDExists(HandelID()))
                {
                    //Kalder metoden: OpretHandel
                    handel.SletHandel(handel);
                }
                else
                    MessageBox.Show("Der findes ikke nogen handel i database med dette ID. Prøv venligst med en anden ID.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //Loader data fra databasen ind i datagridview -
            HandelUI_Load(sender, e);

            //clear all TextBoxes
            ClearAll();

            //disable all TextBoxes
            DisableAll();

            //enable BoligID TextBox
            handelID_txt.Enabled = true;
        }

        #endregion

        #region Konverter Tekstbokse
        public int HandelID()
        {
            int.TryParse(handelID_txt.Text, out int handelid);
            return handelid;
        }

        public DateTime Handelsdato()
        {
            //DateTime.TryParse(dateTimePicker1.Text, out DateTime handelsdato);
            return GetStartDate().Value;
        }

        public int HandelSalgspris()
        {
            int.TryParse(handelSalgspris_txt.Text, out int handelsalgspris);
            return handelsalgspris;
        }

        private int HandelSagsID()
        {
            if (handelSalgsID_cbox.SelectedItem != null)
            {
                var selected = handelSalgsID_cbox.SelectedItem;
                string[] sagsID_txt = handelSalgsID_cbox.SelectedItem.ToString().Split(' ');
                int.TryParse(sagsID_txt[0], out int sagsID);
                return sagsID;
            }
            else
            {
                int.TryParse(handelSalgsID_cbox.Text, out int sagsID);
                return sagsID;
            }
        }

        public int HandelKøberID()
        {
            var selected = handelKøberID_cbox.SelectedItem;
            string[] køberID_txt = handelKøberID_cbox.Text.ToString().Split(' ');
            int.TryParse(køberID_txt[0], out int køberID);
            return køberID;
        }
        #endregion

        #region MENUBARKNAPPER
        //MENU
        //HANDEL MENUBARKNAPPER - I HANDEL MENU
        private void createToolStripMenuItem1_Click(object sender, EventArgs e) //Opret handel
        {
            MenuBarKnapper.HandelOpret();
        }

        private void readToolStripMenuItem1_Click(object sender, EventArgs e) //Find handel
        {
            MenuBarKnapper.HandelHent();
        }

        //private void updateToolStripMenuItem1_Click(object sender, EventArgs e) //Opdater handel
        //{
        //    MenuBarKnapper.HandelOpdater();
        //}

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e) //Slet handel
        {
            MenuBarKnapper.HandelSlet();
        }
        private void udtrækStatistikToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MenuBarKnapper.HandelStatistik();
        }

        //EJENDOMSMÆGLER MENUBARKNAPPER - I HANDEL MENU
        private void ejendomsmægler_createToolStripMenuItem_Click(object sender, EventArgs e) //Opret ejendomsmægler
        {
            MenuBarKnapper.EjendomsmælgerOpret();
        }

        private void ejendomsmægler_readToolStripMenuItem_Click(object sender, EventArgs e) //Hent ejendomsmægler
        {
            MenuBarKnapper.EjendomsmæglerHentOpdater();
        }

        //private void ejendomsmægler_updateToolStripMenuItem_Click(object sender, EventArgs e) //Opdater ejendomsmægler
        //{
        //    MenuBarKnapper.EjendomsmæglerOpdater();
        //}

        private void ejendomsmægler_deleteToolStripMenuItem_Click(object sender, EventArgs e) //Slet ejendomsmægler
        {
            MenuBarKnapper.EjendomsmæglerSlet();
        }

        //KØBER MENUBARKNAPPER - I HANDEL MENU
        private void køber_createToolStripMenuItem1_Click(object sender, EventArgs e) //Opret køber
        {
            MenuBarKnapper.KøberCreate();
        }

        private void køber_readToolStripMenuItem1_Click(object sender, EventArgs e) //Hent køber
        {
            MenuBarKnapper.KøberRead();
        }

        //private void køber_updateToolStripMenuItem1_Click(object sender, EventArgs e) //Opdater køber
        //{
        //    MenuBarKnapper.KøberUpdate();
        //}

        private void køber_deleteToolStripMenuItem1_Click(object sender, EventArgs e) //Slet køber
        {
            MenuBarKnapper.KøberDelete();
        }

        //SÆLGER MENUBARKNAPPER - I HANDEL MENU
        private void sælger_createToolStripMenuItem_Click(object sender, EventArgs e) //Opret sælger
        {
            MenuBarKnapper.SælgerOpret();
        }

        private void sælger_readToolStripMenuItem_Click(object sender, EventArgs e) //Hent sælger
        {
            MenuBarKnapper.SælgerHentOpdater();
        }

        //private void sælger_updateToolStripMenuItem_Click(object sender, EventArgs e) //Opdater sælger
        //{
        //    MenuBarKnapper.SælgerOpdater();
        //}

        private void sælger_deleteToolStripMenuItem_Click(object sender, EventArgs e) //Slet sælger
        {
            MenuBarKnapper.SælgerSlet();
        }

        //BOLIG MENUBARKNAPPER - I HANDEL MENU
        private void bolig_createToolStripMenuItem2_Click(object sender, EventArgs e) //Opret bolig
        {
            MenuBarKnapper.OpretBolig();
        }

        private void bolig_readToolStripMenuItem2_Click(object sender, EventArgs e) //Hent og opdater bolig
        {
            MenuBarKnapper.HentOpdaterBolig();
        }

        private void bolig_deleteToolStripMenuItem2_Click(object sender, EventArgs e) //Slet bolig
        {
            MenuBarKnapper.SletBolig();
        }

        private void komTilÅbentHusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuBarKnapper.ÅbentHus();
        }

        //SAG MENUBARKNAPPER - I HANDEL MENU
        private void createToolStripMenuItem_Click(object sender, EventArgs e) //Opret sag
        {
            MenuBarKnapper.SagOpret();
        }

        private void readToolStripMenuItem_Click(object sender, EventArgs e) //Hent sag
        {
            MenuBarKnapper.SagHent();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e) //Opdater sag
        {
            MenuBarKnapper.SagOpdater();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e) //Slet sag
        {
            MenuBarKnapper.SagSlet();
        }
        #endregion

        #region Statistik
        private void button1_Click(object sender, EventArgs e) //udtræk statistik
        {
            //HandelBLL handelBLL = new HandelBLL(HandelID(), Handelsddato(), HandelSalgspris(), HandelSagsID(), HandelKøberID());
            //HandelDAL handelDAL = new HandelDAL(handelBLL);
            //statistik.StatsToText();
            //statistikdal.SoldProperties(dateTimePicker1.Value, dateTimePicker3.Value);

            statistik = new StatistikBLL();
            statistik.SoldPropertiesToListbox(dateTimePicker1.Value, dateTimePicker3.Value, statistik_solgteboliger_lbox);

            //DateTime from, to;

            //try
            //{
            //    DateTime.ParseExact ("yyyy-MM-dd HH:mm:ss:fff", dateTimePicker1, )
            //}

            //List<StatistikBLL> stats = statistikdal.SoldProperties(dateTimePicker1.Value, dateTimePicker3.Value);

            //foreach (StatistikBLL stat in stats)
            //    Console.WriteLine(stat.ToString());

            //var output = statistik_solgteboliger_lbox;

            //output.Items.Add("Adresse\t\tPostnummer\tMægler\tPris\tHandelsdato");
            //foreach (StatistikBLL stat in stats)
            //    output.Items.Add(stat.ToString());
        }

        private void save_Click(object sender, EventArgs e)
        {
            statistik = new StatistikBLL();

            statistik.StatsToTextChooseFilePath(dateTimePicker1.Value, dateTimePicker3.Value, saveFileDialog1);
        }

        private void resourcesSave_btn_Click(object sender, EventArgs e)
        {
            StatistikBLL.StatsToText(dateTimePicker1.Value, dateTimePicker3.Value);

            if (Directory.Exists(StatistikBLL.Path()))
            {
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo
                {
                    Arguments = StatistikBLL.Path(),
                    FileName = "explorer.exe"
                };

                System.Diagnostics.Process.Start(startInfo);
            }
            else
                MessageBox.Show("Cannot find directory to open Salgsoversigt.");
        }
        #endregion

        #region Validating HandelID
        private void handelID_txt_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;

            if (!IsValidHandleID(handelID_txt.Text, out errorMsg))
            {
                //Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                handelID_txt.Select(0, handelID_txt.Text.Length);

                //Set the ErrorProvider error with the text to display. 
                this.errorProvider1.SetError(handelID_txt, errorMsg);
            }
        }

        private void handelID_txt_Validated(object sender, EventArgs e)
        {
            //If all conditions have been met, clear the ErrorProvider of errors.
            errorProvider1.SetError(handelID_txt, "");
        }

        private bool IsValidHandleID(string handelid, out string errorMsg)
        {
            if (handelid.Length > 4)
            {
                errorMsg = "Indtast en Handel ID mellem 1-999";
                return false;
            }

            if (int.TryParse(handelid, out int result) || string.IsNullOrEmpty(handelid))
            {
                errorMsg = "";
                return true;
            }

            errorMsg = "Handel ID kan kun indeholde numre";
            return false;
        }
        #endregion

        #region Validating Salgspris
        private void handelSalgspris_txt_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;

            if (!IsValidSalgspris(handelSalgspris_txt.Text, out errorMsg))
            {
                //Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                handelSalgspris_txt.Select(0, handelSalgspris_txt.Text.Length);

                //Set the ErrorProvider error with the text to display. 
                this.errorProvider1.SetError(handelSalgspris_txt, errorMsg);
            }
        }

        private void handelSalgspris_txt_Validated(object sender, EventArgs e)
        {
            //If all conditions have been met, clear the ErrorProvider of errors.
            errorProvider1.SetError(handelSalgspris_txt, "");
        }

        private bool IsValidSalgspris(string salgspris, out string errorMsg)
        {
            if (salgspris.Length > 9)
            {
                errorMsg = "Indtast en salgspris mellem 1-999999999";
                return false;
            }

            if (int.TryParse(salgspris, out int result) || string.IsNullOrEmpty(salgspris))
            {
                errorMsg = "";
                return true;
            }

            errorMsg = "Handel ID kan kun indeholde numre";
            return false;
        }
        #endregion

    }
}
