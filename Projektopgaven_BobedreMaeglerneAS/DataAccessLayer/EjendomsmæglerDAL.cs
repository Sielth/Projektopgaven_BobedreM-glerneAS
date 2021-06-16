using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Projektopgaven_BobedreMæglerneAS;
using Projektopgaven_BobedreMaeglerneAS.BusinessLogicLayer;
using Projektopgaven_BobedreMaeglerneAS.DataAccessLayer;
using System.Threading;
using System.Windows.Forms;

namespace Projektopgaven_BobedreMæglerneAS
{
    class EjendomsmæglerDAL
    {
        private static ConnectionSingleton s1 = ConnectionSingleton.Instance(); //creates a new instance of ConnectionSingleton via method Instance
        private static SqlConnection conn = s1.GetConnection(); //get the SqlConnection from ConnectionSingleton method GetConnection

        private ComboBox output;

        public EjendomsmæglerDAL() //EjendomsmæglerDAL constructor - bruges i EjendomsmæglerBLL
        {
            
        }

        #region Threads
        public EjendomsmæglerDAL(ComboBox cBox)
        {
            output = cBox; //output - er comboboks (se linje 20)
        }

        private delegate void DisplayDelegate(List<EjendomsmæglerBLL> ejendomsmæglere); //delegate da windows forms ikke er trådsikkert

        private void DisplayEjendomsmægler(List<EjendomsmæglerBLL> ejendomsmæglere)
        {
            output.Items.Clear(); //tømer comboboksen

            foreach (EjendomsmæglerBLL ejendomsmægler in ejendomsmæglere) //For hver ejendomsmægler i listen, tilføj til comboboksen
                output.Items.Add(ejendomsmægler.ToString()); //tilføjer ejendomsmæglerne til comboboksen
        }

        //method to retrieve all EjendomsmæglerID to show in the ComboBox of SagUI
        //returns a List og EjendomsmæglerBLL
        public List<EjendomsmæglerBLL> FetchEjendomsmægler()
        {
            //INITIALIZE List OF EjendomsmæglerBLL ejendomsmæglere
            List<EjendomsmæglerBLL> ejendomsmægler = new List<EjendomsmæglerBLL>();

            using (var conn = new SqlConnection(s1.GetConnectionString())) //Disposenel connection - så en anden tråd kan komme ind i databasen
            {
                //SQL QUERY
                string sqlCommand = "SELECT * FROM Ejendomsmægler";

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
                        //RETRIEVE EjendomsmæglerBLL AND ADD IN ejendomsmægler
                        while (reader.Read())
                        {
                            //Tilføjer ejendomsmæglerne til listen
                            ejendomsmægler.Add(new EjendomsmæglerBLL((int)reader["MæglerID"], reader["Fnavn"].ToString(), reader["Enavn"].ToString()));
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

            //RETURN
            return ejendomsmægler;
        }

        public void GenerateEjendomsmægler()
        {
            while (true)
            {
                if (!output.IsDisposed) //Tjekker at vi har en "output"
                {
                    ThreadStart start = new ThreadStart(() => FetchEjendomsmægler());
                    Thread t1 = new Thread(start);

                    List<EjendomsmæglerBLL> ejendomsmæglere = FetchEjendomsmægler();

                    try
                    {
                        //CHECK IF OUTPUT HANDLE HAS NOT BEEN CREATED
                        if (!output.IsHandleCreated) //Tjekker om der er en comboboks og ellers oprettes der en på næste linje
                            output.CreateControl(); //CREATES OUPUT CONTROL

                        //Delegate udfører metoden "DisplayEjendomsmægler"
                        output.Invoke(new DisplayDelegate(DisplayEjendomsmægler), new object[] { ejendomsmæglere });
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                    Thread.Sleep(6000); //Tråden som kalder "GenerateEjendomsmægler" (i SagsUI l. 43) sættes til at sove
                }
            }
        }
        #endregion

        #region Opret Ejendomsmægler
        public void OpretEjendomsmægler(EjendomsmæglerBLL ejendomsmægler) //Opret ejendomsmælger
        {
            //Connection string
            ConnectionSingleton s1 = ConnectionSingleton.Instance();
            SqlConnection conn = s1.GetConnection();

            string sqlCommandEjendomsmægler = 
                $"INSERT INTO Ejendomsmægler VALUES (@CPR, @Telefon, @Email, @Fnavn, @Enavn, @Vej, @Postnummer)";

            SqlCommand commandEjendomsmægler = new SqlCommand(sqlCommandEjendomsmægler, conn);

            commandEjendomsmægler.Parameters.AddWithValue("@CPR", ejendomsmægler.CPR);
            commandEjendomsmægler.Parameters.AddWithValue("@Telefon", ejendomsmægler.Telefon);
            commandEjendomsmægler.Parameters.AddWithValue("@Email", ejendomsmægler.Email);
            commandEjendomsmægler.Parameters.AddWithValue("@Fnavn", ejendomsmægler.Fnavn);
            commandEjendomsmægler.Parameters.AddWithValue("@Enavn", ejendomsmægler.Enavn);
            commandEjendomsmægler.Parameters.AddWithValue("@Vej", ejendomsmægler.Vej);
            commandEjendomsmægler.Parameters.AddWithValue("@Postnummer", ejendomsmægler.Postnummer);

            try
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                conn.Open();

                Transactions.BeginRepeatableReadTransaction(conn);
                commandEjendomsmægler.ExecuteNonQuery();

                if (!Transactions.Commit(conn))
                    Transactions.Rollback(conn);

            }

            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }

            finally
            {
                if (conn != null)
                    conn.Close();
            }
        }
        #endregion

        #region Hent Ejendomsmægler
        public static EjendomsmæglerBLL HentEjendomsmægler(EjendomsmæglerBLL ejendomsmægler) //Find/hent ejendomsmægler
        {
            //Connection string
            ConnectionSingleton s1 = ConnectionSingleton.Instance();
            SqlConnection conn = s1.GetConnection();

            string sqlCommandEjendomsmægler = "SELECT * FROM Ejendomsmægler WHERE MæglerID = @MæglerID";

            /*string sqlCommandEjendomsmægler = "SELECT * FROM Ejendomsmægler WHERE " +
                "MæglerID LIKE @MæglerID OR " +
                "CPR LIKE @CPR OR " +
                "Telefon LIKE @Telefon OR " +
                "Email LIKE @Email OR " +
                "Fnavn LIKE @Fnavn OR " +
                "Enavn LIKE @Enavn OR " +
                "Vej LIKE @Vej OR " +
                "Postnummer LIKE @Postnummer ";
            */
            SqlCommand commandEjendomsmægler = new SqlCommand(sqlCommandEjendomsmægler, conn);

            commandEjendomsmægler.Parameters.AddWithValue("@MæglerID", ejendomsmægler.MæglerID);
            /*commandEjendomsmægler.Parameters.AddWithValue("@CPR", ejendomsmægler.CPR);
            commandEjendomsmægler.Parameters.AddWithValue("@Telefon", ejendomsmægler.Telefon);
            commandEjendomsmægler.Parameters.AddWithValue("@Email", ejendomsmægler.Email);
            commandEjendomsmægler.Parameters.AddWithValue("@Fnavn", ejendomsmægler.Fnavn);
            commandEjendomsmægler.Parameters.AddWithValue("@Enavn", ejendomsmægler.Enavn);
            commandEjendomsmægler.Parameters.AddWithValue("@Vej", ejendomsmægler.Vej);
            commandEjendomsmægler.Parameters.AddWithValue("@Postnummer", ejendomsmægler.Postnummer);
            */
            try
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                conn.Open();

                Transactions.BeginReadCommittedTransaction(conn);
                commandEjendomsmægler.ExecuteNonQuery();

                if (!Transactions.Commit(conn))
                    Transactions.Rollback(conn);

                using (SqlDataReader reader = commandEjendomsmægler.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        EjendomsmæglerBLL matchingejendomsmægler = new EjendomsmæglerBLL((int)reader["MæglerID"],
                            (long)reader["CPR"],
                            (int)reader["Telefon"],
                            reader["Email"].ToString(),
                            reader["Fnavn"].ToString(),
                            reader["enavn"].ToString(),
                            reader["Vej"].ToString(),
                            (int)reader["Postnummer"]);

                        return matchingejendomsmægler;
                    }
                }

            }

            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }

            finally
            {
                if (conn != null)
                    conn.Close();
            }

            return null;
        }
        #endregion

        #region Opdater Ejendomsmægler
        public void OpdaterEjendomsmægler(EjendomsmæglerBLL ejendomsmægler) //Opdater ejendomsmægler
        {
            //Connection string
            ConnectionSingleton s1 = ConnectionSingleton.Instance();
            SqlConnection conn = s1.GetConnection();

            //Tjekker om tekstboksene er tomme og undlader at opdaterer informationer for dem der er tomme
            string sqlCommandEjendomsmægler = "UPDATE Ejendomsmægler SET " +
                "CPR = IsNull(NullIf(@CPR, ''), CPR), " +
                "Telefon = IsNull(NullIf(@Telefon, ''), Telefon), " +
                "Email = IsNull(NullIf(@Email, ''), Email), " +
                "Fnavn = IsNull(NullIf(@Fnavn, ''), Fnavn), " +
                "Enavn = IsNull(NullIf(@Enavn, ''), Enavn), " +
                "Vej = IsNull(NullIf(@Vej, ''), Vej), " +
                "Postnummer = IsNull(NullIf(@Postnummer, ''), Postnummer) " +
                "WHERE MæglerID = @MæglerID";

            SqlCommand commandEjendomsmægler = new SqlCommand(sqlCommandEjendomsmægler, conn);

            commandEjendomsmægler.Parameters.AddWithValue("@CPR", ejendomsmægler.CPR);
            commandEjendomsmægler.Parameters.AddWithValue("@Telefon", ejendomsmægler.Telefon);
            commandEjendomsmægler.Parameters.AddWithValue("@Email", ejendomsmægler.Email);
            commandEjendomsmægler.Parameters.AddWithValue("@Fnavn", ejendomsmægler.Fnavn);
            commandEjendomsmægler.Parameters.AddWithValue("@Enavn", ejendomsmægler.Enavn);
            commandEjendomsmægler.Parameters.AddWithValue("@Vej", ejendomsmægler.Vej);
            commandEjendomsmægler.Parameters.AddWithValue("@Postnummer", ejendomsmægler.Postnummer);
            commandEjendomsmægler.Parameters.AddWithValue("@MæglerID", ejendomsmægler.MæglerID);

            try
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                conn.Open();

                Transactions.BeginReadCommittedTransaction(conn);
                commandEjendomsmægler.ExecuteNonQuery();

                if (!Transactions.Commit(conn))
                    Transactions.Rollback(conn);
            }

            catch (SqlException ex)
            {
                Transactions.Rollback(conn);
                throw; //Sender fejlen videre til EjendomsmæglerBLL
            }

            if (conn != null)
                conn.Close();
        }
        #endregion

        #region Slet Ejendomsmægler
        public void SletEjendomsmægler(EjendomsmæglerBLL ejendomsmægler) //Slet ejendomsmægler
        {
            //Connection string
            ConnectionSingleton s1 = ConnectionSingleton.Instance();
            SqlConnection conn = s1.GetConnection();

            string sqlCommandEjendomsmægler = $"DELETE FROM Ejendomsmægler WHERE MæglerID = @MæglerID";

            SqlCommand commandEjendomsmægler = new SqlCommand(sqlCommandEjendomsmægler, conn);

            commandEjendomsmægler.Parameters.AddWithValue("@MæglerID", ejendomsmægler.MæglerID);

            try
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                conn.Open();

                Transactions.BeginRepeatableReadTransaction(conn);
                commandEjendomsmægler.ExecuteNonQuery();

                if (!Transactions.Commit(conn))
                    Transactions.Rollback(conn);
            }

            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }

            finally
            {
                if (conn != null)
                    conn.Close();
            }
        }
        #endregion



        #region Check
        //Tjekker om mæglerid eksistere i databasen
        public static bool EjendomsmælgerExists(int mæglerid)
        {
            int userCount = 0;

            //SQL QUERY
            string sqlcommand = "SELECT COUNT (*) FROM Ejendomsmægler WHERE MæglerID like @MæglerID";

            //SQL COMMAND + PARAMETERS
            SqlCommand cmd = new SqlCommand(sqlcommand, conn);
            cmd.Parameters.AddWithValue("@MæglerID", mæglerid);

            try
            {
                //OPEN CONNECTION
                if (conn.State == System.Data.ConnectionState.Closed)
                    conn.Open();

                //BEGIN TRANSACTION
                Transactions.BeginReadCommittedTransaction(conn);

                userCount = (int)cmd.ExecuteScalar(); //ExecuteScarlar: Returner hvor mange linjer med dette ID der ligger i databasen - gemmes i usercount. Hvis usercount er større end 0 så er der linjer i databasen med dette ID

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

            if (userCount > 0) //Hvis userCount er større end 0 så findes ejendomsmægleren i databasen - og returnere derfor true (se evt. l. 365)
                return true;
            else
                return false;
        }

        //Tjekker om cpr allerede er tilknyttet en ejendomsmægler
        public static bool EjendomsmælgerCPRExists(long cpr)
        {
            int userCount = 0;

            //SQL QUERY
            string sqlcommand = "SELECT COUNT (*) FROM Ejendomsmægler WHERE CPR like @CPR";

            //SQL COMMAND + PARAMETERS
            SqlCommand cmd = new SqlCommand(sqlcommand, conn);
            cmd.Parameters.AddWithValue("@CPR", cpr);

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
    }
}