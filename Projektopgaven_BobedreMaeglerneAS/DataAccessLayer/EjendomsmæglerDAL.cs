using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Projektopgaven_BobedreMæglerneAS;
using Projektopgaven_BobedreMaeglerneAS.BusinessLogicLayer;
using Projektopgaven_BobedreMaeglerneAS.DataAccessLayer;

namespace Projektopgaven_BobedreMæglerneAS
{
    class EjendomsmæglerDAL
    {

        private EjendomsmæglerBLL EjendomsmæglerBLL;

        public EjendomsmæglerDAL(EjendomsmæglerBLL ejendomsmæglerBLL)
        {
            this.EjendomsmæglerBLL = ejendomsmæglerBLL;
        }

        public void OpretEjendomsmægler(EjendomsmæglerBLL ejendomsmægler) //Opret ejendomsmælger
        {
            //Connection string
            ConnectionSingleton s1 = ConnectionSingleton.Instance();
            SqlConnection conn = s1.GetConnection();

            string sqlCommandEjendomsmægler = $"INSERT INTO Ejendomsmægler VALUES (@CPR, @Telefon, @Email, @Fnavn, @Enavn, @Vej, @Postnummer)";

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

                //if (conn.State == System.Data.ConnectionState.Closed)
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

        public EjendomsmæglerBLL FindEjendomsmægler(EjendomsmæglerBLL ejendomsmægler) //Find/hent ejendomsmægler
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
                            (int)reader["CPR"],
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


        //method to retrieve all EjendomsmæglerID to show in the ComboBox of SagUI
        //returns a List og EjendomsmæglerBLL
        public List<EjendomsmæglerBLL> HentEjendomsmæglerID_cbox()
        {
            //Connection string
            ConnectionSingleton s1 = ConnectionSingleton.Instance();
            SqlConnection conn = s1.GetConnection();

            //INITIALIZE List OF EjendomsmæglerBLL ejendomsmæglere
            List<EjendomsmæglerBLL> ejendomsmægler = new List<EjendomsmæglerBLL>();

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
                        ejendomsmægler.Add(new EjendomsmæglerBLL((int)reader["MæglerID"], reader["Fnavn"].ToString(), reader["Enavn"].ToString()));
                    }

                    //CLOSE READER
                    reader.Close();
                }

                //COMMIT OR ROLLBACK
                if (!Transactions.Commit(conn))
                    Transactions.Rollback(conn);

                //RETURN
                return ejendomsmægler;

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }

            //CLOSE CONNECTION
            if (conn.State == System.Data.ConnectionState.Open)
                conn.Close();

            return null;
        }



        public void OpdaterEjendomsmægler(EjendomsmæglerBLL ejendomsmægler) //Opdater ejendomsmægler
        {
            //Connection string
            ConnectionSingleton s1 = ConnectionSingleton.Instance();
            SqlConnection conn = s1.GetConnection();

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
                conn.Open();

                Transactions.BeginReadCommittedTransaction(conn);
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
    }
}