using System;

class Fire
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n/2; i++)
        {
            Console.Write(new string('.', n / 2 - i));
            Console.Write("#");
            Console.Write(new string('.', 2*(i-1)));
            Console.Write("#");
            Console.WriteLine(new string('.', n / 2 - i));
        }
        for (int i = n/4; i > 0; i--)
        {
            Console.Write(new string('.', n / 4 - i));
            Console.Write("#");
            Console.Write(new string('.', n-2*(n/4 - i)-2));
            Console.Write("#");
            Console.WriteLine(new string('.', n / 4 - i));
        }
        Console.WriteLine(new string('-', n));
        for (int i = 0; i < n/2; i++)
        {
            Console.Write(new string('.', i));
            Console.Write(new string('\\', n / 2 - i));
            Console.Write(new string('/', n / 2 - i));
            Console.WriteLine(new string('.', i));
        }
        
    }
}
