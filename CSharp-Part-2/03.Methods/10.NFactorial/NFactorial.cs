using System;
using System.Collections.Generic;
using System.Numerics;

class NFactorial
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            numbers[i] = i + 1;
        }
        BigInteger fact = CalcFact(numbers);
        Console.WriteLine(fact);
    }

    private static BigInteger CalcFact(int[] numbers)
    {
        BigInteger result = 1;
        for (int i = 0; i < numbers.Length; i++)
        {
            result = result * numbers[i];
        }
        return result;
    }
}