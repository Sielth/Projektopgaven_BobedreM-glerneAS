using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Projektopgaven_BobedreMæglerneAS;

namespace BobedreTest
{
    [TestClass]
    public class TestBolig1
    {
        [TestMethod]
        public void TestCalculateUdbudspris()
        {
            //Arrange
            BoligBLL bolig = new BoligBLL(1, "Bethaniavej 2", 7300, "Lejlighed", 3, 1, 45, false, new DateTime(1955, 1, 1), new DateTime(2017, 1, 1));

            int expected = 382100;

            //Act
            int actual = bolig.CalculateUdbudsPris();

            //Assert
            Assert.AreEqual(expected, actual, 0.001, "Price not calculated correctly");
        }
    }
}
