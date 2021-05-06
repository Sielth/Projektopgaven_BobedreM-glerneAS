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
        public void OpdaterKøber(KøberBLL køber, SqlConnection conn) //Opdaterer køber
        {
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
            SqlCommand cmdKøber = new SqlCommand(sqlCommandKøber, conn);
            cmdKøber.Parameters.AddWithValue("@CPR", køber.CPR);
            cmdKøber.Parameters.AddWithValue("@Telefon", køber.Telefon);
            cmdKøber.Parameters.AddWithValue("@Email", køber.Email);
            cmdKøber.Parameters.AddWithValue("@Fnavn", køber.Fnavn);
            cmdKøber.Parameters.AddWithValue("@Enavn", køber.Enavn);
            cmdKøber.Parameters.AddWithValue("@Vej", køber.Vej);
            cmdKøber.Parameters.AddWithValue("@Postnummer", køber.Postnummer);
        }
        public void OpretKøber(KøberBLL køber, SqlConnection conn) //Opretter køber
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
        }
        public void SletKøber(KøberBLL køber, SqlConnection conn) //Sletter køber
        {
            string sqlCommandKøber = "DELETE FROM Køber WHERE (@KøberID)";
            SqlCommand cmdKøber = new SqlCommand(sqlCommandKøber, conn);
            cmdKøber.Parameters.AddWithValue("@KøberID", køber.KøberID);
        }
    }
}
