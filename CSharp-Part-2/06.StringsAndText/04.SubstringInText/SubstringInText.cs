using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForSubstringInText
{
    class SubstringInText
    {
        static List<int> FindString(string inpat, string intext) // Method 1 - s indeksi
        {
            string text = intext.ToLower(); // remove case
            string pat = inpat.ToLower();   // remove case
            List<int> indices = new List<int>();
            int nextOccurance = text.IndexOf(pat);
            while (nextOccurance != -1)
            {
                indices.Add(nextOccurance);
                nextOccurance = text.IndexOf(pat, nextOccurance + 1);
            }
            return indices;
        }
        static void Main()
        {
            string pat = Console.ReadLine();
            string text = Console.ReadLine();
            List<int> occurances = FindString(pat, text);
            Console.WriteLine(occurances.Count);
        }
    }
}
