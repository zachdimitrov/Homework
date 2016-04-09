using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Sort3Numbers
{
    static void Main()
    {
        int A = int.Parse(Console.ReadLine());
        int B = int.Parse(Console.ReadLine());
        int C = int.Parse(Console.ReadLine());
        if (A >= B && A >= C)
        {
            if (B >= C)
            {
                Console.WriteLine(A + " " + B + " " + C);
            }
            else
            {
                Console.WriteLine(A + " " + C + " " + B);
            }
        }
        else if (B>=A && B>=C)
        {
            if (A>=C)
            {
                Console.WriteLine(B + " " + A + " " + C);
            }
            else
            {
                Console.WriteLine(B + " " + C + " " + A);
            }
        }
        else if (C>=A && C>=B)
        {
            if (A>=B)
            {
                Console.WriteLine(C + " " + A + " " + B);
            }
            else
            {
                Console.WriteLine(C + " " + B + " " + A);
            }
        }
    }
}
