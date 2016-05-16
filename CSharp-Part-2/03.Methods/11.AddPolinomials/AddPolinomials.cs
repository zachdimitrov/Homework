using System;
using System.Collections.Generic;

class AddPolinomials
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr1 = ReceiveIntArray(n);
        int[] arr2 = ReceiveIntArray(n);
        int[] result = AddPolinoms(arr1, arr2);
        Console.WriteLine(String.Join(" ", result));
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

    private static int[] ReceiveIntArray(int size) // Receive Int Array from Console
    {
        int[] arr = new int[size];
        string[] arrS = (Console.ReadLine()).Split(' ');
        for (int i = 0; i < arrS.Length; i++)
        {
            arr[i] = int.Parse(arrS[i]);
        }
        return arr;
    }
}