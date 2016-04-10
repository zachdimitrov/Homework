using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class DecimalToBin
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        string bin = "";
        int i = 1;
        while (N>0)
        {
            bin = N % 2 + bin;
            N = (int)(N / 2);
            i++;
        }
        Console.WriteLine(bin);
    }
}
