using System;

class SequenceMatrix
{
    static void Main()
    {
        string[] nim = Console.ReadLine().Split(' ');
        int n = int.Parse(nim[0]);
        int m = int.Parse(nim[1]);
        string[,] matrix = new string[n, m];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            string[] rows = Console.ReadLine().Split(' ');
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = rows[j];
            }
        }
        int count = 1;
        int bestCount = 1;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            count =  1;
            for (int j = 0; j < matrix.GetLength(1) - 1; j++)
            {
                if (matrix[i, j] == matrix[i, j + 1])
                {
                    count++;
                }
                else
                {
                    count = 1;
                }
                if (count > bestCount)
                {
                    bestCount = count;
                }
            }
        }
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            count = 1;
            for (int j = 0; j < matrix.GetLength(0) - 1; j++)
            {
                if (matrix[j, i] == matrix[j + 1, i])
                {
                    count++;
                }
                else
                {
                    count = 1;
                }
                if (count > bestCount)
                {
                    bestCount = count;
                }
            }
        }
        for (int i = 0; i < matrix.GetLength(0) - 1; i++)
        {
            for (int j = 0; j < matrix.GetLength(1) - 1; j++)
            {
                count = 1;
                for (int row = i, col = j; row < matrix.GetLength(0) - 1 && col < matrix.GetLength(1) - 1; row++, col++)
                {
                    if (matrix[row, col] == matrix[row + 1, col + 1])
                    {
                        count++;
                    }
                    else
                    {
                        count = 1;
                        break;
                    }
                    if (count > bestCount)
                    {
                        bestCount = count;
                    }
                }
            }
        }
        for (int i = 0; i < matrix.GetLength(0) - 1; i++)
        {
            for (int j = 0; j < matrix.GetLength(1) - 1; j++)
            {
                count = 1;
                for (int row = i, col = j + 1; row < matrix.GetLength(0) - 1 && col < matrix.GetLength(1)+1; row++, col++)
                {
                    if (matrix[row, col] == matrix[row + 1, col - 1])
                    {
                        count++;
                    }
                    else
                    {
                        count = 1;
                        break;
                    }
                    if (count > bestCount)
                    {
                        bestCount = count;
                    }
                }
            }
        }
        Console.WriteLine(bestCount);
    }
}