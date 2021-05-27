using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektopgaven_BobedreMaeglerneAS.BusinessLogicLayer
{
    public class WorksOnBLL
    {
        public int HandelID {get; private set;}
        public int TotHours { get; private set; }

        public WorksOnBLL(int handelID, int totHours)
        {
            this.HandelID = handelID;
            this.TotHours = totHours;
        }

        public WorksOnBLL() { }
    }
}
