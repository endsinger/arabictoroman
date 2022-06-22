using System;
using System.Collections.Generic;

namespace ArabicToRomanNumbers2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int input = Convert.ToInt32(Console.ReadLine());
                Class1 changeNumber = new Class1();
                changeNumber.IntToRoman(input);
            }
            catch
            {
                Console.WriteLine("Введены неверные символы");
            }
            Console.ReadKey();
        }
    }
}
