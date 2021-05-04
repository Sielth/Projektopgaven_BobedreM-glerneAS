using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Projektopgaven_BobedreMaeglerneAS
{
    class Køber
    {
        //Attributes
        string CPR; //Skift til at hente input fra textbox
        string Telefon; //Skift til at hente input fra textbox
        string Email; //Skift til at hente input fra textbox
        string Fnavn; //Skift til at hente input fra textbox
        string Enavn; //Skift til at hente input fra textbox
        string Vej; //Skift til at hente input fra textbox
        string Postnummer; //Skift til at hente input fra textbox
        int køberID;
        //Method goes here
        public bool isDigits(string input) //Tjekker om der kun er tal
        {
            foreach (char c in input)
            {
                if (!Char.IsDigit(c) /* && input.Length != 10 */)
                {
                    return false;
                }
            }
            return true;
        }
        public bool isLetters(string input) //Tjekker om der er bogstaver med mellemrum
        {
            foreach (char c in input)
            {
                if (!Char.IsLetter(c) && c != ' ')
                {
                    return false;
                }
            }
            return true;
        }
        public bool isLettersOrDigits(string input) //Tjekker om der kun er tal og bogstaver med mellemrum
        {
            foreach (char c in input)
            {
                if (!Char.IsLetterOrDigit(c) && c != ' ')
                {
                    return false;
                }
            }
            return true;
        }
        public void OpretKøber(Køber køber, SqlConnection conn) //Opretter køber
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
        public void SletKøber(Køber køber, SqlConnection conn) //Sletter køber
        {
            string sqlCommandKøber = "DELETE FROM Køber WHERE (@KøberID)";
            SqlCommand cmdKøber = new SqlCommand(sqlCommandKøber, conn);
            cmdKøber.Parameters.AddWithValue("@KøberID", køber.køberID);
        }
        public void OpdaterKøber(Køber køber, SqlConnection conn) //Opdaterer køber
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
        //Methods end
    }
}
