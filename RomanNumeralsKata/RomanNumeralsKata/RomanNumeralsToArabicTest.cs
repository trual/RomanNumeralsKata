using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralsKata
{   
    [TestClass()]
    public class RomanNumeralsToArabicTest
    {
        RomanNumeralsToArabic ToArabic = new RomanNumeralsToArabic();

        [TestMethod()]
        public void convertIto1()
        {
            Assert.AreEqual(1, ToArabic.converter("I"));
        }

        [TestMethod()]
        public void convertIIto1()
        {
            Assert.AreEqual(2, ToArabic.converter("II"));
        }
    }
}
