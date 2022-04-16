using Microsoft.VisualStudio.TestTools.UnitTesting;
using Services;
using System;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(true, Authentification.Login("admin", "admin"));
        }

    }
}
