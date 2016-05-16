using System;
using System.Linq;

class CalcPolinomials
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();  // read array printed on 1 line (Linq)
        int[] arr2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        Console.Clear();
        Console.Write("Polinom 1 coefficients: ");
        Console.WriteLine(String.Join(" ", arr1));
        Console.Write("Polinom 2 coefficients: ");
        Console.WriteLine(String.Join(" ", arr2));
        Console.Write("Addition:               ");
        Console.WriteLine(String.Join(" ", AddPolinoms(arr1, arr2)));
        Console.Write("Substraction:           ");
        Console.WriteLine(String.Join(" ", SubstractPolinoms(arr1, arr2)));
        Console.Write("Multiplication:         ");
        Console.WriteLine(String.Join(" ", MultiplyPolinoms(arr1, arr2)));
    }
    private static int[] AddPolinoms(int[] arr1, int[] arr2)
    {
        int[] result = new int[arr1.Length];
        for (int i = 0; i < result.Length; i++)
        {
            result[i] = arr1[i] + arr2[i];
        }
        return result;
    }

    private static int[] SubstractPolinoms(int[] arr1, int[] arr2)
    {
        int[] result = new int[arr1.Length];
        for (int i = 0; i < result.Length; i++)
        {
            result[i] = arr1[i] - arr2[i];
        }
        return result;
    }

    private static int[] MultiplyPolinoms(int[] arr1, int[] arr2)
    {
        int[] result = new int[arr1.Length];
        for (int i = 0; i < result.Length; i++)
        {
            result[i] = arr1[i] * arr2[i];
        }
        return result;
    } 
}