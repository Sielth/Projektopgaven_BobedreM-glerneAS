using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projektopgaven_BobedreMaeglerneAS.DataAccessLayer;

namespace Projektopgaven_BobedreMaeglerneAS.BusinessLogicLayer
{
    public class WorksOnBLL
    {
        public int SagsID { get; private set; }
        public int TotHours { get; private set; }

        WorksOnDAL worksOnDAL;

        public WorksOnBLL(int sagsID, int totHours)
        {
            this.SagsID = sagsID;
            this.TotHours = totHours;
        }

        public WorksOnBLL() { }

        public void IndsætTimer(WorksOnBLL worksOn)
        {
            worksOnDAL = new WorksOnDAL();
            worksOnDAL.IndsætTimer(worksOn);
        }

        public static EjendomsmæglerBLL HentMægler(int sagsid, int handelid)
        {
            return WorksOnDAL.HentMægler(sagsid);
        }

        public static int HentSalgspris(string sagsid)
        {
            return WorksOnDAL.HentSalgspris(sagsid);
        }

        public static bool RecordExists(int sagsid)
        {
            return WorksOnDAL.RecordExists(sagsid);
        }

        public void Update(WorksOnBLL worksOn)
        {
            worksOnDAL = new WorksOnDAL();
            worksOnDAL.Update(worksOn);
        }

        public string BeregnSalær(int salgspris, int antalTimer)
        {
            int salær = antalTimer * 150;

            salær += salgspris / 100 * 2;

            return salær.ToString();
        }

    }
}
