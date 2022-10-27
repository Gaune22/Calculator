using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testcalculator
{
    [TestClass]
    public class UnitTest1
    {
        Calculation cal;
       
        [TestInitialize]
        public void setUp()
        {
            this.cal = new Calculation(10, 5);
        }

        [TestMethod]
        public void TestCong()
        {
            Assert.AreEqual(15, cal.Execute("+"));
        }

        [TestMethod]
        public void TestTru()
        {
            Assert.AreEqual(5, cal.Execute("-"));
        }

        [TestMethod]
        public void TestNhan()
        {
            Assert.AreEqual(50, cal.Execute("*"));
        }

        [TestMethod]
        public void TestChia()
        {
            Assert.AreEqual(2, cal.Execute("/"));
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Testdivzero()
        {
            Calculation c = new Calculation(2, 0);
            c.Execute("/");
        }
    }
}
