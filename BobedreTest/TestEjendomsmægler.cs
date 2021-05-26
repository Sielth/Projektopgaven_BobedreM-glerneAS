using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Projektopgaven_BobedreMaeglerneAS.PresentationLayer;

namespace BobedreTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            int antalTimer = 100;
            int salgspris = 1000000;

            string expected = "35000";

            BeregnSalærForm Salær = new BeregnSalærForm();

            //Act
            string actual = Salær.BeregnSalær(salgspris, antalTimer);

            //Assert
            Assert.AreEqual(expected, actual);

        }
    }
}
