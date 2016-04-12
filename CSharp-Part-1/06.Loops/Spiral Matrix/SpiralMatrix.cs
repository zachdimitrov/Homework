using System;

class SpiralMatrix
{
    static void printNum(int x, int y, int a)
    {
        Console.SetCursorPosition(x, y);
        Console.Write(a);
    }
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int xMin = 0;
        int yMin = 0;
        int xMax = N-1;
        int yMax = N-1;
        int value = 1;
        int[,] a = new int[N,N];
        while (value <= N*N)
        {
            for (int i = xMin; i <= xMax; i++)
            {
                a[yMin, i] = value;
                value++;
            }
            for (int i = yMin+1; i <= yMax; i++)
            {
                a[i, xMax] = value;
                value++;
            }
            for (int i = xMax-1; i >= xMin; i--)
            {
                a[yMax, i] = value;
                value++;
            }
            for (int i = yMax - 1; i >= yMin+1; i--)
            {
                a[i, xMin] = value;
                value++;
            }
            xMin++;
            yMin++;
            xMax--;
            yMax--;
        }
        for (int i = 0; i <= N-1; i++)
        {
            for (int j = 0; j <= N-1; j++)
            {
                Console.Write(a[i, j]);
            }
            Console.WriteLine("");
        }
    }
}
