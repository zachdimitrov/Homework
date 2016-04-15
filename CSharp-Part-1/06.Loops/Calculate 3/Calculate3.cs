using System;
using System.Numerics;

class Calculate3
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int K = int.Parse(Console.ReadLine());
        BigInteger factN = 1;
        BigInteger factK = 1;
        BigInteger factSum = 1;
        int subs = Math.Abs(N - K);
        BigInteger result;
        while (true)
        {
            if (N == 1 && K == 1 && subs == 1)
            {
                break;
            }
            if (N > 1)
            {
                factN *= N;
                N--;
            }
            if (K > 1)
            {
                factK *= K;
                K--;
            }
            if (subs > 1)
            {
                factSum *= subs;
                subs--;
            }
        }
        result = factN / (factK * (factSum));
        Console.WriteLine(result);
    }
}
