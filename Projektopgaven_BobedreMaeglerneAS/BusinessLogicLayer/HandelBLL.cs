using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Projektopgaven_BobedreMaeglerneAS.DataAccessLayer;

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

        public override string ToString()
        {
            return HandelID.ToString();
        }

        public static HandelBLL FromString(string input)
        {
            string[] handel = input.Split(' ');

            return new HandelBLL(Convert.ToInt32(handel[0]));
        }

        public void OpretHandel(HandelBLL handel)
        {
            HandelDAL handelDAL = new HandelDAL();
            handelDAL.OpretHandel(handel);
        }

        public static HandelBLL FindHandelViaID(HandelBLL handelToFind)
        {
            return HandelDAL.FindHandelViaID(handelToFind);
        }

        public void OpdaterHandel(HandelBLL handel)
        {
            HandelDAL handelDAL = new HandelDAL();
            handelDAL.OpdaterHandel(handel);
        }

        public void SletHandel(HandelBLL handel)
        {
            HandelDAL handelDAL = new HandelDAL();
            handelDAL.SletHandel(handel);
        }

        public static bool HandelExists(int sagsid)
        {
            return HandelDAL.HandelExists(sagsid);
        }

        public static HandelBLL FindHandel(HandelBLL handel)
        {
            return HandelDAL.FindHandel(handel);
        }

        //Methods go here
        /*public void StatsToText()
        {
            //DateTime salgsdato;
            //int price;
            //string broker;
            //string city;
            HandelDAL HandelDAL = new HandelDAL();
            List<HandelBLL> statistik = new List<HandelBLL>();
            //statistik = HandelDAL.SoldProperties();

            try
            {
                StreamWriter sw = new StreamWriter(@"Resources/");
                sw.WriteLine("\t Tidsperiode");
                sw.WriteLine("By\t Bolig solgt\t Pris\t Ejendomsmægler");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }*/
    }
}