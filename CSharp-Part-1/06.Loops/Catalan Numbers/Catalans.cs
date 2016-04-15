using System;
using System.Numerics;

class Catalans
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        BigInteger factN = 1;
        BigInteger fact2N = 1;
        BigInteger factNplus1 = 1;
        int NN = 2 * N;
        int Nplus1 = N + 1;
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

