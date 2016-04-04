using System;

class ProgLangs
{
    static void Main()
    {
        string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Zahari\Dropbox\Project\Homework\CSharp-Part-1\01.Introduction-to-Programming\11.programming-languages.txt");
        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }
}

/*
Programming Languages
Description

Perform a research (e.g. in Google or Wikipedia) and provide a short list with information about the most popular programming languages. How similar are they to C#? How do they differ from C#?
Write in a text file called programming-languages.txt at least five languages along with 2-3 sentences about each of them. Use English.
Submission

You do not have to submit anything for this problem
*/