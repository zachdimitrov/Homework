using System;
using System.Collections.Generic;

class removeFromArray
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        int maxLength = 0;
        int[] len = new int[n];
        
        for (int j = 0; j < arr.Length; j++)
        {
            len[j] = 1;
            for (int k = 0; k < j; k++)
            {
                if (arr[k] <= arr[j] && len[k] + 1 > len[j] )
                {
                    len[j] = len[k] + 1;
                }
                if (len[j] > maxLength)
                {
                    maxLength = len[j];
                }
            }
        }
        Console.WriteLine(n - maxLength);
    }
}