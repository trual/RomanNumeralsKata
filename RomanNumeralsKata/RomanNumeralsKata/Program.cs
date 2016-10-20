using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RomanNumeralsKata
{
    class Program
    {
        static void Main(string[] args)
        {

            ArabicToRomanNumeral ArabicToRomanNumeral = new ArabicToRomanNumeral();
            RomanNumeralsToArabic ToArabic = new RomanNumeralsToArabic();

            string x = "";

            while (x != "x")
            {
                Console.WriteLine("Please Enter an Integer or a Roman Numeral");
                string input = Console.ReadLine();
                int number;
                if (Int32.TryParse(input, out number))
                {
                    int val = number;
                    Console.WriteLine(ArabicToRomanNumeral.converter(val));
                }
                else
                {
                    Console.WriteLine(ToArabic.converter(input));
                }
                x = Console.ReadLine();
            }

        }
    }
}
