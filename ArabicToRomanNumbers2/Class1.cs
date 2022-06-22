using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace ArabicToRomanNumbers2
{
    class Class1
    {
        private string romanNum;

        public string IntToRoman(int input)
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
            
            foreach (int i in dict.Keys)
            {
                while (input >= i)
                {
                    this.romanNum += dict[i];
                    input -= i;
                }
            }
            this.Print();
            return this.romanNum;
        }
        public void Print()
        {
            Console.WriteLine("Римское число: " + this.romanNum);
        }
    }
}
