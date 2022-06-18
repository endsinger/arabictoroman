using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        
        {
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine(IntToRoman(input));
        }
        static string IntToRoman(int num)
        {
            Dictionary<int, string> dict = new Dictionary<int, string>
                {
                        { 1000, "M" },
                        { 900, "CM"},
                        { 500, "D" },
                        { 400, "CD" },
                        { 100, "C"},
                        { 90, "XC" },
                        { 50, "L" },
                        { 40, "XL" },
                        { 10, "X"},
                        { 9, "IX"},
                        { 5, "V" },
                        { 4,"IV"},
                        { 1, "I"},
            };
            string romanNum = "";
            foreach (int i in dict.Keys)
            {
                while (num >= i)
                {
                    romanNum += dict[i];
                    num -= i;
                }
            }
            return romanNum;
        }
    }
}