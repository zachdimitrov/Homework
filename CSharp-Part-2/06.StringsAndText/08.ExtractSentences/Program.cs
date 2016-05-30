using System;
using System.Text;

class ExtrSent
{
    static void Main()
    {
        string word = Console.ReadLine().ToLower();
        string text = Console.ReadLine();
        var sentences = text.Split('.');

        StringBuilder result = new StringBuilder();

        foreach (var sentence in sentences)
        {
            var words = sentence.Split(new[] { '.', ' ', ',', '-', '!', '?', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            if (Array.IndexOf(words, word.ToLower()) > -1)
            {
                result.Append(sentence.Trim());
                result.Append(". ");
            }
        }

        Console.WriteLine(result.ToString().Trim());
    }
}