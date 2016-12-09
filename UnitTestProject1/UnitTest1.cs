using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestUeben;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        TestContext tsc;
        public TestContext TestContext
        {
            get { return tsc; }
            set { tsc = value; }
        }

        [TestMethod]
        public void TestMethod1()
        {
            Date d = new Date();
            Assert.AreEqual(1600, d.Year);
        }
        [TestMethod, ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestKonstruktor()
        {
            Date d = new Date(2015, 2, 29);
        }

        public void TestMethod2()
        {
            Date d = new Date();
            d.Year = 1500;
         }
        /*[TestMethod]
                [DeploymentItem("XMLFile2.xml")]
                [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
                    "|DataDirectory|\\..\\..\\..\\XMLFile2.xml",
                    "TestLeapYear",DataAccessMethod.Sequential)]*/
        [TestMethod]
        [DeploymentItem("XMLFile2.xml")]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML",
"|DataDirectory|\\..\\..\\..\\XMLFile2.xml", "TestLeapYear",
DataAccessMethod.Sequential)]

        public void TestIsLeapYear()
        {
            int year = Convert.ToInt32(TestContext.DataRow["Year"]);
            bool expected = Convert.ToBoolean(TestContext.DataRow["Expected"]);
            bool actual = Date.IsLeapYear(year);
            Assert.AreEqual(expected, actual);


        }
    }
}
