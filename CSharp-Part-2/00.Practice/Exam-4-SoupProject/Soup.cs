using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exam_4_SoupProject
{
    class SoupProject
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<string> soup = new List<string>();
            for (int i = 0; i < n; i++)
            {
                string a = Console.ReadLine();
                if (a != string.Empty)
                {
                    soup.Add(a);
                }
            }
            for (int j = 0; j < soup.Count; j++)
            {
                soup[j]= Regex.Replace(soup[j], @"\s+", " ");
                soup[j] = soup[j].Trim(' ');
                StringBuilder l = new StringBuilder(soup[j]);
                int br = soup[j].IndexOf(')');
                int curly = -1;
                if (br > 0)
                {
                    curly = soup[j].IndexOf('{', br);
                    if (curly > 0 && curly != br + 2)
                    {
                        l.Remove(br + 1, curly - br - 1);
                        l.Insert(br+1, ' ');
                    }
                }
                Console.WriteLine(soup[j]);
            }
        }
    }
}
