using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_5_Penquin
{
    class Penguin
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string[] outgoing = new string[n];
            for (int i = 0; i < n; i++)
            {
                outgoing[i] = Console.ReadLine();
            }
            List<string> quiery = new List<string>();
            while (true)
            {
                string a = Console.ReadLine();
                if (a == "Have a break")
                {
                    break;
                }
                quiery.Add(a);
            }
            bool[,] grafik = new bool[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    string[] island = outgoing[i].Split(' ');
                    if (island[0] == "None")
                    {
                        grafik[i, j] = false;
                    }
                    else
                    {
                        for (int k = 0; k < island.Length; k++)
                        {
                            if (island[k] == j.ToString())
                            {
                                grafik[i, j] = true;
                                break;
                            }
                            else
                            {
                                grafik[i, j] = false;
                            }
                        }
                    }
                }
            }
            // Console.WriteLine("---------------------");
            // for (int i = 0; i < n; i++)
            // {
            //     for (int j = 0; j < n; j++)
            //     {
            //         Console.Write(grafik[i, j] + " ");
            //     }
            //     Console.WriteLine();
            // }
            // Console.WriteLine("---------------------");
            for (int i = 0; i < quiery.Count; i++)
            {
                string[] fromTo = quiery[i].Split(' ');
                int from = int.Parse(fromTo[0]);
                int to = int.Parse(fromTo[1]);
                if (grafik[from, to])
                {
                    Console.WriteLine("There is a direct flight.");
                    continue;
                }
                else
                {
                    bool found = false;
                    RoundFlight(from, to, grafik);
                    if (found)
                    {
                        Console.WriteLine("There are flights, unfortunately they are not direct, grandma :(");
                    }
                    else
                    {
                        Console.WriteLine("No flights available.");
                    }
                }
            }
        }
        static bool RoundFlight(int from, int to, bool[,] grafik)
        {
            int round = -1;
            bool found = false;
            for (int j = 0; j < grafik.GetLength(1); j++)
            {
                if (grafik[from, j] && from != j)
                {
                    round = j;
                }
                if (round != -1)
                {
                    if (grafik[j, to] && to != j)
                    {
                        found = true;
                    }
                    else if (to != j)
                    {
                        found = false;
                    }
                    round = -1;
                    break;
                }
            }
            return found;
        }
    }
}
