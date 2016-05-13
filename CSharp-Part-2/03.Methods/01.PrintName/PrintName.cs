using System;

class PrintName
{
    static void Main()
    {
        string name = Console.ReadLine();
        PrintNm(name);
    }

    private static void PrintNm(string name)
    {
        Console.WriteLine("Hello, {0}!", name);
    }
}