using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Projektopgaven_BobedreMaeglerneAS.BusinessLogicLayer;

namespace BobedreTest
{
    [TestClass]
    public class TestSingleton
    {
        [TestMethod]
        public void TestSingleton_SameInstance()
        {
            //Arrange
            ConnectionSingleton s1 = ConnectionSingleton.Instance();
            ConnectionSingleton s2 = ConnectionSingleton.Instance();

            bool actual = false;
            bool expected = true;

            //Act
            if (s1 == s2)
                actual = true;

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
