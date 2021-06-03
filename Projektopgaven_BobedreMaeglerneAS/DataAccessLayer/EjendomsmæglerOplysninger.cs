using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Data.SqlClient;
using Projektopgaven_BobedreMaeglerneAS.DataAccessLayer;

namespace Projektopgaven_BobedreMaeglerneAS.BusinessLogicLayer
{
    //This class writes an Ejendomsmægler to a RichTextBox
    //EjendomsmæglerOplysninger is initialized and used in Form1.cs
    //as soon as the window Homepage is initialized (constructor)
    class EjendomsmæglerOplysninger
    {
        //delegate that allows method DisplayEjendomsmægler to be called
        //in the thread that creates and maintains the GUI
        private delegate void DisplayDelegate(EjendomsmæglerBLL ejendomsmægler);

        //creates a new instance of ConnectionSingleton via method Instance
        private static ConnectionSingleton s1 = ConnectionSingleton.Instance(); 

        private int index = 0; //counter to loop through Ejendomsmæglerne list
        private RichTextBox output; //RichTextBox to display output
        private List<EjendomsmæglerBLL> ejendomsmæglerne; //list that will contain objects of type Ejendomsmægler(name, lastname, tlf)

        //EjendomsmæglerOplysninger constructor
        //every time an instance of the class is made,
        //we need to give it reference to a RichTextBox
        //where the Ejendomsmægler will be displayed
        public EjendomsmæglerOplysninger(RichTextBox richTextBox)
        {
            output = richTextBox;
        } //end

        //method DisplayEjendomsmægler sets the RichTextBox's Text property
        private void DisplayEjendomsmægler(EjendomsmæglerBLL ejendomsmægler)
        {
            //output Ejendomsmægler in RichTextBox
            output.Text = ejendomsmægler.ToString("B");
        } //end method DisplayEjendomsmægler

        //method Fetch returns a refreshed List<T> containing Ejendomsmægler objects
        public List<EjendomsmæglerBLL> Fetch()
        {
            //initialization of Ejendomsmæglerne List
            ejendomsmæglerne = new List<EjendomsmæglerBLL>();

            using (var conn = new SqlConnection(s1.GetConnectionString()))
            {
                //giving the command
                string sqlCommandFetch = "SELECT * FROM Ejendomsmægler";

                SqlCommand cmdFetch = new SqlCommand(sqlCommandFetch, conn);

                //try catch block just to be sure
                try
                {
                    //open the connection to the DB
                    if (conn.State == System.Data.ConnectionState.Closed)
                        conn.Open();

                    //BEGIN TRANSACTION
                    Transactions.BeginReadCommittedTransaction(conn);

                    //execute the reader that will fetch the records from the DB
                    using (SqlDataReader reader = cmdFetch.ExecuteReader())
                    {
                        //while the reader is reading
                        while (reader.Read())
                        {
                            //add Ejendomsmægler(name, lastname, tlf) to Ejendomsmæglerne list
                            //see constructor in EjendomsmæglerBLL
                            ejendomsmæglerne.Add(new EjendomsmæglerBLL(reader["Fnavn"].ToString(), reader["Enavn"].ToString(), (int)reader["Telefon"], reader["Email"].ToString()));
                        }

                        if (reader != null)
                            reader.Close();
                    }

                    //COMMIT OR ROLLBACK
                    if (!Transactions.Commit(conn))
                        Transactions.Rollback(conn);
                }
                catch (Exception ex)
                {
                    //print the exceptions in the console (on visual studio)
                    //We can change it with a popup message if we want
                    Console.WriteLine(ex.Message);
                }

                //CLOSE CONNECTION
                if (conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }

            //returns list containing Ejendosmægler objects 
            return ejendomsmæglerne;
        }

        //place Ejendomsmægler in GUI
        public void GenerateEjendomsmægler()
        {
            while (true) //infinite lop; will be terminated from outside
            {
                //a thread is started to refresh the Ejendomsmæglerne list through the method Fetch
                ThreadStart start = new ThreadStart(() => Fetch()); //lambda expression, since the method Fetch returns a List<T>
                Thread t1 = new Thread(start); //the thread taking care of refreshing the list is starting now

                //select Ejendomsmægler from the Ejendomsmæglerne list returned from method Fetch via [index]
                EjendomsmæglerBLL ejendomsmægler = Fetch()[index];

                //try catch block just to be sure
                try
                {
                    //display Ejendomsmægler on corresponding RichTextBox
                    output.Invoke(new DisplayDelegate(DisplayEjendomsmægler), new object[] { ejendomsmægler });
                }
                catch (Exception ex)
                {
                    //print the exceptions in the console (on visual studio)
                    //We can change it with a popup message if we want
                    Console.WriteLine(ex.Message);
                }

                //walk through Ejendomsmæglerne list
                index++;

                //if the end of the list is reached
                //go to start
                if (index == ejendomsmæglerne.Count)
                    index = 0;

                //sleep for up to 1 minut
                Thread.Sleep(60000);
            }
        }
    }
}
