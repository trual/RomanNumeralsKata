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

            string x = "";

            while (x != "x")
            {
                Console.WriteLine("Please Enter an Integer");
                int val = Int32.Parse(Console.ReadLine());
                Console.WriteLine(ArabicToRomanNumeral.converter(val));

                x = Console.ReadLine();
            }

        }
    }
}
