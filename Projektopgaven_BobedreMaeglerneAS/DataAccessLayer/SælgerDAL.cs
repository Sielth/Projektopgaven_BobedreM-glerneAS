using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projektopgaven_BobedreMaeglerneAS.BusinessLogicLayer;
using System.Data.SqlClient;

namespace Projektopgaven_BobedreMaeglerneAS.DataAccessLayer
{
    class SælgerDAL
    {
        private SælgerBLL SælgerBLL;

        public SælgerDAL(SælgerBLL sælgerBLL)
        {
            this.SælgerBLL = sælgerBLL;
        }

        public void OpretSælger(SælgerBLL sælgerBLL)
        {
            string connstr = "Server=den1.mssql7.gear.host; Database=bobedredb; User ID=bobedredb; Password=Xw8gM?O3doQ_";
            SqlConnection conn = new SqlConnection(connstr);

            string sqlCommandSælger = "INSERT INTO Sælger VALUES (@CPR, @Telefon, @Email, @Fnavn, @Enavn, @Vej, @Postnummer)";

            SqlCommand cmdSælger = new SqlCommand(sqlCommandSælger, conn);
            cmdSælger.Parameters.AddWithValue("@CPR", sælgerBLL.CPR);
            cmdSælger.Parameters.AddWithValue("@Telefon", sælgerBLL.Telefon);
            cmdSælger.Parameters.AddWithValue("@Email", sælgerBLL.Email);
            cmdSælger.Parameters.AddWithValue("@Fnavn", sælgerBLL.Fnavn);
            cmdSælger.Parameters.AddWithValue("@Enavn", sælgerBLL.Enavn);
            cmdSælger.Parameters.AddWithValue("@Vej", sælgerBLL.Vej);
            cmdSælger.Parameters.AddWithValue("@Postnummer", sælgerBLL.Postnummer);

            try
            {
                conn.Open();
                cmdSælger.ExecuteNonQuery();

                //HentSælger
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                conn.Close();
            }
        }

        public SælgerBLL HentSælgerViaID(SælgerBLL sælgerBLL)
        {
            string connstr = "Server=den1.mssql7.gear.host; Database=bobedredb; User ID=bobedredb; Password=Xw8gM?O3doQ_";
            SqlConnection conn = new SqlConnection(connstr);

            string sqlCommandSælger = "SELECT * FROM Sælger WHERE " +
                "SælgerID = SælgerID";

            SqlCommand cmdSælger = new SqlCommand(sqlCommandSælger, conn);
            cmdSælger.Parameters.AddWithValue("@SælgerID", sælgerBLL.SælgerID);

            try
            {
                conn.Open();

                using (SqlDataReader reader = cmdSælger.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        SælgerBLL matchingsælger = new SælgerBLL((int)reader["SælgerID"],
                            (int)reader["CPR"],
                            (int)reader["Telefon"],
                            reader["Email"].ToString(),
                            reader["Fnavn"].ToString(),
                            reader["Enavn"].ToString(),
                            reader["Vej"].ToString(),
                            (int)reader["Postnummer"]);

                        return matchingsælger;
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return null;
        }

        public SælgerBLL HentSælger(SælgerBLL sælgerBLL)
        {
            string connstr = "Server=den1.mssql7.gear.host; Database=bobedredb; User ID=bobedredb; Password=Xw8gM?O3doQ_";
            SqlConnection conn = new SqlConnection(connstr);

            string sqlCommandSælger = "SELECT FROM Sælger WHERE " +
                "SælgerID LIKE @SælgerID OR " +
                "CPR LIKE @CPR AND " +
                "Telefon LIKE @Telefon AND " +
                "Email LIKE @Email AND " +
                "Fnavn LIKE @Fnavn AND " +
                "Enavn LIKE @Enavn AND " +
                "Vej LIKE @Vej AND " +
                "Postnummer LIKE @Postnummer";

            SqlCommand cmdSælger = new SqlCommand(sqlCommandSælger, conn);
            cmdSælger.Parameters.AddWithValue("@SælgerID", sælgerBLL.SælgerID);
            cmdSælger.Parameters.AddWithValue("@CPR", sælgerBLL.CPR);
            cmdSælger.Parameters.AddWithValue("@Telefon", sælgerBLL.Telefon);
            cmdSælger.Parameters.AddWithValue("@Email", sælgerBLL.Email);
            cmdSælger.Parameters.AddWithValue("@Fnavn", sælgerBLL.Fnavn);
            cmdSælger.Parameters.AddWithValue("@Enavn", sælgerBLL.Enavn);
            cmdSælger.Parameters.AddWithValue("@Vej", sælgerBLL.Vej);
            cmdSælger.Parameters.AddWithValue("@Postnummer", sælgerBLL.Postnummer);

            try
            {
                conn.Open();

                using (SqlDataReader reader = cmdSælger.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        SælgerBLL matchingsælger = new SælgerBLL((int)reader["SælgerID"],
                            (int)reader["CPR"],
                            (int)reader["Telefon"],
                            reader["Email"].ToString(),
                            reader["Fnavn"].ToString(),
                            reader["Enavn"].ToString(),
                            reader["Vej"].ToString(),
                            (int)reader["Postnummer"]);

                        return matchingsælger;
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return null;
        }

        public void OpdaterSælger(SælgerBLL sælgerBLL)
        {
            string connstr = "Server=den1.mssql7.gear.host; Database=bobedredb; User ID=bobedredb; Password=Xw8gM?O3doQ_";
            SqlConnection conn = new SqlConnection(connstr);

            string sqlCommandSælger = "UPDATE Sælger SET " +
                "CPR = IsNull(NullIf(@CPR, ''), CPR), " +
                "Telefon = IsNull(NullIf(@Telefon, ''), Telefon), " +
                "Email = IsNull(NullIf(@Email, ''), Email), " +
                "Fnavn = IsNull(NullIf(@Fnavn, ''), Fnavn), " +
                "Enavn = IsNull(NullIf(@Enavn, ''), Enavn), " +
                "Vej = IsNull(NullIf(@Vej, ''), Vej), " +
                "Postnummer = IsNull(NullId(@Postnummer, ''), Postnummer) " +
                "WHERE SælgerID = @SælgerID";

            SqlCommand cmdSælger = new SqlCommand(sqlCommandSælger, conn);
            cmdSælger.Parameters.AddWithValue("@SælgerID", sælgerBLL.SælgerID);
            cmdSælger.Parameters.AddWithValue("@CPR", sælgerBLL.CPR);
            cmdSælger.Parameters.AddWithValue("@Telefon", sælgerBLL.Telefon);
            cmdSælger.Parameters.AddWithValue("@Email", sælgerBLL.Email);
            cmdSælger.Parameters.AddWithValue("@Fnavn", sælgerBLL.Fnavn);
            cmdSælger.Parameters.AddWithValue("@Enavn", sælgerBLL.Enavn);
            cmdSælger.Parameters.AddWithValue("@Vej", sælgerBLL.Vej);
            cmdSælger.Parameters.AddWithValue("@Postnummer", sælgerBLL.Postnummer);

            try
            {
                conn.Open();
                cmdSælger.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public void SletSælger(SælgerBLL sælgerBLL)
        {
            string connstr = "Server=den1.mssql7.gear.host; Database=bobedredb; User ID=bobedredb; Password=Xw8gM?O3doQ_";
            SqlConnection conn = new SqlConnection(connstr);

            string sqlCommandSælger = "DELETE FROM Sælger WHERE SælgerID = @SælgerID";

            SqlCommand cmdSælger = new SqlCommand(sqlCommandSælger, conn);
            cmdSælger.Parameters.AddWithValue("@SælgerID", sælgerBLL.SælgerID);

            try
            {
                conn.Open();
                cmdSælger.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
