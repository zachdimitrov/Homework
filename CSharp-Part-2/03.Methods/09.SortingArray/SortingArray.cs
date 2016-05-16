using System;
using System.Collections.Generic;

class SortingArray
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = ReceiveIntArray(n);
        SortArray(arr);
        int[] sorted = arr;
        Console.WriteLine(String.Join(" ", sorted));
    }

    private static void SortArray(int[] arr) // Sorting Int Array
    {
        int temp = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] > arr[j])
                {
                    temp = arr[j];
                    arr[j] = arr[i];
                    arr[i] = temp;
                }
            }
        }
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