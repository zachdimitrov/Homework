using System;
using System.Threading;

class Bittris
{
    static void Main()
    {
        int[] line = { 0, 0, 0, 0 };

        int N = int.Parse(Console.ReadLine());
        int number;
        int score = 0;

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                string command = Console.ReadLine();
                if (int.TryParse(command, out number))
                {
                    line[0] = number;
                    //PrintField(line, score);
                    //Thread.Sleep(500);
                    break;
                }
                else if (command == "D")
                {
                    if (line[j + 1] == 0 && j < 3)
                    {
                        line[j + 1] = line[j];
                        line[j] = 0;
                    }
                    else if ((line[j] & line[j + 1]) == 0 && j < 3)
                    {
                        line[j + 1] = line[j] | line[j + 1];
                        if (line[j + 1] == 255)
                        {
                            score += bitCount(line[j]) * 10;
                            line[j + 1] = 0;
                        }
                        else
                        {
                            score += bitCount(line[j]);
                        }
                        line[j] = 0;
                    }
                    if ((line[j] & line[j + 1]) != 0 || j == 3)
                    {
                        score += bitCount(line[j]);
                        j--;
                    }
                }
                else if (command == "R" && j < 3)
                {
                    if (line[j] % 2 == 0)
                    {
                        line[j] = line[j] >> 1;
                    }
                    if (line[j + 1] == 0 && j < 3)
                    {
                        line[j + 1] = line[j];
                        line[j] = 0;
                    }
                    else if ((line[j] & line[j + 1]) == 0 && j < 3)
                    {
                        line[j + 1] = line[j] | line[j + 1];
                        if (line[j + 1] == 255)
                        {
                            score += bitCount(line[j]) * 10;
                            line[j + 1] = 0;
                        }
                        else
                        {
                            score += bitCount(line[j]);
                        }
                        line[j] = 0;
                    }
                    if ((line[j] & line[j + 1]) != 0 || j == 3)
                    {
                        score += bitCount(line[j]);
                        j--;
                    }
                }
                else if (command == "L" && j < 3)
                {
                    if (line[j] < 128)
                    {
                        line[j] = line[j] << 1;
                    }
                    if (line[j + 1] == 0 && j < 3)
                    {
                        line[j + 1] = line[j];
                        line[j] = 0;
                    }
                    else if ((line[j] & line[j + 1]) == 0 && j < 3)
                    {
                        line[j + 1] = line[j] | line[j + 1];
                        if (line[j + 1] == 255)
                        {
                            score += bitCount(line[j]) * 10;
                            line[j + 1] = 0;
                        }
                        else
                        {
                            score += bitCount(line[j]);
                        }
                        line[j] = 0;
                    }
                    if ((line[j] & line[j + 1]) != 0 || j == 3)
                    {
                        score += bitCount(line[j]);
                        j--;
                    }
                }
                if (line[0] != 0 && line[1] != 0 && line[2] != 0 && line[3] != 0)
                {
                    Console.WriteLine(score);
                    return;
                }
               // PrintField(line, score);
               // Thread.Sleep(500);
            }
        }
        Console.WriteLine(score);
    }

    private static int bitCount(int p)
    {
        int count = 0;
        while (p != 0)
        {
            count++;
            p = p & (p - 1);
        }
        return count;
    }
    /*
    private static void PrintField(int[] lines, int s)
    {
        Console.Clear();
        for (int k = 0; k < 4; k++)
        {
            Console.WriteLine(Convert.ToString(lines[k], 2).PadLeft(8, '0'));
        }
        Console.WriteLine("--------");
        Console.WriteLine("score: {0}", s);
    }
     */
}
