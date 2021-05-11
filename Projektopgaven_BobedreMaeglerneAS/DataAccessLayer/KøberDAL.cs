using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Projektopgaven_BobedreMaeglerneAS.BusinessLogicLayer;

namespace Projektopgaven_BobedreMaeglerneAS.DataAccessLayer
{
    class KøberDAL
    {
        private KøberBLL KøberBLL;

        public KøberDAL(KøberBLL køberBLL)
        {
            this.KøberBLL = køberBLL;
        }
        public void OpdaterKøber(KøberBLL køber) //Opdaterer køber
        {
            //Connection string
            string strconn = "Server=den1.mssql7.gear.host; Database=bobedredb; User ID=bobedredb; Password=Xw8gM?O3doQ_";
            SqlConnection conn = new SqlConnection(strconn);

            //ConnectionSingleton s1 = ConnectionSingleton.Instance();

            //Tjekker om tekstboxe var tomme og undlader at opdaterer informationer for dem der er tomme
            string sqlCommandKøber = "UPDATE Køber SET" +
                "CPR = IsNull(NullIf(@CPR, ''), CPR)," +
                "Telefon = IsNull(NullIf(@Telefon, ''), Telefon)," +
                "Email = IsNull(NullIf(@Email, ''), Email)," +
                "Fnavn = IsNull(NullIf(@Fnavn, ''), Fnavn)," +
                "Enavn = IsNull(NullIf(@Enavn, ''), Enavn)," +
                "Vej = IsNull(NullIf(@Vej, ''), Vej)," +
                "Postnummer = IsNull(NullIf(@Postnummer, ''), Postnummer)," +
                "WHERE KøberID = @KøberID";
            //Sender input til database for at opdatere
            SqlCommand cmdKøber = new SqlCommand(sqlCommandKøber);
            cmdKøber.Parameters.AddWithValue("@CPR", køber.CPR);
            cmdKøber.Parameters.AddWithValue("@Telefon", køber.Telefon);
            cmdKøber.Parameters.AddWithValue("@Email", køber.Email);
            cmdKøber.Parameters.AddWithValue("@Fnavn", køber.Fnavn);
            cmdKøber.Parameters.AddWithValue("@Enavn", køber.Enavn);
            cmdKøber.Parameters.AddWithValue("@Vej", køber.Vej);
            cmdKøber.Parameters.AddWithValue("@Postnummer", køber.Postnummer);
            try
            {
                conn.Open();
                cmdKøber.ExecuteNonQuery();
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
        public void OpretKøber(KøberBLL køber) //Opretter køber
        {
            //Connection string
            string strconn = "Server=den1.mssql7.gear.host; Database=bobedredb; User ID=bobedredb; Password=Xw8gM?O3doQ_";
            SqlConnection conn = new SqlConnection(strconn);

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
                conn.Open();
                cmdKøber.ExecuteNonQuery();
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
        public void SletKøber(KøberBLL køber) //Sletter køber
        {
            //Connection string
            string strconn = "Server=den1.mssql7.gear.host; Database=bobedredb; User ID=bobedredb; Password=Xw8gM?O3doQ_";
            SqlConnection conn = new SqlConnection(strconn);

            string sqlCommandKøber = "DELETE FROM Køber WHERE (@KøberID)";
            SqlCommand cmdKøber = new SqlCommand(sqlCommandKøber, conn);
            cmdKøber.Parameters.AddWithValue("@KøberID", køber.KøberID);
            try
            {
                conn.Open();
                cmdKøber.ExecuteNonQuery();
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
        public KøberBLL FindKøber(KøberBLL køber)
        {
            //Connection string
            string strconn = "Server=den1.mssql7.gear.host; Database=bobedredb; User ID=bobedredb; Password=Xw8gM?O3doQ_";
            SqlConnection conn = new SqlConnection(strconn);

            string sqlCommandKøber = "SELECT * FROM Sælger WHERE SælgerID = @SæglerID";

            SqlCommand commandKøber = new SqlCommand(sqlCommandKøber, conn);

            commandKøber.Parameters.AddWithValue("@KøberID", køber.KøberID);
            try
            {
                conn.Open();

                using (SqlDataReader reader = commandKøber.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        KøberBLL matchingkøber = new KøberBLL((int)reader["KøberID"],
                            reader["Vej"].ToString(),
                            (int)reader["Postnummer"],
                            (int)reader["CPR"],
                            reader["Fnavn"].ToString(),
                            reader["Enavn"].ToString(),
                            reader["Email"].ToString(),
                            (int)reader["Telefon"]);

                        return matchingkøber;
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
    }
}