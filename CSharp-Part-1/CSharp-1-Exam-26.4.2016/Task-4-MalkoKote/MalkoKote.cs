using System;

class MalkoKote
{
    static void Main()
    {
        int s = int.Parse(Console.ReadLine());
        char c = (char)Console.Read();
        int space = 1;
        if (s > 10)
        {
            space = (s - 10) / 4 + 1;
        }
        Console.Write(' ');
        Console.Write(c);
        Console.Write(new string(' ', space));
        Console.WriteLine(c);
        for (int i = 0; i < space; i++)
        {
            Console.Write(' ');
            Console.Write(c);
            Console.Write(new string(c, space));
            Console.WriteLine(c);
        }
        for (int i = 0; i < space; i++)
        {
            Console.Write(' ');
            Console.Write(' ');
            Console.Write(new string(c, space));
            Console.WriteLine(' ');
        }
        for (int i = 0; i < space; i++)
        {
            Console.Write(' ');
            Console.Write(c);
            Console.Write(new string(c, space));
            Console.WriteLine(c);
        }
        Console.Write(' ');
        Console.Write(c);
        Console.Write(new string(c, space));
        Console.Write(c);
        Console.Write(new string(' ', 3));
        Console.WriteLine(new string(c, space + 1));

        for (int i = 0; i < s - 3 * space - 4; i++)
        {
            Console.Write(c);
            Console.Write(c);
            Console.Write(new string(c, space));
            Console.Write(new string(c, 2));
            Console.Write(new string(' ', 2));
            Console.WriteLine(c);
        }
        Console.Write(c);
        Console.Write(c);
        Console.Write(new string(c, space));
        Console.Write(new string(c, 2));
        Console.Write(' ');
        Console.WriteLine(new string(c, 2));

        Console.Write(' ');
        Console.Write(c);
        Console.Write(new string(c, space + 1));
        Console.WriteLine(new string(c, 3));
    }
}
