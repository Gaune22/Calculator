using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testcalculator
{
    [TestClass]
    public class UnitTest1
    {
        public TestContext TestContext { get; set; }
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


        // Liên kết fiile csv với project
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @".\Data\DataTest.csv", "DataTest#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void DataTest()
        {
            int a, b, expected;
            a = int.Parse(TestContext.DataRow[0].ToString());
            b = int.Parse(TestContext.DataRow[1].ToString());
            expected = int.Parse(TestContext.DataRow[2].ToString());
            Calculation c = new Calculation(a, b);
            Assert.AreEqual(expected, c.Execute("/"));
        }
    }
}
