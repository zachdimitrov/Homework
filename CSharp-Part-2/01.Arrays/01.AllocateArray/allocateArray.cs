using System;

class allocateArray
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = i * 5;
            Console.WriteLine(arr[i]);
        }
    }
}