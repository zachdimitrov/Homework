using System;
using System.Numerics;

class SaddyCopper
{
    static void Main()
    {
        BigInteger N = BigInteger.Parse(Console.ReadLine());
        int transf = 0;
        BigInteger sum = 0;
        BigInteger prod = 1;
        while (true)
        {
            if (N<10)
            {
                Console.WriteLine(transf);
                Console.WriteLine(N);
                return;
            }
            if (transf == 10)
            {
                Console.WriteLine(N);
                return;
            }
            while (N >= 10)
            {
                N = (BigInteger)(N / 10);
                string num = ""+N;
                for (int i = 0; i < num.Length; i+=2)
                {
                    sum = sum + int.Parse(num[i]+"");
                }
                prod *= sum;
                sum = 0;
            }
            transf++;
            N = prod;
            prod = 1;
        }
    }
}