using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projektopgaven_BobedreMæglerneAS;
using Projektopgaven_BobedreMaeglerneAS.BusinessLogicLayer;
using System.Threading;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Projektopgaven_BobedreMaeglerneAS.DataAccessLayer
{
    class ÅbentHusDAL : BoligDAL
    {
        private ListBox output;
        private TextBox txt1;
        private TextBox txt2;

        public ÅbentHusDAL(ListBox lBox, TextBox t1, TextBox t2) : base(lBox)
        {
            output = lBox;
            txt1 = t1;
            txt2 = t2;
        }

        private delegate void DisplayDelegateÅbent(List<BoligBLL> boliger);

        protected override void DisplayBolig(List<BoligBLL> boliger)
        {
            output.Items.Clear();

            if (string.IsNullOrEmpty(txt1.Text) && string.IsNullOrEmpty(txt2.Text))
            {
                foreach (BoligBLL bolig in boliger)
                    output.Items.Add(bolig.ToString("B"));
            }
            else if (string.IsNullOrEmpty(txt2.Text))
            {
                char start = txt1.Text.ToUpper()[0];

                foreach (BoligBLL bolig in boliger)
                {
                    if (bolig.Vej.ToUpper()[0] >= start)
                        output.Items.Add(bolig.ToString("B"));
                }
            }
            else
            {
                char start = txt1.Text.ToUpper()[0];
                char end = txt2.Text.ToUpper()[0];

                foreach (BoligBLL bolig in boliger)
                {
                    if (bolig.Vej.ToUpper()[0] >= start && bolig.Vej.ToUpper()[0] <= end)
                        output.Items.Add(bolig.ToString("B"));
                }
            }
        }

        protected override List<BoligBLL> FetchBolig()
        {
            //INITIALIZE List OF BoligBLL boliger
            List<BoligBLL> boliger = new List<BoligBLL>();

            using (var conn = new SqlConnection(ConnectionSingleton.ConnectionString))
            {
                //SQL QUERY
                string sqlCommand = "SELECT * FROM Bolig WHERE BoligID IN (SELECT Sag.BoligID from Sag WHERE Sag.Status = 'Åben')";

                //SQL COMMAND
                SqlCommand cmd = new SqlCommand(sqlCommand, conn);

                try

                {
                    //OPEN CONNECTION
                    if (conn.State == System.Data.ConnectionState.Closed)
                        conn.Open();

                    //BEGIN TRANSACTION
                    Transactions.BeginReadCommittedTransaction(conn);

                    //EXECUTE READER (QUERY)
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        //RETRIEVE BoligBLL AND ADD IN boliger
                        while (reader.Read())
                        {
                            boliger.Add(new BoligBLL((int)reader["BoligID"],
                            reader["Vej"].ToString(),
                            (int)reader["Postnummer"],
                            reader["Type"].ToString(),
                            (int)reader["Værelser"],
                            (int)reader["Etager"],
                            (int)reader["Kvadratmeter"],
                            (int)reader["Udbudspris"],
                            (bool)reader["HaveFlag"],
                            (DateTime)reader["Bygningsår"],
                            (DateTime)reader["RenoveringsÅr"]));
                        }

                        //CLOSE READER
                        reader.Close();
                    }

                    //COMMIT OR ROLLBACK
                    if (!Transactions.Commit(conn))
                        Transactions.Rollback(conn);

                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                //CLOSE CONNECTION
                if (conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }

            //SORT
            boliger.Sort();

            //RETURN
            return boliger;
        }

        public override void GenerateBolig()
        {
            while (true)
            {
                ThreadStart start = new ThreadStart(() => FetchBolig());
                Thread t1 = new Thread(start);

                List<BoligBLL> boliger = FetchBolig();

                try
                {
                    output.Invoke(new DisplayDelegate(DisplayBolig), new object[] { boliger });
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                //Thread.Sleep(500);
            }
        }
    }
}
