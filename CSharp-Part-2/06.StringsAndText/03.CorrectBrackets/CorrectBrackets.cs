using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            closed = FindInString(exp, ")");
            if (open.Count == closed.Count)
            {
                if (open[open.Count-1] < closed[0])
                {
                    Console.WriteLine("Correct");
                }
                else
                {
                    Console.WriteLine("Incorrect");
                }
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
                if (Convert.ToString(exp[i]) == v)
                {
                    positions.Add(i);
                }
            }
            return positions;
        }
    }
}
