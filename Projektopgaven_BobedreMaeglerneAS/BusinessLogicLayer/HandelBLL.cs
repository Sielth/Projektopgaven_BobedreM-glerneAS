using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektopgaven_BobedreMaeglerneAS.BusinessLogicLayer
{
    class HandelBLL
    {
        public int HandelID { get; private set; }
        public DateTime Handelsdato { get; private set; }
        public int Salgspris { get; private set; }
        public int SagsID { get; private set; }
        public int KøberID { get; private set; }

        public HandelBLL(int HandelID, DateTime Handelsdato, int Salgspris, int SagsID, int KøberID)
        {
            this.HandelID = HandelID;
            this.Handelsdato = Handelsdato;
            this.Salgspris = Salgspris;
            this.SagsID = SagsID;
            this.KøberID = KøberID;
        }
        public HandelBLL(int handelID)
        {
            this.HandelID = handelID;
        }
    }
}