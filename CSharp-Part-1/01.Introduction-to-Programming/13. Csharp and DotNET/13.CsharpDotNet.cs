using System;

class CsandDNet
{
    static void Main()
    {
        string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Zahari\Dropbox\Project\Homework\CSharp-Part-1\01.Introduction-to-Programming\13.csharp-and-dot-net-framework.txt");
        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }
}

/*
 C# and .NET Differences
Description

Describe the difference between C# and .NET Framework in 2-3 sentences.
Write your description in a text file called csharp-and-dot-net-framework.txt. Use English.
Submission

You do not have to submit anything for this problem
*/