using System;

class Cube3D
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(new string(':', n));
        for (int i = 0; i < n - 2; i++)
        {
            Console.Write(':');
            Console.Write(new string(' ', n - 2));
            Console.Write(':');
            Console.Write(new string('|', i));
            Console.WriteLine(':');
        }
        Console.Write(new string(':', n));
        Console.Write(new string('|', n - 2));
        Console.WriteLine(':');
        for (int i = 0; i < n - 2; i++)
        {
            Console.Write(new string(' ', i + 1));
            Console.Write(':');
            Console.Write(new string('-', n - 2));
            Console.Write(':');
            Console.Write(new string('|', n - 3 - i));
            Console.WriteLine(':');
        }
        Console.Write(new string(' ', n - 1));
        Console.WriteLine(new string(':', n));
    }
}
