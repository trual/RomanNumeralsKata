using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralsKata
{
    class RomanNumeralsToArabic
    {
        // going to need these
        private static Dictionary<char, int> RomanNumerals = new Dictionary<char, int>()
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

        public int converter(string str)
        {
            int number = 0;
            for (int i = 0; i < str.Length; i++)
            {
                number += RomanNumerals[str[i]];
            }


            return number;
        }
    }
}
