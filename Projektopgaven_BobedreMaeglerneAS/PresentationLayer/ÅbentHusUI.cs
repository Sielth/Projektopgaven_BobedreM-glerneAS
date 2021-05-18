using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Projektopgaven_BobedreMæglerneAS;
using Projektopgaven_BobedreMaeglerneAS.DataAccessLayer;

namespace Projektopgaven_BobedreMaeglerneAS.PresentationLayer
{
    public partial class ÅbentHusUI : Form
    {
        ÅbentHusDAL åbentHusDAL;

        public ÅbentHusUI()
        {
            InitializeComponent();

            åbentHusDAL = new ÅbentHusDAL(åbentHus_boligListe_lbox, åbentHus_bogstav1_txt, åbentHus_bogstav2_txt);
            Thread t1 = new Thread(new ThreadStart(åbentHusDAL.GenerateBolig));
            t1.IsBackground = true;
            t1.Start();
        }

        private void åbentHus_boligListe_lbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var text = åbentHus_boligListe_lbox.SelectedItem;
            string[] boligid = null;
            
            if (text != null)
            {
                try
                {
                    boligid = text.ToString().Split(' ');
                    MenuBarKnapper.HentOpdaterBolig(boligid[1]);
                }
                catch (NullReferenceException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
