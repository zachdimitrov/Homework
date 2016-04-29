using System;

class BatGoikoTower
{
    static void Main()
    {
        int H = int.Parse(Console.ReadLine());
        int beam = 2;
        int line = 1;
        for (int i = 1; i < H+1; i++)
        {
            Console.Write(new string('.', H - i));
            Console.Write("/");
            if (i == beam)
            {
                Console.Write(new string('-', 2 * i-2));
                line++;
                beam += line;
            }
            else if (i>2)
            {
                Console.Write(new string('.', 2 * i - 2));
            }
            Console.Write("\\");
            Console.WriteLine(new string('.', H - i));
        }
    }
}
