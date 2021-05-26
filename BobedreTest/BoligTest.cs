using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Projektopgaven_BobedreMæglerneAS;
using Projektopgaven_BobedreMaeglerneAS.PresentationLayer;

namespace BobedreTest
{
    [TestClass]
    class BoligTest
    {
        [TestMethod]
        public void CalculateUdbudsprisTest()
        {
            //Arrange
            BoligBLL bolig = new BoligBLL(1, "Bethaniavej 2", 7300, "Lejlighed", 3, 1, 45, false, new DateTime(1955, 1, 1), new DateTime(2017, 1, 1));

            int expected = 382100;

            //Act
            bolig.CalculateUdbudsPris();

            //Assert
            int actual = bolig.Udbudspris;

            Assert.AreEqual(expected, actual, 0.001, "Price not calculated correctly");
        }

        [TestMethod]
        public void CalculateSalær()
        {
            int salgspris = 382100;
            int antaltimer = 12;

            string expected = "9422";

            BeregnSalærForm f1 = new BeregnSalærForm();
            string actual = f1.BeregnSalær(salgspris, antaltimer);

            Assert.AreEqual(expected, actual);

        }
    }
}
