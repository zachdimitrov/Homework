using System;

class Cube_2 //Not Working in BGCoder
{
    static void PrintChar(int x, int y, char c)
    {
        Console.SetCursorPosition(x, y);
        Console.Write(c);
    }
    static void Main()
    {
        const char b = ':';
        const char t = '/';
        const char s = 'X';
        int N = int.Parse(Console.ReadLine());
        for (int i = 0; i < N; i++)
        {
            PrintChar(N - 1 + i, 0, b);
            PrintChar(0, N - 1 + i, b);
            PrintChar(i, N - 1, b);
            PrintChar(2 * (N - 1), i, b);
            PrintChar(i, 2 * (N - 1), b);
            PrintChar(N - 1, N - 1 + i, b);
            PrintChar(N - 1 - i, i, b);
            PrintChar(2 * (N - 1) - i, i, b);
            PrintChar(2 * (N - 1) - i, N - 1 + i, b);
        }
        for (int i = 0; i < N - 2; i++)
        {
            for (int j = 0; j < N - 2; j++)
            {
                PrintChar(N - 1 + j - i, 1 + i, t);
                PrintChar(N + i, N - 1 + j - i, s);
            }
        }
    }
}