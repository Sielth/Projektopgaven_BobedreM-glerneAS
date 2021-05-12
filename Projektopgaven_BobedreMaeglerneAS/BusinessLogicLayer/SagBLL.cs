using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektopgaven_BobedreMaeglerneAS.BusinessLogicLayer
{
    class SagBLL
    {
        public int SagsID { get; private set; }
        public string Status { get; private set; }
        public int BoligID { get; private set; }
        public int SælgerID { get; private set; }
        public int MæglerID { get; private set; }
    }
}
