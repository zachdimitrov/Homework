using System;
using System.Collections.Generic;

class primeNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        bool[] test = new bool[n+1];
        for (int i = 2; i <= n; i++)
        {
            test[i] = true;
        }
        for (int j = 2; j < n+1; j++)
        {
            if (test[j])
            {
                for (long p = 2; (p * j) < n+1; p++)
                {
                    test[p * j] = false;
                }
            }
        }
        for (int k = test.Length; k > 2; k--)
        {
            if (test[k - 1] == true)
            {
                Console.WriteLine(k-1);
                break;
            }
        }
    }
}