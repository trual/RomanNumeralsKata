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
    }
}
