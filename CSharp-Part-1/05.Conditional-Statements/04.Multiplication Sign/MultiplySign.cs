using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MultiplySign
{
    static void Main()
    {
        double A = double.Parse(Console.ReadLine());
        double B = double.Parse(Console.ReadLine());
        double C = double.Parse(Console.ReadLine());
        string Result = "0";
        if ((A>0 && B>0 && C>0) || (A<0 && B<0 && C>0) || (A<0 && B>0 && C<0) || (A>0 && B<0 &&C<0))
        {
            Result = "+";
        }
        else if ((A<0 && B<0 && C<0) || (A>0 && B>0 && C<0) || (A>0 && B<0 && C>0) || (A<0 && B>0 &&C>0))
        {
            Result = "-";
        }
        Console.WriteLine(Result);
    }
}
