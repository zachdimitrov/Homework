using System;

class Cube
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        Console.Write(new String(' ', N - 1));
        Console.WriteLine(new String(':', N));
        for (int i = 0; i < N - 2; i++)
        {
            Console.Write(new String(' ', N - 2 - i));
            Console.Write(':');
            Console.Write(new String('/', N - 2));
            Console.Write(':');
            if (i > 0)
            {
                Console.Write(new String('X', i));
            }
            Console.WriteLine(':');
        }
        Console.Write(new String(':', N));
        Console.Write(new String('X', N - 2));
        Console.WriteLine(':');
        for (int i = 0; i < N - 2; i++)
        {
            Console.Write(':');
            Console.Write(new String(' ', N - 2));
            Console.Write(':');
            Console.Write(new String('X', N - 3 - i));
            Console.WriteLine(':');
        }
        Console.WriteLine(new String(':', N));
    }
}
