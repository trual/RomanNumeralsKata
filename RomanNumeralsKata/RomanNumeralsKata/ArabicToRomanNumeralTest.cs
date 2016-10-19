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

    }
}
