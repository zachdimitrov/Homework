using System;
using System.Text;

namespace ForSeriesOfLetters
{
    class SeriesLetters
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder result = new StringBuilder();
            for (int i = 1; i < input.Length; i++)
            {
                if (i + 1 < input.Length && input[i - 1] == input[i])
                {
                    continue;
                }
                result.Append(input[i - 1]);
                if (i + 1 != input.Length || input[i - 1] == input[i])
                {
                    continue;
                }
                result.Append(input[i]);
                break;
            }
            Console.WriteLine(result.ToString());
        }
    }
}