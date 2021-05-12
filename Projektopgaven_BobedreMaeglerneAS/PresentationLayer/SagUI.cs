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

namespace Projektopgaven_BobedreMaeglerneAS.PresentationLayer
{
    public partial class SagUI : Form
    {
        BoligDAL bolig = new BoligDAL(new BoligBLL());   

        public SagUI()
        {
            InitializeComponent();

            sag_boligID_cbox.Items.Add(bolig.HentBoligID_cbox());
        }

        private void btn_OpretSag_Click(object sender, EventArgs e)
        {

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
    }
}
