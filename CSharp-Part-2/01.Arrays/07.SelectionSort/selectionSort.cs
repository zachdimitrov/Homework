using System;
using System.Collections.Generic;

class selectionSort
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<int> arr = new List<int>();
        int k, l;
        for (int i = 0; i < n; i++)
        {
            arr.Add(int.Parse(Console.ReadLine()));
        }
        for (k = 0; k < arr.Count; k++)
        {
            int iMin = k;
            for (l = k + 1; l < arr.Count; l++)
            {
                if (arr[l] < arr[iMin])
                {
                    iMin = l;
                }
            }
            if (iMin != k)
            {
                int temp = arr[iMin];
                arr[iMin] = arr[k];
                arr[k] = temp;
            }
        }
        for (int j = 0; j < arr.Count; j++)
        {
            Console.WriteLine(arr[j]);
        }
    }
}