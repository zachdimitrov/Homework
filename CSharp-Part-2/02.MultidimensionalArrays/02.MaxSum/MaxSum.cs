using System;

class MaxSum
{
    static void Main()
    {
        string[] nim = Console.ReadLine().Split(' ');
        int n = int.Parse(nim[0]);
        int m = int.Parse(nim[1]);
        int[,] matrix = new int[n, m];
        for (int i = 0; i < n; i++)
        {
            string[] rows = Console.ReadLine().Split(' ');
            for (int j = 0; j < m; j++)
            {
                matrix[i, j] = int.Parse(rows[j]);
            }
        }
        int bestSum = int.MinValue;
        int bestRow = 0;
        int bestCol = 0;
        for (int row = 0; row < matrix.GetLength(0) - 2; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 2; col++)
            {
                int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2]
                    + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2]
                    + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                if (sum > bestSum)
                {
                    bestSum = sum;
                    bestRow = row;
                    bestCol = col;
                }
            }
        }
        Console.WriteLine(bestSum);
    }
}
