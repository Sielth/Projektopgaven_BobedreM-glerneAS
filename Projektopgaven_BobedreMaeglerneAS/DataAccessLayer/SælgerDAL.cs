using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projektopgaven_BobedreMaeglerneAS.BusinessLogicLayer;
using System.Data.SqlClient;
using System.Threading;
using System.Windows.Forms;

namespace Projektopgaven_BobedreMaeglerneAS.DataAccessLayer
{
    class SælgerDAL
    {
        private static ConnectionSingleton s1 = ConnectionSingleton.Instance(); //creates a new instance of ConnectionSingleton via method Instance
        private static SqlConnection conn = s1.GetConnection(); //get the SqlConnection from ConnectionSingleton method GetConnection

        private ComboBox output;

        public SælgerDAL() //SælgerDAL constructor - bruges i SælgerBLL
        {
        
        }

        #region Threads
        public SælgerDAL(ComboBox cBox)
        {
            output = cBox;
        }

        public delegate void DisplayDelegate(List<SælgerBLL> sælgere);

        private void DisplaySælgere(List<SælgerBLL> sælgere)
        {
            output.Items.Clear(); //tømer comboboksen

            foreach (SælgerBLL sælger in sælgere)
                output.Items.Add(sælger.ToString()); //tilføjer sælgere til comboboksen
        }

        public List<SælgerBLL> FetchSælger()
        {
            List<SælgerBLL> sælgere = new List<SælgerBLL>();

            using (var conn = new SqlConnection(s1.GetConnectionString())) //Disposenel connection - så en anden tråd kan komme ind i databasen
            {
                string sqlCommand = "SELECT * FROM Sælger";

                SqlCommand cmd = new SqlCommand(sqlCommand, conn);

                try
                {
                    //OPEN CONNECTION
                    if (conn.State == System.Data.ConnectionState.Closed)
                        conn.Open();

                    //BEGIN TRANSACTION
                    Transactions.BeginReadCommittedTransaction(conn);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            sælgere.Add(new SælgerBLL((int)reader["SælgerID"], reader["Fnavn"].ToString(), reader["Enavn"].ToString()));
                        }

                        if (reader != null)
                            reader.Close();
                    }

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
            return sælgere;
        }

        public void GenerateSælger()
        {
            while (true)
            { 
                if (!output.IsDisposed) //Tjekker at vi har en "output"
                {
                    ThreadStart start = new ThreadStart(() => FetchSælger());
                    Thread t1 = new Thread(start);

                    List<SælgerBLL> sælgere = FetchSælger();

                    try
                    {
                        //CHECK IF OUTPUT HANDLE HAS NOT BEEN CREATED
                        if (!output.IsHandleCreated) //Tjekker om der er en comboboks og ellers oprettes der en på næste linje
                            output.CreateControl(); //CREATES OUPUT CONTROL

                        //Delegate udfører metoden "DisplayEjendomsmægler"
                        output.Invoke(new DisplayDelegate(DisplaySælgere), new object[] { sælgere });
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                    Thread.Sleep(6000); //Tråden som kalder "GenerateEjendomsmægler" (i SagsUI l. 38) sættes til at sove
                }
            }
        }
        #endregion

        #region OpretSælger
        public void OpretSælger(SælgerBLL sælger)
        {
            string sqlCommandSælger = "INSERT INTO Sælger VALUES (@CPR, @Telefon, @Email, @Fnavn, @Enavn, @Vej, @Postnummer)";

            SqlCommand cmdSælger = new SqlCommand(sqlCommandSælger, conn);
            cmdSælger.Parameters.AddWithValue("@CPR", sælger.CPR);
            cmdSælger.Parameters.AddWithValue("@Telefon", sælger.Telefon);
            cmdSælger.Parameters.AddWithValue("@Email", sælger.Email);
            cmdSælger.Parameters.AddWithValue("@Fnavn", sælger.Fnavn);
            cmdSælger.Parameters.AddWithValue("@Enavn", sælger.Enavn);
            cmdSælger.Parameters.AddWithValue("@Vej", sælger.Vej);
            cmdSælger.Parameters.AddWithValue("@Postnummer", sælger.Postnummer);

            try
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                    conn.Open();

                Transactions.BeginRepeatableReadTransaction(conn);

                cmdSælger.ExecuteNonQuery();

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

        #region HentSælger
        public static SælgerBLL HentSælgerViaID(SælgerBLL sælgerToFind)
        {
            SælgerBLL matchingsælger = null;

            string sqlCommandSælger = "SELECT * FROM Sælger WHERE " +
                "SælgerID = @SælgerID";

            SqlCommand cmdSælger = new SqlCommand(sqlCommandSælger, conn);
            cmdSælger.Parameters.AddWithValue("@SælgerID", sælgerToFind.SælgerID);

            try
            {
                //OPEN CONNECTION
                if (conn.State == System.Data.ConnectionState.Closed)
                    conn.Open();

                //BEGIN TRANSACTION
                Transactions.BeginReadCommittedTransaction(conn);

                using (SqlDataReader reader = cmdSælger.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        matchingsælger = new SælgerBLL((int)reader["SælgerID"],
                            (long)reader["CPR"],
                            (int)reader["Telefon"],
                            reader["Email"].ToString(),
                            reader["Fnavn"].ToString(),
                            reader["Enavn"].ToString(),
                            reader["Vej"].ToString(),
                            (int)reader["Postnummer"]);
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

            //RETURN
            return matchingsælger;
        }

        public static SælgerBLL HentSælger(SælgerBLL sælgerToFind)
        {
            SælgerBLL matchingsælger = null;

            string sqlCommandSælger = "SELECT * FROM Sælger WHERE " +
                "SælgerID LIKE @SælgerID OR " +
                "CPR LIKE @CPR AND " +
                "Telefon LIKE @Telefon AND " +
                "Email LIKE @Email AND " +
                "Fnavn LIKE @Fnavn AND " +
                "Enavn LIKE @Enavn AND " +
                "Vej LIKE @Vej AND " +
                "Postnummer LIKE @Postnummer";

            SqlCommand cmdSælger = new SqlCommand(sqlCommandSælger, conn);
            cmdSælger.Parameters.AddWithValue("@SælgerID", sælgerToFind.SælgerID);
            cmdSælger.Parameters.AddWithValue("@CPR", sælgerToFind.CPR);
            cmdSælger.Parameters.AddWithValue("@Telefon", sælgerToFind.Telefon);
            cmdSælger.Parameters.AddWithValue("@Email", sælgerToFind.Email);
            cmdSælger.Parameters.AddWithValue("@Fnavn", sælgerToFind.Fnavn);
            cmdSælger.Parameters.AddWithValue("@Enavn", sælgerToFind.Enavn);
            cmdSælger.Parameters.AddWithValue("@Vej", sælgerToFind.Vej);
            cmdSælger.Parameters.AddWithValue("@Postnummer", sælgerToFind.Postnummer);

            try
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                    conn.Open();

                //BEGIN TRANSACTION
                Transactions.BeginReadCommittedTransaction(conn);

                using (SqlDataReader reader = cmdSælger.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        matchingsælger = new SælgerBLL((int)reader["SælgerID"],
                            (long)reader["CPR"],
                            (int)reader["Telefon"],
                            reader["Email"].ToString(),
                            reader["Fnavn"].ToString(),
                            reader["Enavn"].ToString(),
                            reader["Vej"].ToString(),
                            (int)reader["Postnummer"]);
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

            //RETURN
            return matchingsælger;
        }
        #endregion

        #region Opdater Sælger
        public void OpdaterSælger(SælgerBLL sælger)
        {
            string sqlCommandSælger = "UPDATE Sælger SET " +
                "CPR = IsNull(NullIf(@CPR, ''), CPR), " +
                "Telefon = IsNull(NullIf(@Telefon, ''), Telefon), " +
                "Email = IsNull(NullIf(@Email, ''), Email), " +
                "Fnavn = IsNull(NullIf(@Fnavn, ''), Fnavn), " +
                "Enavn = IsNull(NullIf(@Enavn, ''), Enavn), " +
                "Vej = IsNull(NullIf(@Vej, ''), Vej), " +
                "Postnummer = IsNull(NullIf(@Postnummer, ''), Postnummer) " +
                "WHERE SælgerID = @SælgerID";

            SqlCommand cmdSælger = new SqlCommand(sqlCommandSælger, conn);
            cmdSælger.Parameters.AddWithValue("@SælgerID", sælger.SælgerID);
            cmdSælger.Parameters.AddWithValue("@CPR", sælger.CPR);
            cmdSælger.Parameters.AddWithValue("@Telefon", sælger.Telefon);
            cmdSælger.Parameters.AddWithValue("@Email", sælger.Email);
            cmdSælger.Parameters.AddWithValue("@Fnavn", sælger.Fnavn);
            cmdSælger.Parameters.AddWithValue("@Enavn", sælger.Enavn);
            cmdSælger.Parameters.AddWithValue("@Vej", sælger.Vej);
            cmdSælger.Parameters.AddWithValue("@Postnummer", sælger.Postnummer);

            try
            {
                //OPEN CONNECTION
                if (conn.State == System.Data.ConnectionState.Closed)
                    conn.Open();

                //BEGIN TRANSACTION
                Transactions.BeginReadCommittedTransaction(conn);

                //EXECUTE QUERY
                cmdSælger.ExecuteNonQuery();

                //COMMIT OR ROLLBACK
                if (!Transactions.Commit(conn))
                    Transactions.Rollback(conn);
            }
            catch (SqlException ex)
            {
                Transactions.Rollback(conn);
                throw ex;
            }

            //CLOSE CONNECTION
            if (conn.State == System.Data.ConnectionState.Open)
                conn.Close();
        }
        #endregion

        #region Slet Sælger
        public void SletSælger(SælgerBLL sælger)
        {
            string sqlCommandSælger = "DELETE FROM Sælger WHERE SælgerID = @SælgerID";

            SqlCommand cmdSælger = new SqlCommand(sqlCommandSælger, conn);
            cmdSælger.Parameters.AddWithValue("@SælgerID", sælger.SælgerID);

            try
            {
                //OPEN CONNECTION
                if (conn.State == System.Data.ConnectionState.Closed)
                    conn.Open();

                //BEGIN TRANSACTION
                Transactions.BeginRepeatableReadTransaction(conn);

                //EXECUTE QUERY
                cmdSælger.ExecuteNonQuery();

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

        #region Check
        public static bool SælgerExists(int sælgerid)
        {
            int userCount = 0;

            //SQL QUERY
            string sqlcommand = "SELECT COUNT (*) FROM Sælger WHERE SælgerID like @SælgerID";

            //SQL COMMAND + PARAMETERS
            SqlCommand cmd = new SqlCommand(sqlcommand, conn);
            cmd.Parameters.AddWithValue("@SælgerID", sælgerid);

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

            if (userCount > 0)
                return true;
            else
                return false;
        }

        public static bool SælgerCPRExists(long cpr, int id)
        {
            int userCount = 0;

            //SQL QUERY
            string sqlcommand = "SELECT COUNT (*) FROM Sælger WHERE CPR like @CPR AND SælgerID = @SælgerID";

            //SQL COMMAND + PARAMETERS
            SqlCommand cmd = new SqlCommand(sqlcommand, conn);
            cmd.Parameters.AddWithValue("@CPR", cpr);
            cmd.Parameters.AddWithValue("@SælgerID", id);

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
