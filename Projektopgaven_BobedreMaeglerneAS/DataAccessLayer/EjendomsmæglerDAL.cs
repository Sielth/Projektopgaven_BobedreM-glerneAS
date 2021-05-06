using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Projektopgaven_BobedreMæglerneAS;
using Projektopgaven_BobedreMaeglerneAS.BusinessLogicLayer;

namespace Projektopgaven_BobedreMæglerneAS
{
    class EjendomsmæglerDAL
    {
        
        private EjendomsmæglerBLL EjendomsmæglerBLL;

        public EjendomsmæglerDAL(EjendomsmæglerBLL ejendomsmæglerBLL)
        {
            this.EjendomsmæglerBLL = ejendomsmæglerBLL;
        }



        public void OpretEjendomsmægler(EjendomsmæglerBLL ejendomsmægler)
        {
            //Connection string
            string strconn = "Server=den1.mssql7.gear.host; Database=bobedredb; User ID=bobedredb; Password=Xw8gM?O3doQ_";
            SqlConnection conn = new SqlConnection(strconn);

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
                conn.Open();
                commandEjendomsmægler.ExecuteNonQuery();
            }

            catch(SqlException ex)
            {
                Console.WriteLine(ex);
            }

            finally
            {
                conn.Close();
            }
        }

        public EjendomsmæglerBLL FindEjendomsmægler(EjendomsmæglerBLL ejendomsmægler)
        {
            //Connection string
            string strconn = "Server=den1.mssql7.gear.host; Database=bobedredb; User ID=bobedredb; Password=Xw8gM?O3doQ_";
            SqlConnection conn = new SqlConnection(strconn);

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
                conn.Close();
            }

            return null;
        }

        public void OpdaterEjendomsmægler(EjendomsmæglerBLL ejendomsmægler)
        {
            //Connection string
            string strconn = "Server=den1.mssql7.gear.host; Database=bobedredb; User ID=bobedredb; Password=Xw8gM?O3doQ_";
            SqlConnection conn = new SqlConnection(strconn);

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
                commandEjendomsmægler.ExecuteNonQuery();
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

        public void SletEjendomsmægler(EjendomsmæglerBLL ejendomsmægler)
        {
            //Connection string
            string strconn = "Server=den1.mssql7.gear.host; Database=bobedredb; User ID=bobedredb; Password=Xw8gM?O3doQ_";
            SqlConnection conn = new SqlConnection(strconn);

            string sqlCommandEjendomsmægler = $"DELETE FROM Ejendomsmægler WHERE MæglerID = @MæglerID";

            SqlCommand commandEjendomsmægler = new SqlCommand(sqlCommandEjendomsmægler, conn);

            commandEjendomsmægler.Parameters.AddWithValue("@MæglerID", ejendomsmægler.MæglerID);

            try
            {
                conn.Open();
                commandEjendomsmægler.ExecuteNonQuery();
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
    }
}