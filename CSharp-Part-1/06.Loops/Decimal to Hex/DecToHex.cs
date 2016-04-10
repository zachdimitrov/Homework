using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class DecToHex
{
    static void Main()
    {
        long N = long.Parse(Console.ReadLine());
        string bin = "";
        long i = 1;
        while (N > 0)
        {
            long remainder = N % 16;
            string digit = "";
            switch (remainder)
            {
                case 10: digit = "A";
                    break;
                case 11: digit = "B";
                    break;
                case 12: digit = "C";
                    break;
                case 13: digit = "D";
                    break;
                case 14: digit = "E";
                    break;
                case 15: digit = "F";
                    break;
                default: digit = "" + remainder;
                    break;
            }
            bin = digit + bin;
            N = (long)(N / 16);
            i++;
        }
        Console.WriteLine(bin);
    }
}