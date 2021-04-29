using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Projektopgaven_BobedreMæglerneAS
{
    class Bolig
    {
        //HI IM ALESSIA AND I WANT THE PEACE IN THE WORLD
        private int BoligID;
        private string Vej;
        private int Postnummer;
        private string Type;
        private int Værelser;
        private int Etager;
        private int Kvadratmeter;
        private int Udbudspris;
        private bool Have;
        private int Bygningsår;
        private int RenoveringsÅr;

        public Bolig(int boligid, string vej, int postnummer, string type, int værelser, int etager, int kvadratmeter, bool have, int bygningsår, int renoveringsår)
        {
            this.BoligID = boligid;
            this.Vej = vej;
            this.Postnummer = postnummer;
            this.Type = type;
            this.Værelser = værelser;
            this.Etager = etager;
            this.Kvadratmeter = kvadratmeter;
            this.Udbudspris = CalculateUdbudsPris();
            this.Have = have;
            this.Bygningsår = bygningsår;
            this.RenoveringsÅr = renoveringsår;
        }

        public void OpretBolig(Bolig bolig, SqlConnection conn)
        {
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
        }

        public void HentBolig(Bolig bolig, SqlConnection conn)
        {
            string sqlCommanBolig = "SELECT * FROM Bolig WHERE BoligID = @BoligID";

            SqlCommand cmdBolig = new SqlCommand(sqlCommanBolig, conn);
            cmdBolig.Parameters.AddWithValue("@BoligID", bolig.BoligID);
        }

        public void OpdaterBolig(Bolig bolig, SqlConnection conn)
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

        public void SletBolig(Bolig bolig, SqlConnection conn)
        {
            string sqlCommandBolig = "DELETE FROM Bolig WHERE BoligID = @BoligID";

            SqlCommand cmdBolig = new SqlCommand(sqlCommandBolig, conn);
        }

        private int CalculateUdbudsPris()
        {
            return 0;
        }
    }
}
