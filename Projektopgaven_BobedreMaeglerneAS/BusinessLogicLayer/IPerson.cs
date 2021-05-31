using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektopgaven_BobedreMaeglerneAS.BusinessLogicLayer
{
    interface IPerson
    {
        long CPR { get; set; }
        int Telefon { get; set; }
        string Email { get; set; }
        string Fnavn { get; set; }
        string Enavn { get; set; }
        string Vej { get; set; }
        int Postnummer { get; set; }
    }
}