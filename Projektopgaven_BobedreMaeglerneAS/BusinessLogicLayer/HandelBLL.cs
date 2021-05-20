using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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

        public HandelBLL() { }
        //Methods go here
        public void StatsToText()
        {
            //DateTime salgsdato;
            int price;
            string broker;
            string city;
            try
            {
                StreamWriter sw = new StreamWriter(@"Resources/");
                sw.WriteLine("\t Tidsperiode");
                sw.WriteLine("By\t Bolig solgt\t Pris\t Ejendomsmægler");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}