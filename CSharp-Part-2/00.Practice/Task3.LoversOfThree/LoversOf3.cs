using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoversOfThree
{
    class LoversOf3
    {
        static void Main()
        {
            int[] dim = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[,] matrix = CreateMatrix(dim);
            int x = matrix.GetLength(1);
            int y = matrix.GetLength(0);
            int moves = int.Parse(Console.ReadLine());
            int sum = 0;
            int indexY = y - 1;
            int indexX = 0;
            for (int i = 0; i < moves; i++)
            {
                string[] move = Console.ReadLine().Split(' ');
                string direction = move[0];
                int steps = int.Parse(move[1]);
                for (int t = 0; t < steps - 1; t++)
                {
                    indexX += GetXDirection(direction);
                    indexY += GetYDirection(direction);
                    if (indexX < 0 || indexX > x - 1 || indexY < 0 || indexY > y - 1)
                    {
                        indexX -= GetXDirection(direction);
                        indexY -= GetYDirection(direction);
                        break;
                    }
                    sum += matrix[indexY, indexX];
                    matrix[indexY, indexX] = 0;
                }
            }
            //PrintMatrix(matrix);
            Console.WriteLine(sum);
        }

        private static int GetXDirection(string direction)
        {
            int index = 0;
            switch (direction)
            {
                case "UR": index = 1; break;
                case "RD": index = 1; break;
                case "DL": index = -1; break;
                case "LU": index = -1; break;
                case "RU": index = 1; break;
                case "DR": index = 1; break;
                case "LD": index = -1; break;
                case "UL": index = -1; break;
            }
            return index;
        }

        private static int GetYDirection(string direction)
        {
            int index = 0;
            switch (direction)
            {
                case "UR": index = -1; break;
                case "RD": index = 1; break;
                case "DL": index = 1; break;
                case "LU": index = -1; break;
                case "RU": index = -1; break;
                case "DR": index = 1; break;
                case "LD": index = 1; break;
                case "UL": index = -1; break;
            }
            return index;
        }

        private static int[,] CreateMatrix(int[] dim)
        {
            int[,] matrix = new int[dim[0], dim[1]];
            int x = matrix.GetLength(1);
            int y = matrix.GetLength(0);
            matrix[y - 1, 0] = 0;
            for (int k = y - 2; k >= 0; k--)
            {
                matrix[k, 0] = matrix[k + 1, 0] + 3;
            }
            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x - 1; j++)
                {
                    matrix[i, j + 1] = matrix[i, j] + 3;
                }
            }
            return matrix;
        }

        private static void PrintMatrix(int[,] matrix)
        {
            int x = matrix.GetLength(1);
            int y = matrix.GetLength(0);
            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    if (j == x - 1)
                    {
                        Console.Write("{0,4}", matrix[i, j]);
                    }
                    else
                    {
                        Console.Write("{0,4}, ", matrix[i, j]);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
