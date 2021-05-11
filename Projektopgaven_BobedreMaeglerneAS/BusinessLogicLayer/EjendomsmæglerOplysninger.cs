using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Projektopgaven_BobedreMaeglerneAS.BusinessLogicLayer
{
    class EjendomsmæglerOplysninger
    {
        private int index = 0; //loops through ejendomsmæglerne liste
        private RichTextBox output;
        private List<EjendomsmæglerBLL> ejendomsmæglerne;

        //constructor
        public EjendomsmæglerOplysninger(RichTextBox richTextBox)
        {
            output = richTextBox;
        }

        //delegate 
        private delegate void DisplayDelegate(EjendomsmæglerBLL ejendomsmægler);

        //viser ejendomsmægler i textbox output
        private void DisplayEjendomsmægler(EjendomsmæglerBLL ejendomsmægler)
        {
            output.Text = ejendomsmægler.ToString();
        }


        public List<EjendomsmæglerBLL> Fetch()
        {
            while (true)
            {
                //Thread.Sleep(6000);

                string strconn = "Server=den1.mssql7.gear.host; Database=bobedredb; User ID=bobedredb; Password=Xw8gM?O3doQ_";
                SqlConnection conn = new SqlConnection(strconn);

                string sqlCommandFetch = "SELECT * FROM Ejendomsmægler";
                SqlCommand cmdFetch = new SqlCommand(sqlCommandFetch, conn);

                conn.Open();
                SqlDataReader reader = cmdFetch.ExecuteReader();

                try
                {
                    ejendomsmæglerne = new List<EjendomsmæglerBLL>();

                    while (reader.Read())
                    {
                        ejendomsmæglerne.Add(new EjendomsmæglerBLL(reader["Fnavn"].ToString(), reader["Enavn"].ToString(), (int)reader["Telefon"]));
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    reader.Close();
                    conn.Close();

                    Console.WriteLine("Fetch has been called");
                }

                return ejendomsmæglerne;
            }
        }


        public void GenerateEjendomsmægler()
        {
            while (true)
            {
                ThreadStart start = new ThreadStart(() => Fetch());
                Thread t1 = new Thread(start);

                EjendomsmæglerBLL ejendomsmægler = Fetch()[index];

                try
                {
                    output.Invoke(new DisplayDelegate(DisplayEjendomsmægler), new object[] { ejendomsmægler });
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                index++;

                if (index == ejendomsmæglerne.Count)
                    index = 0;

                Thread.Sleep(6000);
            }
        }
    }
}
