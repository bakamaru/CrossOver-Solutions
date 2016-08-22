using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ZeroOne.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
           var retult= Program.Test(4);
            Assert.AreEqual(100,retult);
        }
    }
}
