using System;

class MatrixNumbers
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        string line = "";
        for (int i = 1; i <= N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                line = line + (i + j)+" ";
            }
            Console.WriteLine(line);
            line = "";
        }
    }
}
