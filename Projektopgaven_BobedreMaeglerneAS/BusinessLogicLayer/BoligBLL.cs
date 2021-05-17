using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Projektopgaven_BobedreMæglerneAS
{
    class BoligBLL
    {
        public int BoligID { get; private set; }
        public string Vej { get; private set; }
        public int Postnummer { get; private set; }
        public string Type { get; private set; }
        public int Værelser { get; private set; }
        public int Etager { get; private set; }
        public int Kvadratmeter { get; private set; }
        public int Udbudspris { get; private set; }
        public bool Have { get; private set; }
        public DateTime Bygningsår { get; private set; }
        public DateTime RenoveringsÅr { get; private set; }

        public BoligBLL(int boligid, string vej, int postnummer, string type, int værelser, int etager, int kvadratmeter, bool have, DateTime bygningsår, DateTime renoveringsår)
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

        public BoligBLL(int boligid, string vej, int postnummer)
        {
            this.BoligID = boligid;
            this.Vej = vej;
            this.Postnummer = postnummer;
        }

        public BoligBLL(int boligid)
        {
            this.BoligID = boligid;
        }

        public BoligBLL() { }

        public override string ToString()
        {
            return $"{BoligID} - {Vej} - {Postnummer}";
        }

        private int CalculateUdbudsPris()
        {
            return 0;
        }
    }
}