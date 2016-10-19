﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
        public void convert1ToI()
        {
            Assert.AreEqual("meow", ToRoman.converter(1));
        }

    }
}