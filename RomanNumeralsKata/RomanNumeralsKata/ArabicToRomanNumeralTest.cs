using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralsKata
{
    [TestClass()]
    public class ArabicToRomanNumeralTest
    {

        ArabicToRomanNumeral ToRoman = new ArabicToRomanNumeral();

        [TestMethod()]
        public void convert0ToI()
        {
            Assert.AreEqual("", ToRoman.converter(0));
        }

        [TestMethod()]
        public void convert1ToI()
        {
            Assert.AreEqual("I", ToRoman.converter(1));
        }

        [TestMethod()]
        public void convert2and3()
        {
            Assert.AreEqual("II", ToRoman.converter(2));
            Assert.AreEqual("III", ToRoman.converter(3));
        }

        [TestMethod()]
        public void convert4()
        {
            Assert.AreEqual("IV", ToRoman.converter(4));
            
        }

        [TestMethod()]
        public void convert5and6and7and8()
        {
            Assert.AreEqual("V", ToRoman.converter(5));
            Assert.AreEqual("VI", ToRoman.converter(6));
            Assert.AreEqual("VII", ToRoman.converter(7));
            Assert.AreEqual("VIII", ToRoman.converter(8));


        }

        [TestMethod()]
        public void convert9()
        {
            Assert.AreEqual("IX", ToRoman.converter(9));

        }

        [TestMethod()]
        public void convert10and11and14 ()
        {
            Assert.AreEqual("X", ToRoman.converter(10));
            Assert.AreEqual("XI", ToRoman.converter(11));
            Assert.AreEqual("XIV", ToRoman.converter(14));
        

        }
        [TestMethod()]
        public void convert40and42and44and48and49()
        {
            Assert.AreEqual("XL", ToRoman.converter(40));
            Assert.AreEqual("XLII", ToRoman.converter(42));
            Assert.AreEqual("XLIV", ToRoman.converter(44));
            Assert.AreEqual("XLVIII", ToRoman.converter(48));
            Assert.AreEqual("XLIX", ToRoman.converter(49));

        }

        [TestMethod()]
        public void convert50a54a56a59a75()
        {
            Assert.AreEqual("L", ToRoman.converter(50));
            Assert.AreEqual("LIV", ToRoman.converter(54));
            Assert.AreEqual("LVI", ToRoman.converter(56));
            Assert.AreEqual("LIX", ToRoman.converter(59));
            Assert.AreEqual("LXXV", ToRoman.converter(75));

        }

        [TestMethod()]
        public void convert99and135()
        {
            Assert.AreEqual("XCIX", ToRoman.converter(99));
            Assert.AreEqual("CXXXV", ToRoman.converter(135));
            Assert.AreEqual("CXLVI", ToRoman.converter(146));
        }

        [TestMethod()]
        public void convert400and444and475()
        {
            Assert.AreEqual("CD", ToRoman.converter(400));
            Assert.AreEqual("CDXLIV", ToRoman.converter(444));
            Assert.AreEqual("CDLXXV", ToRoman.converter(475));
        }

        [TestMethod()]
        public void convert500and555and575()
        {
            Assert.AreEqual("D", ToRoman.converter(500));
            Assert.AreEqual("DLV", ToRoman.converter(555));
            Assert.AreEqual("DLXXV", ToRoman.converter(575));
        }

        [TestMethod()]
        public void convert900and955and1575()
        {
            Assert.AreEqual("CM", ToRoman.converter(900));
            Assert.AreEqual("CMLV", ToRoman.converter(955));
            Assert.AreEqual("MDLXXV", ToRoman.converter(1575));
        }


    }
}
