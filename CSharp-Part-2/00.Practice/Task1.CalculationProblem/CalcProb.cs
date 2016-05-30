using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationProblem
{
    class CalcProb
    {
        static void Main()
        {
            string[] codes = Console.ReadLine().Split(' ');
            int sumDecimal = 0;
            for (int i = 0; i < codes.Length; i++)
            {
                int number = ConvertFrom23Base(codes[i]);
                sumDecimal += number;
            }
            string sum23 = ConvertTo23FromDecimal(sumDecimal, 23);
            Console.WriteLine("{0} = {1}", sum23, sumDecimal);
        }

        private static string ConvertTo23FromDecimal(int n, int bs)
        {
            char[] digits = "abcdefghijklmnopqrstuvw".ToCharArray();
            string hex = string.Empty;
            while (n > 0)
            {
                string digit = string.Empty;
                int value = 0;
                if (n < bs)
                {
                    value = n;
                }
                else
                {
                    value = n % bs;
                }
                digit = digits[value].ToString();
                hex = digit + hex;
                n = n / bs;
            }
            return hex;
        }

        private static int ConvertFrom23Base(string vr)
        {
            string v = RevString(vr);
            char[] digits = "abcdefghijklmnopqrstuvw".ToCharArray();
            int number = 0;
            int mul = 1;
            int digit = 0;
            for (int i = 0; i < v.Length; i++)
            {
                for (int j = 0; j < digits.Length; j++)
                {
                    if (v[i] == digits[j])
                    {
                        digit = j;
                        break;
                    }
                }
                number += digit * mul;
                mul *= 23;
            }
            return number;
        }

        private static string RevString(string vr)
        {
            string v = string.Empty;
            for (int i = vr.Length - 1; i >= 0 ; i--)
            {
                v += vr[i];
            }
            return v;
        }
    }
}
