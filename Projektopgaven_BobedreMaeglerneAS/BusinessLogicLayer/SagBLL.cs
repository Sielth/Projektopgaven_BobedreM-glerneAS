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

        public SagBLL(int SagsID, string Status, int BoligID, int SælgerID, int MæglerID)
        {
            this.SagsID = SagsID;
            this.Status = Status;
            this.BoligID = BoligID;
            this.SælgerID = SælgerID;
            this.MæglerID = MæglerID;
        }

        public SagBLL(string Status, int BoligID, int SælgerID, int MæglerID)
        {
            this.Status = Status;
            this.BoligID = BoligID;
            this.SælgerID = SælgerID;
            this.MæglerID = MæglerID;
        }

        public SagBLL(int sagsID, string status)
        {
            this.SagsID = sagsID;
            this.Status = status;
        }

        public SagBLL(int SagsID)
        {
            this.SagsID = SagsID;
        }

        public override string ToString()
        {
            return $"{SagsID} - {Status}";
        }

        public static SagBLL FromString(string input)
        {
            string[] sag = input.Split(' ');

            return new SagBLL(Convert.ToInt32(sag[0]), sag[2]);
        }
    }
}
