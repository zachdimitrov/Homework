using System;

class indexLetters
{
    static void Main()
    {
        char[] letters = new char[26];
        string word = Console.ReadLine();
        for (int i = 97; i < 123; i++)
        {
            letters[i - 97] = (char)i;
        }
        for (int j = 0; j < word.Length; j++)
        {
            Console.WriteLine(Array.IndexOf(letters, word[j]));
        }
    }
}