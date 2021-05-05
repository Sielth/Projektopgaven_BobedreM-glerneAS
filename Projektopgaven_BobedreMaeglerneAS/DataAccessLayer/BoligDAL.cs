using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Projektopgaven_BobedreMæglerneAS;

namespace Projektopgaven_BobedreMaeglerneAS.DataAccessLayer
{
    class BoligDAL
    {
        private BoligBLL BoligBLL;

        public BoligDAL(BoligBLL boligBLL)
        {
            this.BoligBLL = boligBLL;
        }

        public void OpretBolig(BoligBLL bolig)
        {
            string connstr = "Server=den1.mssql7.gear.host; Database=bobedredb; User ID=bobedredb; Password=Xw8gM?O3doQ_";
            SqlConnection conn = new SqlConnection(connstr);

            string sqlCommandBolig = "INSERT INTO Bolig VALUES (@Vej, @Postnummer, @Type, @Værelser, @Etager, @Kvadratmeter, @Udbudspris, @HaveFlag, @Bygningsår, @RenoveringsÅr)";

            SqlCommand cmdBolig = new SqlCommand(sqlCommandBolig, conn);
            cmdBolig.Parameters.AddWithValue("@Vej", bolig.Vej);
            cmdBolig.Parameters.AddWithValue("@Postnummer", bolig.Postnummer);
            cmdBolig.Parameters.AddWithValue("@Type", bolig.Type);
            cmdBolig.Parameters.AddWithValue("@Værelser", bolig.Værelser);
            cmdBolig.Parameters.AddWithValue("@Etager", bolig.Etager);
            cmdBolig.Parameters.AddWithValue("@Kvadratmeter", bolig.Kvadratmeter);
            cmdBolig.Parameters.AddWithValue("@Udbudspris", bolig.Udbudspris);
            cmdBolig.Parameters.AddWithValue("@HaveFlag", bolig.Have);
            cmdBolig.Parameters.AddWithValue("@Bygningsår", bolig.Bygningsår);
            cmdBolig.Parameters.AddWithValue("@RenoveringsÅr", bolig.RenoveringsÅr);

            try
            {
                conn.Open();
                cmdBolig.ExecuteNonQuery();

                HentBolig(bolig);
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

        public BoligBLL HentBolig(BoligBLL bolig)
        {
            string connstr = "Server=den1.mssql7.gear.host; Database=bobedredb; User ID=bobedredb; Password=Xw8gM?O3doQ_";
            SqlConnection conn = new SqlConnection(connstr);

            string sqlCommanBolig = "SELECT * FROM Bolig WHERE " +
                "BoligID LIKE @BoligID OR " +
                "Vej Like @Vej OR " +
                "Postnummer LIKE @Postnummer OR " +
                "Type LIKE @Type OR " +
                "Værelser LIKE @Værelser OR " +
                "Etager LIKE @Etager OR " +
                "Kvadratmeter LIKE @Kvadratmeter OR " +
                "Udbudspris <= @Udbudspris OR " +
                "HaveFlag LIKE @HaveFlag OR " +
                "Bygningsår LIKE @Bygningsår OR " +
                "RenoveringsÅr LIKE @RenoveringsÅr ";

            SqlCommand cmdBolig = new SqlCommand(sqlCommanBolig, conn);
            cmdBolig.Parameters.AddWithValue("@BoligID", bolig.BoligID);
            cmdBolig.Parameters.AddWithValue("@Vej", bolig.Vej);
            cmdBolig.Parameters.AddWithValue("@Postnummer", bolig.Postnummer);
            cmdBolig.Parameters.AddWithValue("@Type", bolig.Type);
            cmdBolig.Parameters.AddWithValue("@Værelser", bolig.Værelser);
            cmdBolig.Parameters.AddWithValue("@Etager", bolig.Etager);
            cmdBolig.Parameters.AddWithValue("@Kvadratmeter", bolig.Kvadratmeter);
            cmdBolig.Parameters.AddWithValue("@Udbudspris", bolig.Udbudspris);
            cmdBolig.Parameters.AddWithValue("@HaveFlag", bolig.Have);
            cmdBolig.Parameters.AddWithValue("@Bygningsår", bolig.Bygningsår);
            cmdBolig.Parameters.AddWithValue("@RenoveringsÅr", bolig.RenoveringsÅr);

            try
            {
                conn.Open();

                using (SqlDataReader reader = cmdBolig.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        BoligBLL matchingbolig = new BoligBLL((int)reader["BoligID"],
                            reader["Vej"].ToString(),
                            (int)reader["Postnummer"],
                            reader["Type"].ToString(),
                            (int)reader["Værelser"],
                            (int)reader["Etager"],
                            (int)reader["Kvadratmeter"],
                            (int)reader["HaveFlag"],
                            (int)reader["Bygningsår"],
                            (int)reader["RenoveringsÅr"]);

                        return matchingbolig;
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

        public void OpdaterBolig(BoligBLL bolig, SqlConnection conn)
        {
            string sqlCommandBolig = "UPDATE Bolig SET" +
                "Vej = IsNull(NullIf(@Vej, ''), Vej)," +
                "Postnummer = IsNull(NullIf(@Postnummer, ''), Postnummer)," +
                "Type = IsNull(NullIf(@Type, ''), Type)," +
                "Værelser = IsNull(NullIf(@Værelser, ''), Værelser)," +
                "Etager = IsNull(NullIf(@Etager, ''), Etager)," +
                "Kvadratmeter = IsNull(NullIf(@Kvadratmeter, ''), Kvadratmeter)," +
                "Udbudspris = IsNull(NullIf(@Udbudspris, ''), Udbudspris)," +
                "HaveFlag = IsNull(NullIf(@HaveFlag, ''), HaveFlag)," +
                "Bygningsår = IsNull(NullIf(@Bygningsår, ''), Bygningsår)," +
                "RenoveringsÅr = IsNull(NullIf(@RenoveringsÅr, ''), RenoveringsÅr)" +
                "WHERE BoligID = @BoligID";

            SqlCommand cmdBolig = new SqlCommand(sqlCommandBolig, conn);
            cmdBolig.Parameters.AddWithValue("@Vej", bolig.Vej);
            cmdBolig.Parameters.AddWithValue("@Postnummer", bolig.Postnummer);
            cmdBolig.Parameters.AddWithValue("@Type", bolig.Type);
            cmdBolig.Parameters.AddWithValue("@Værelser", bolig.Værelser);
            cmdBolig.Parameters.AddWithValue("@Etager", bolig.Etager);
            cmdBolig.Parameters.AddWithValue("@Kvadratmeter", bolig.Kvadratmeter);
            cmdBolig.Parameters.AddWithValue("@Udbudspris", bolig.Udbudspris);
            cmdBolig.Parameters.AddWithValue("@HaveFlag", bolig.Have);
            cmdBolig.Parameters.AddWithValue("@Bygningsår", bolig.Bygningsår);
            cmdBolig.Parameters.AddWithValue("@RenoveringsÅr", bolig.RenoveringsÅr);
            cmdBolig.Parameters.AddWithValue("@BoligID", bolig.BoligID);
        }

        public void SletBolig(BoligBLL bolig, SqlConnection conn)
        {
            string sqlCommandBolig = "DELETE FROM Bolig WHERE BoligID = @BoligID";

            SqlCommand cmdBolig = new SqlCommand(sqlCommandBolig, conn);
        }
    }
}
