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
            if (v == 4) return "IV";
            if (v >= 1) return "I" + converter(v - 1); 


            throw new ArgumentOutOfRangeException("something bad happened we should feel bad");
        }
    }
}
