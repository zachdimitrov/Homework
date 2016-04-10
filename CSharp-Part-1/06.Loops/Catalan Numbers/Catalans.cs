using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Catalans
{
    static void Main()
    {
        double N = double.Parse(Console.ReadLine());
        double factN = 1;
        double fact2N = 1;
        double factNplus1 = 1;
        double NN = 2 * N;
        double Nplus1 = N + 1;
        if (N >= 1 && N <= 100)
        {
            while (true)
            {
                if ((N == 1 && NN == 1 && Nplus1 == 1))
                {
                    break;
                }
                if (N> 1)
                {
                    factN *= N;
                    N--;
                }
                if (NN > 1)
                {
                    fact2N *= NN;
                    NN--;
                }
                if (Nplus1 > 1)
                {
                    factNplus1 *= Nplus1;
                    Nplus1--;
                }
            }
            Console.WriteLine("{0}", fact2N/(factN*factNplus1));
        }
    }
}

