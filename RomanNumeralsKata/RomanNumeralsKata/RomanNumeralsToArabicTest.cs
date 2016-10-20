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

        [TestMethod()]
        public void convertIVto4()
        {
            Assert.AreEqual(4, ToArabic.converter("IV"));
        }

        [TestMethod()]
        public void convertIXto9()
        {
            Assert.AreEqual(9, ToArabic.converter("IX"));
        }

        [TestMethod()]
        public void convertXLVIIIto48()
        {
            Assert.AreEqual(48, ToArabic.converter("XLVIII"));
        }


        [TestMethod()]
        public void convert400and444and475()
        {
            Assert.AreEqual(400, ToArabic.converter("CD"));
            Assert.AreEqual(444, ToArabic.converter("CDXLIV"));
            Assert.AreEqual(475, ToArabic.converter("CDLXXV"));
        }

        [TestMethod()]
        public void convert500and555and575()
        {
            Assert.AreEqual(500, ToArabic.converter("D"));
            Assert.AreEqual(555, ToArabic.converter("DLV"));
            Assert.AreEqual(575, ToArabic.converter("DLXXV"));
        }

        [TestMethod()]
        public void convert900and955and1575()
        {
            Assert.AreEqual(900, ToArabic.converter("CM"));
            Assert.AreEqual(955, ToArabic.converter("CMLV"));
            Assert.AreEqual(1575, ToArabic.converter("MDLXXV"));
        }
    }
}
