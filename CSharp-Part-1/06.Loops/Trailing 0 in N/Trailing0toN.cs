using System;

class Trailing0toN
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int div5 = new int();
        for (int i = 1; i <= N; i++)
        {
            for (int j = 5; j <= N; j=j*5)
            {
                if (i % j == 0)
                {
                    div5 += 1;
                }
            }
        }
        Console.WriteLine(div5);
    }
}
