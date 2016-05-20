using System;

class SumIntegers
{
    static void Main()
    {
        string numbers = Console.ReadLine();
        string[] numbersS = numbers.Split(' ');
        int sum = 0;
        for (int i = 0; i < numbersS.Length; i++)
        {
            sum += int.Parse(numbersS[i]);
        }
        Console.WriteLine(sum);
    }
}