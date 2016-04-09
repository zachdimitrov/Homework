using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BiggestOf5
{
    static void Main()
    {
        double A = double.Parse(Console.ReadLine());
        double B = double.Parse(Console.ReadLine());
        double C = double.Parse(Console.ReadLine());
        double D = double.Parse(Console.ReadLine());
        double E = double.Parse(Console.ReadLine());
        if (A >= B && A >= C && A >= D && A >= E)
        {
            Console.WriteLine(A);
        }
        if (B >= A && B >= C && B >= D && B >= E)
        {
            Console.WriteLine(B);
        }
        if (C >= A && C >= B && C >= D && C >= E)
        {
            Console.WriteLine(C);
        }
        if (D >= A && D >= B && D >= C && D >= E)
        {
            Console.WriteLine(D);
        }
        if (E >= A && E >= B && E >= C && E >= D)
        {
            Console.WriteLine(E);
        }
    }
}