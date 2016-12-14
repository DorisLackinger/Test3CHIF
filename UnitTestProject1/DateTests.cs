using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestUeben;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestUeben.Tests {
    [TestClass()]
    public class DateTests {
        [TestMethod()]
        public void DayOfYear() {
            // arrange
            IDate date = new TestUeben.Fakes.StubIDate() {
                DayOfYearGet = () => { return 55; }
            };

            // act
            int erg = date.DayOfYear;

            // assert
            Assert.AreEqual(erg, 55);
        }

    }
}