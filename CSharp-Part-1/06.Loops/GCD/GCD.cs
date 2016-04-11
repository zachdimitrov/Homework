using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class GCD
{
    static void Main()
    {
        int A = Math.Abs(int.Parse(Console.ReadLine()));
        int B = Math.Abs(int.Parse(Console.ReadLine()));
        while (true)
        {
            if (A == B)
            {
                Console.WriteLine(A);
                break;
            }
            if (A > B)
            {
                A = A - B;
            }
            if (B > A)
            {
                B = B - A;
            }
        }
    }
}
