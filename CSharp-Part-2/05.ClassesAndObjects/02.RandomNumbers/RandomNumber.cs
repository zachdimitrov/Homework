using System;
using System.Linq;

class RandomNumber
{
    static void Main()
    {
        int count = int.Parse(Console.ReadLine());
        Random rand = new Random();
        int[] numbers = new int[count];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = rand.Next(100, 200);
        }
        Console.WriteLine(String.Join(", ", numbers));
    }
}