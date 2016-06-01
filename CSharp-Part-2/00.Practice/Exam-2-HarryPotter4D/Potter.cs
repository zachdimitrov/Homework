using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_3_HarryPotter4D
{
    class HarryPotter
    {
        static void Main()
        {
            string[] sizes = Console.ReadLine().Split(' ');
            int[] size = new int[sizes.Length];
            for (int i = 0; i < sizes.Length; i++)
            {
                size[i] = int.Parse(sizes[i]);
            }
            string[] harryStart = Console.ReadLine().Split(' ');
            int s = int.Parse(Console.ReadLine());
            string[] basilStarts = new string[s];
            int harryCount = 0;
            for (int i = 0; i < s; i++)
            {
                basilStarts[i] = Console.ReadLine();
            }
            var command = new List<string>();
            while (true)
            {
                string a = Console.ReadLine();
                if (a.Contains("END"))
                {
                    break;
                }
                command.Add(a);
            }
            string[][] basils = new string[s][];
            for (int i = 0; i < basils.Length; i++)
            {
                basils[i] = basilStarts[i].Split(' ');
            }
            foreach (string m in command)
            {
                string[] move = m.Split(' ');
                if (move[0] == "@")
                {
                    MoveHarry(harryStart, move, size);
                    harryCount++;
                    for (int i = 0; i < basils.Length; i++)
                    {
                        int count = 0;
                        for (int j = 1; j < basils[i].Length; j++)
                        {
                            if (basils[i][j] == harryStart[j - 1])
                            {
                                count++;
                            }
                        }
                        if (count == 4)
                        {
                            List<string> basilsinRoom = new List<string>();
                            for (int r = 0; r < basils.Length; r++)
                            {
                                for (int p = 1; p < basils[i].Length; p++)
                                {
                                    if (basils[r][p] == harryStart[p - 1])
                                    {
                                        count++;
                                    }
                                }
                                if (count == 4)
                                {
                                    basilsinRoom.Add(basils[r][0]);
                                }
                            }
                            char smallest = 'z';
                            for (int zz = 0; zz < basilsinRoom.Count; zz++)
                            {
                                if (basilsinRoom[zz][0] < smallest)
                                {
                                    smallest = basilsinRoom[zz][0];
                                }
                            }
                            Console.WriteLine("{0}: \"Step {1} was the worst you ever made.\"", basils[i][0], harryCount);
                            Console.WriteLine("{0}: \"You will regret until the rest of your life... All 3 seconds of it!\"", basils[i][0], harryCount);
                            return;
                        }
                    }
                }
                for (int i = 0; i < basils.Length; i++)
                {
                    if (move[0] == basils[i][0])
                    {
                        MovePlayer(basils[i], move, size);
                        int count = 0;
                        for (int j = 1; j < basils[i].Length; j++)
                        {
                            if (basils[i][j] == harryStart[j - 1])
                            {
                                count++;
                            }
                        }
                        if (count == 4)
                        {
                            Console.WriteLine("{0}: \"You thought you could escape, didn't you?\" - {1}", basils[i][0], harryCount);
                            return;
                        }
                    }
                }

            }
            Console.WriteLine("@: \"I am the chosen one!\" - {0}", harryCount);
        }

        private static void MovePlayer(string[] harryStart, string[] move, int[] size)
        {
            int harryA = int.Parse(harryStart[1]);
            int harryB = int.Parse(harryStart[2]);
            int harryC = int.Parse(harryStart[3]);
            int harryD = int.Parse(harryStart[4]);
            switch (move[1])
            {
                case "A":
                    harryA += int.Parse(move[2]);
                    if (harryA < 0)
                    {
                        harryA = 0;
                    }
                    if (harryA > size[0])
                    {
                        harryA = size[0];
                    }
                    harryStart[1] = harryA.ToString();
                    break;
                case "B":
                    harryB += int.Parse(move[2]);
                    if (harryB < 0)
                    {
                        harryB = 0;
                    }
                    if (harryB > size[1])
                    {
                        harryB = size[1];
                    }
                    harryStart[2] = harryB.ToString();
                    break;
                case "C":
                    harryC += int.Parse(move[2]);
                    if (harryC < 0)
                    {
                        harryC = 0;
                    }
                    if (harryC > size[2])
                    {
                        harryC = size[2];
                    }
                    harryStart[3] = harryC.ToString();
                    break;
                case "D":
                    harryD += int.Parse(move[2]);
                    if (harryD < 0)
                    {
                        harryD = 0;
                    }
                    if (harryD > size[3])
                    {
                        harryD = size[3];
                    }
                    harryStart[4] = harryD.ToString();
                    break;
            }
        }
        private static void MoveHarry(string[] harryStart, string[] move, int[] size)
        {
            int harryA = int.Parse(harryStart[0]);
            int harryB = int.Parse(harryStart[1]);
            int harryC = int.Parse(harryStart[2]);
            int harryD = int.Parse(harryStart[3]);
            switch (move[1])
            {
                case "A":
                    harryA += int.Parse(move[2]);
                    if (harryA < 0)
                    {
                        harryA = 0;
                    }
                    if (harryA > size[0])
                    {
                        harryA = size[0];
                    }
                    harryStart[0] = harryA.ToString();
                    break;
                case "B":
                    harryB += int.Parse(move[2]);
                    if (harryB < 0)
                    {
                        harryB = 0;
                    }
                    if (harryB > size[1])
                    {
                        harryB = size[1];
                    }
                    harryStart[1] = harryB.ToString();
                    break;
                case "C":
                    harryC += int.Parse(move[2]);
                    if (harryC < 0)
                    {
                        harryC = 0;
                    }
                    if (harryC > size[2])
                    {
                        harryC = size[2];
                    }
                    harryStart[2] = harryC.ToString();
                    break;
                case "D":
                    harryD += int.Parse(move[2]);
                    if (harryD < 0)
                    {
                        harryD = 0;
                    }
                    if (harryD > size[3])
                    {
                        harryD = size[3];
                    }
                    harryStart[3] = harryD.ToString();
                    break;
            }
        }
    }
}

//print lex smaller name