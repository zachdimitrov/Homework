using System;
using System.Collections.Generic;

namespace ToCorrectBrackets
{
    class CorrectBrackets
    {
        static void Main()
        {
            string exp = Console.ReadLine();
            List<int> open = new List<int>();
            List<int> closed = new List<int>();
            open = FindInString(exp, "(");
            // Console.WriteLine(String.Join(", ", open));
            closed = FindInString(exp, ")");
            // Console.WriteLine(String.Join(", ", closed));
            if (open.Count == closed.Count)
            {
                int openBeforeClosed = 0;
                int closedAfterOpen = 0;
                int i = 0;
                int j = 0;
                while(i < open.Count && j < closed.Count)
                {
                    if(open[i] < closed[j])
                    {
                        openBeforeClosed++;
                        i++;
                    }
                    else
                    {
                        closedAfterOpen++;
                        j++;
                    }
                    if (closedAfterOpen > openBeforeClosed)
                    {
                        Console.WriteLine("Incorrect");
                        break;
                    }
                }
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine("Incorrect");
            }
        }

        private static List<int> FindInString(string exp, string v)
        {
            List<int> positions = new List<int>();
            for (int i = 0; i < exp.Length; i++)
            {
                if (exp[i].ToString() == v)
                {
                    positions.Add(i);
                }
            }
            return positions;
        }
    }
}
