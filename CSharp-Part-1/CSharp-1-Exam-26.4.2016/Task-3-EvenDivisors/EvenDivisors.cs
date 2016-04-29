using System;

class EvenDivisors
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int divSum = 0;
        for (int i = a; i <= b; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                if (i % j == 0)
                {
                    if (j % 2 == 0)
                    {
                        divSum += j;
                    }
                }
            }
        }
        Console.WriteLine(divSum);
    }
}