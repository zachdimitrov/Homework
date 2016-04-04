using System;

class ListIDE
{
    static void Main()
    {
        string line = System.IO.File.ReadAllText(@"C:\Users\Zahari\Dropbox\Project\Homework\CSharp-Part-1\01.Introduction-to-Programming\12.list-of-IDEs.txt");
        Console.WriteLine(line);
        System.Diagnostics.Process.Start(line);
    }
}

/*
Development Environments
Description

Perform a research (e.g. in Google or Wikipedia) and provide a short list with popular development environments (IDEs) like Visual Studio.
Write in a text file called list-of-IDEs.txt at least five IDEs along with 2-3 sentences about each of them. Use English.
Submission

You do not have to submit anything for this problem
*/