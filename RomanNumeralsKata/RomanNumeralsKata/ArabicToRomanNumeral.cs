using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralsKata
{
    class ArabicToRomanNumeral
    {

        public string converter(int v)
        {
            if (v < 1) return "";
            if (v >= 500) return "D" + converter(v - 500);
            if (v >= 400) return "CD" + converter(v - 400);
            if (v >= 100) return "C" + converter(v - 100);
            if (v >= 90) return "XC" + converter(v - 90);
            if (v >= 50) return "L" + converter(v - 50);
            if (v >= 40) return "XL" + converter(v - 40);
            if (v >= 10) return "X" + converter(v - 10);
            if (v == 9) return "IX";
            if (v >= 5) return "V" + converter(v - 5);
            if (v == 4) return "IV";
            if (v >= 1) return "I" + converter(v - 1); 


            throw new ArgumentOutOfRangeException("something bad happened we should feel bad");
        }
    }
}
