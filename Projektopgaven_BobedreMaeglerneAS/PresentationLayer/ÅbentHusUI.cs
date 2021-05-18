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

            //make new instance of ÅbentHusDAL class with reference to åbentHus_boligListe_lbox, åbentHus_bogstav1_txt, åbentHus_bogstav2_txt
            åbentHusDAL = new ÅbentHusDAL(åbentHus_boligListe_lbox, åbentHus_bogstav1_txt, åbentHus_bogstav2_txt);

            //initialize a new thread with ThreadStart calling GeneratebOLIG method
            Thread t1 = new Thread(new ThreadStart(åbentHusDAL.GenerateBolig));

            //t1 is set as Background, so that it doesn't interfere with the main thread running the Application
            //and so that we can close the form without triggering a NullReference exception (thread pointing to null)
            //because since it is working in the background, it is going to be closed as soon as the main thread gets closed
            t1.IsBackground = true;

            //Thread t1 is starting now
            t1.Start();
        }


        //method that reacts when an element is selected from the ListBox
        private void åbentHus_boligListe_lbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //saving the selected item in a variable
            var text = åbentHus_boligListe_lbox.SelectedItem;

            //initialization of a string[]
            string[] boligid;
            
            if (text != null)
            {
                try
                {
                    //split the text to find the BoligID
                    boligid = text.ToString().Split(' ');

                    //calling method HentOpdaterBolig with parameter string BoligID (the one we've just found)
                    //this method opens the window to retrieve a BoligBLL from the db
                    //with the BoligID passed in the parameter (aka. the selected item in the form)
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
