using System;

class LifeUniverseEverything
{
    static void Main()
    {
        while (true)
        {
            int n = int.Parse(Console.ReadLine());
            if (n != 42)
            {
                Console.WriteLine(n);
            }
            else
            {
                return;
            }
        }
    }
}