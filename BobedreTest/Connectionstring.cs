using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Projektopgaven_BobedreMaeglerneAS.BusinessLogicLayer;

namespace BobedreTest
{
    [TestClass]
    public class Connectionstring
    {
        [TestMethod]
        public void TestSingletonConnection()
        {
            ////creates a new instance of ConnectionSingleton via method Instance
            //private static ConnectionSingleton s1 = ConnectionSingleton.Instance();
            ////get the SqlConnection from ConnectionSingleton method GetConnection
            //private static SqlConnection conn = s1.GetConnection();
            //private static ConnectionSingleton s2 = ConnectionSingleton.Instance();
            //private static SqlConnection conn = s2.GetConnection();
            //Assert.AreEqual(s1, s2);
        }   
    }
}
