using System;
using System.Text;

namespace ForbiddenWords
{
    class Forbidden
    {
        static void Main()
        {
            string text = Console.ReadLine();
            string[] words = Console.ReadLine().Split(' ');
            StringBuilder str = new StringBuilder(text);
            for (int i = 0; i < words.Length; i++)
            {
                str.Replace(words[i], new string('*', words[i].Length));
            }
            Console.WriteLine(str);
        }
    }
}
