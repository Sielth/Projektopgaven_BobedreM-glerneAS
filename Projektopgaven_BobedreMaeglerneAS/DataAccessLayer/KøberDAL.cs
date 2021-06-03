using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Projektopgaven_BobedreMaeglerneAS.BusinessLogicLayer;
using System.Threading;
using System.Windows.Forms;


namespace Projektopgaven_BobedreMaeglerneAS.DataAccessLayer
{
    class KøberDAL
    {
        private static ConnectionSingleton s1 = ConnectionSingleton.Instance(); //creates a new instance of ConnectionSingleton via method Instance
        private static SqlConnection conn = s1.GetConnection(); //get the SqlConnection from ConnectionSingleton method GetConnection

        private ComboBox output;

        public KøberDAL()
        {

        }

        #region Threads
        public KøberDAL(ComboBox cBox)
        {
            output = cBox;
        }

        private delegate void DisplayDelegate(List<KøberBLL> købere);

        private void DisplayKøber(List<KøberBLL> købere)
        {
            if (output.Items.Count == 0)
            {
                foreach (KøberBLL køber in købere)
                    output.Items.Add(køber.ToString());
            }
            else
            {
                KøberBLL lastIndexItem = KøberBLL.FromString(output.Items[output.Items.Count - 1].ToString());

                foreach (KøberBLL køber in købere)
                {
                    if (køber.KøberID > lastIndexItem.KøberID)
                        output.Items.Add(køber.ToString());
                }
            } 
        }

        //Metode til at få alle KøberID vist i comboboksen i HandelUI
        //Returnere en liste og KøberBLL
        public List<KøberBLL> FetchKøber()
        {
            //Initialisere liste af KøberBLL købere 
            List<KøberBLL> køber = new List<KøberBLL>();

            using (var conn = new SqlConnection(s1.GetConnectionString()))
            {
                //SQL QUERY
                string sqlcommand = "SELECT * FROM Køber ORDER BY KøberID";

                //SQL COMMAND
                SqlCommand command = new SqlCommand(sqlcommand, conn);

                try
                {
                    //OPEN CONNECTION
                    if (conn.State == System.Data.ConnectionState.Closed)
                        conn.Open();

                    //BEGIN TRANSACTION
                    Transactions.BeginReadCommittedTransaction(conn);

                    //EXECUTE READER (QUERY)
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        //RETRIEVE KøberBLL AND ADD IN køber
                        while (reader.Read())
                        {
                            køber.Add(new KøberBLL((int)reader["KøberID"], reader["Fnavn"].ToString(), reader["Enavn"].ToString()));
                        }

                        //CLOSE READER
                        if (reader != null)
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

            //RETURN
            return køber;
            
        }

        public void GenerateKøber()
        {
            while(true)
            {
                //CHECK IF OUTPUT IS NOT DISPOSED
                if (!output.IsDisposed)
                {
                    //THREAD THAT CALLS FetchKøber WITH A LAMBA FUNCTION (since the method has a return argument)
                    //this will give the user a list of KøberBLL always up to date
                    ThreadStart start = new ThreadStart(() => FetchKøber());
                    Thread t1 = new Thread(start);

                    //the list from FetchKøber is saved in køber
                    List<KøberBLL> købere = FetchKøber();

                    try
                    {
                        //CHECK IF OUTPUT HANDLE HAS NOT BEEN CREATED
                        if (!output.IsHandleCreated)
                        {
                            output.CreateControl(); //CREATES OUPUT CONTROL
                        }
                        output.Invoke(new DisplayDelegate(DisplayKøber), new object[] { købere });
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    Thread.Sleep(6000);
                }
            }
        }

        #endregion

        #region Opret Køber
        //method to create a new KøberBLL
        public void OpretKøber(KøberBLL køber)
        {
            string sqlCommandKøber = "INSERT INTO Køber VALUES (@CPR, @Telefon, @Email, @Fnavn, @Enavn, @Vej, @Postnummer)";
            
            SqlCommand cmdKøber = new SqlCommand(sqlCommandKøber, conn);
            cmdKøber.Parameters.AddWithValue("@CPR", køber.CPR);
            cmdKøber.Parameters.AddWithValue("@Telefon", køber.Telefon);
            cmdKøber.Parameters.AddWithValue("@Email", køber.Email);
            cmdKøber.Parameters.AddWithValue("@Fnavn", køber.Fnavn);
            cmdKøber.Parameters.AddWithValue("@Enavn", køber.Enavn);
            cmdKøber.Parameters.AddWithValue("@Vej", køber.Vej);
            cmdKøber.Parameters.AddWithValue("@Postnummer", køber.Postnummer);
           
            try
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                    conn.Open();
                
                Transactions.BeginRepeatableReadTransaction(conn);
                
                cmdKøber.ExecuteNonQuery();

                if (!Transactions.Commit(conn))
                    Transactions.Rollback(conn);
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }

            if (conn.State == System.Data.ConnectionState.Open)
                conn.Close();
        }
        #endregion

        #region Hent Køber
        public static KøberBLL FindKøber(KøberBLL køberToFind)
        {
            KøberBLL matchingkøber = null;

            string sqlCommandKøber = "SELECT * FROM Køber WHERE KøberID = @KøberID"; //Opretter vores SQL Query

            SqlCommand commandKøber = new SqlCommand(sqlCommandKøber, conn); 

            commandKøber.Parameters.AddWithValue("@KøberID", køberToFind.KøberID); //Henter værdien fra tekstboxen og sætter den til @KøberID
            
            try
            {
                if (conn.State == System.Data.ConnectionState.Closed) //Åbner forbindelse hvis lukket
                    conn.Open();
                
                Transactions.BeginRepeatableReadTransaction(conn);  //Starter transaktion
                
                using (SqlDataReader reader = commandKøber.ExecuteReader()) //Starter reader
                {
                    while (reader.Read()) //Kører igennem reader til vi har alle information for KøberID'et
                    {
                        matchingkøber = new KøberBLL((int)reader["KøberID"],
                            reader["Vej"].ToString(),
                            (int)reader["Postnummer"],
                            (long)reader["CPR"],
                            reader["Fnavn"].ToString(),
                            reader["Enavn"].ToString(),
                            reader["Email"].ToString(),
                            (int)reader["Telefon"]);
                    }

                    if (reader != null) //Lukker reader
                        reader.Close();
                }

                if (!Transactions.Commit(conn)) //Rollback hvis der er fejl i Commit
                    Transactions.Rollback(conn);
            }
            catch (SqlException ex) //Error catching
            {
                Console.WriteLine(ex);
            }

            if (conn.State == System.Data.ConnectionState.Open) //Lukker forbindelse
                conn.Close();

            return matchingkøber; //Returnerer reader data
        }
        #endregion

        #region Opdater Køber
        public void OpdaterKøber(KøberBLL køber) //Opdaterer køber
        {
            //Tjekker om tekstboxe var tomme og undlader at opdaterer informationer for dem der er tomme
            string sqlCommandKøber = "UPDATE Køber SET " +
                "CPR = IsNull(NullIf(@CPR, ''), CPR), " +
                "Telefon = IsNull(NullIf(@Telefon, ''), Telefon), " +
                "Email = IsNull(NullIf(@Email, ''), Email), " +
                "Fnavn = IsNull(NullIf(@Fnavn, ''), Fnavn), " +
                "Enavn = IsNull(NullIf(@Enavn, ''), Enavn), " +
                "Vej = IsNull(NullIf(@Vej, ''), Vej), " +
                "Postnummer = IsNull(NullIf(@Postnummer, ''), Postnummer) " +
                "WHERE KøberID = @KøberID";

            //Sender input til database for at opdatere
            SqlCommand cmdKøber = new SqlCommand(sqlCommandKøber, conn);
            cmdKøber.Parameters.AddWithValue("@KøberID", køber.KøberID);
            cmdKøber.Parameters.AddWithValue("@CPR", køber.CPR);
            cmdKøber.Parameters.AddWithValue("@Telefon", køber.Telefon);
            cmdKøber.Parameters.AddWithValue("@Email", køber.Email);
            cmdKøber.Parameters.AddWithValue("@Fnavn", køber.Fnavn);
            cmdKøber.Parameters.AddWithValue("@Enavn", køber.Enavn);
            cmdKøber.Parameters.AddWithValue("@Vej", køber.Vej);
            cmdKøber.Parameters.AddWithValue("@Postnummer", køber.Postnummer);
            
            try
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                    conn.Open();
                
                Transactions.BeginRepeatableReadTransaction(conn);
                
                cmdKøber.ExecuteNonQuery();

                //COMMIT OR ROLLBACK
                if (!Transactions.Commit(conn))
                    Transactions.Rollback(conn);
            }
            catch (SqlException)
            {
                Transactions.Rollback(conn);
                throw;
            }

            //CLOSE CONNECTION
            if (conn.State == System.Data.ConnectionState.Open)
                conn.Close();
        }
        #endregion
        #region KøberCheck
        public static bool KøberExists(int køberid)
        {
            int userCount = 0;

            //SQL QUERY
            string sqlcommand = "SELECT COUNT (*) FROM Køber WHERE KøberID like @KøberID";

            //SQL COMMAND + PARAMETERS
            SqlCommand cmd = new SqlCommand(sqlcommand, conn);
            cmd.Parameters.AddWithValue("@KøberID", køberid);

            try
            {
                //OPEN CONNECTION
                if (conn.State == System.Data.ConnectionState.Closed)
                    conn.Open();

                //BEGIN TRANSACTION
                Transactions.BeginReadCommittedTransaction(conn);

                userCount = (int)cmd.ExecuteScalar();

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

            if (userCount > 0)
                return true;
            else
                return false;
        }
        public static bool KøberCPRExists(long køberCPR)
        {
            int userCount = 0;

            //SQL QUERY
            string sqlcommand = "SELECT COUNT (*) FROM Køber WHERE CPR like @køberCPR";

            //SQL COMMAND + PARAMETERS
            SqlCommand cmd = new SqlCommand(sqlcommand, conn);
            cmd.Parameters.AddWithValue("@køberCPR", køberCPR);

            try
            {
                //OPEN CONNECTION
                if (conn.State == System.Data.ConnectionState.Closed)
                    conn.Open();

                //BEGIN TRANSACTION
                Transactions.BeginReadCommittedTransaction(conn);

                userCount = (int)cmd.ExecuteScalar();

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

            if (userCount > 0)
                return true;
            else
                return false;
        }
        #endregion

        #region Slet Køber
        public void SletKøber(KøberBLL køber) //Sletter køber
        {
            string sqlCommandKøber = "DELETE FROM Køber WHERE KøberID = @KøberID";

            SqlCommand cmdKøber = new SqlCommand(sqlCommandKøber, conn);
            cmdKøber.Parameters.AddWithValue("@KøberID", køber.KøberID);

            try
            {
                //OPEN CONNECTION
                if (conn.State == System.Data.ConnectionState.Closed)
                    conn.Open();

                //BEGIN TRANSACTION
                Transactions.BeginRepeatableReadTransaction(conn);

                //EXECUTE QUERY
                cmdKøber.ExecuteNonQuery();

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
        #endregion
    }
}