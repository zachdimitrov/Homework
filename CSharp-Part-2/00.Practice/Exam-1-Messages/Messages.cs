using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Exam_1_Messages
{
    class Messages
    {
        static void Main()
        {
            string first = Console.ReadLine();
            string op = Console.ReadLine();
            string second = Console.ReadLine();
            List<string> num1 = ExtractDigits(first);
            List<string> num2 = ExtractDigits(second);
            string decNum1 = ConvertToDecimal(num1);
            string decNum2 = ConvertToDecimal(num2);
            string sum = string.Empty;

            if (op == "+")
            {
                sum = Add(decNum1, decNum2);
            }
            else if (op == "-")
            {
                sum = Rem(decNum1, decNum2);
            }

            Console.WriteLine(SumToNumSysetm(sum));

            // Console.WriteLine(String.Join(", ", num1));
            // Console.WriteLine(decNum1);
            // Console.WriteLine(op);
            // Console.WriteLine(String.Join(", ", num2));
            // Console.WriteLine(decNum2);
            // Console.WriteLine(sum);
        }

        private static string SumToNumSysetm(string sum)
        {
            string numInDec = sum;
            string numInNumSystem = string.Empty;
            foreach (char c in numInDec)
            {
                numInNumSystem = numInNumSystem + FindDigitInNumSystem(c);
            }
            return numInNumSystem;
        }

        private static string FindDigitInNumSystem(char c)
        {
            string digit = string.Empty;
            switch (c)
            {
                case '0': digit = "cad"; break;
                case '1': digit = "xoz"; break;
                case '2': digit = "nop"; break;
                case '3': digit = "cyk"; break;
                case '4': digit = "min"; break;
                case '5': digit = "mar"; break;
                case '6': digit = "kon"; break;
                case '7': digit = "iva"; break;
                case '8': digit = "ogi"; break;
                case '9': digit = "yan"; break;
            }
            return digit;
        }

        private static string ConvertToDecimal(List<string> num)
        {
            string numberStr = string.Empty;
            for (int i = 0; i < num.Count; i++)
            {
                numberStr = numberStr + FindDigit(num[i]);
            }
            return numberStr;
        }

        private static string FindDigit(string p)
        {
            string digit = string.Empty;
            switch (p)
            {
                case "cad": digit = "0"; break;
                case "xoz": digit = "1"; break;
                case "nop": digit = "2"; break;
                case "cyk": digit = "3"; break;
                case "min": digit = "4"; break;
                case "mar": digit = "5"; break;
                case "kon": digit = "6"; break;
                case "iva": digit = "7"; break;
                case "ogi": digit = "8"; break;
                case "yan": digit = "9"; break;
            }
            return digit;
        }

        private static List<string> ExtractDigits(string first)
        {
            List<string> num1 = new List<string>();
            for (int i = 0; i < first.Length; i += 3)
            {
                string dig = string.Empty;
                for (int j = i; j < i + 3; j++)
                {
                    dig += first[j];
                }
                num1.Add(dig);
            }
            return num1;
        }

        static string Add(string a, string b)
        {
            int i = 1;
            char remain = '0';
            StringBuilder str = new StringBuilder();
            while (i <= a.Length)
            {
                if (b.Length - i >= 0)
                {
                    string digit = (int.Parse((a[a.Length - i]).ToString())
                                  + int.Parse((b[b.Length - i]).ToString())
                                  + int.Parse((remain).ToString())).ToString();
                    if (digit.Length < 2)
                    {
                        str.Insert(0, digit[0]);
                        remain = '0';
                    }
                    else
                    {
                        str.Insert(0, digit[1]);
                        remain = digit[0];
                    }
                }
                else
                {
                    string digit = (int.Parse((a[a.Length - i]).ToString())
                                  + int.Parse((remain).ToString())).ToString();
                    if (digit.Length < 2)
                    {
                        str.Insert(0, digit[0]);
                        remain = '0';
                    }
                    else
                    {
                        str.Insert(0, digit[1]);
                        remain = digit[0];
                    }
                }
                i++;
            }
            return str.ToString();
        }

        static string Rem(string a, string b)
        {
            int i = 1;
            StringBuilder str = new StringBuilder();
            string remain = "0";
            string digit = string.Empty;
            while (i <= a.Length)
            {
                if (b.Length - i >= 0)
                {
                    if (int.Parse((a[a.Length - i]).ToString()) - int.Parse((remain)) >= int.Parse((b[b.Length - i]).ToString()))
                    {
                        digit = (int.Parse((a[a.Length - i]).ToString())
                               - int.Parse((remain))
                               - int.Parse((b[b.Length - i]).ToString())).ToString();
                        str.Insert(0, digit[0]);
                        remain = "0";
                    }
                    else
                    {
                        digit = (int.Parse((a[a.Length - i]).ToString())
                               - int.Parse((remain)) + 10
                               - int.Parse((b[b.Length - i]).ToString())).ToString();
                        str.Insert(0, digit[0]);
                        remain = "1";   
                    }
                }
                else
                {
                    digit = (int.Parse((a[a.Length - i]).ToString())
                               - int.Parse((remain))).ToString();
                    str.Insert(0, digit[0]);
                    remain = "0";  
                }
                i++;
            }
            return str.ToString();
        }

    }
}
