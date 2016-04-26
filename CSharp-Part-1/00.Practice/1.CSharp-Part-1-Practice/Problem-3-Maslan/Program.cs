using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        BigInteger n = BigInteger.Parse(Console.ReadLine());
        int transformation = 0;
        BigInteger result = 1;
        while (true)
        {
            if (n < 10)
            {
                Console.WriteLine(transformation);
                Console.WriteLine(result);
                return;
            }
            if (transformation == 10)
            {
                Console.WriteLine(result);
                return;
            }
            result = 1;
            while (true)
            {
                if(n<10)
                {
                    break;
                }
                int sum = 0;
                n = (BigInteger)(n / 10);
                string num = Convert.ToString(n);
                for (int i = 1; i < num.Length; i = i + 2)
                {
                    sum += int.Parse(num[i]+"");
                }
                if (sum > 0)
                {
                    result *= sum;
                }
            }
            n = result;
            transformation++;
        }
    }
}