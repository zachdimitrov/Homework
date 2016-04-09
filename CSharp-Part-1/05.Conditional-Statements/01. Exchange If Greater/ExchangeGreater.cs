using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ExchangeGreater
{
    static void Main()
    {
        double A = double.Parse(Console.ReadLine());
        double B = double.Parse(Console.ReadLine());
        if (A>B)
        {
            double C = A;
            A = B;
            B = C;
        }
        Console.WriteLine(A + " " + B);
    }
}