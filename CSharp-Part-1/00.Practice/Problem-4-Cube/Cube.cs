using System;

class Cube_1 //Not Working in BGCoder
{
    static void Main()
    {
        const char b = ':';
        const char t = '/';
        const char s = 'X';
        int N = int.Parse(Console.ReadLine());
        char[,] arr = new char[2 * N, 2 * N];
        for (int i = 0; i < N; i++)
        {
            CharInArray(arr, N - 1 + i, 0, b);
            CharInArray(arr, 0, N - 1 + i, b);
            CharInArray(arr, i, N - 1, b);
            CharInArray(arr, 2 * (N - 1), i, b);
            CharInArray(arr, i, 2 * (N - 1), b);
            CharInArray(arr, N - 1, N - 1 + i, b);
            CharInArray(arr, N - 1 - i, i, b);
            CharInArray(arr, 2 * (N - 1) - i, i, b);
            CharInArray(arr, 2 * (N - 1) - i, N - 1 + i, b);
        }
        for (int i = 0; i < N - 2; i++)
        {
            for (int j = 0; j < N - 2; j++)
            {
                CharInArray(arr, N - 1 + j - i, 1 + i, t);
                CharInArray(arr, N + i, N - 1 + j - i, s);
            }
        }
        for (int i = 0; i < 2 * N; i++)
        {
            for (int j = 0; j < 2 * N; j++)
            {
                Console.SetCursorPosition(i, j);
                Console.Write(arr[i, j]);
            }
        }
    }
    public static void CharInArray(char[,] array, int x, int y, char c)
    {
        array[x, y] = c;
    }
}