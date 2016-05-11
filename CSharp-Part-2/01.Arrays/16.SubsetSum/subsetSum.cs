using System;
using System.Collections.Generic;

class subsetSum
{
    static void Main()
    {
        string[] n = Console.ReadLine().Split(',');
        int[] arr = new int[n.Length];
        for (int i = 0; i < n.Length; i++)
        {
            arr[i] = int.Parse(n[i]);
        }
        int ss = int.Parse(Console.ReadLine());
        Console.Write("input list is: ");
        for (int p = 0; p < arr.Length; p++)
        {
            Console.Write(arr[p]);
            if (p < arr.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine();
        Console.WriteLine("check sum is: {0}", ss);
        bool result = CheckSubsets(arr, ss);
        if (result)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("No subset with sum of {0} exists!", ss);
        }
    }

    private static bool CheckSubsets(int[] arr, int ss)
    {
        string[] bin = new string[(int)Math.Pow(2, arr.Length)];
        for (int i = 0; i < bin.Length; i++)
        {
            bin[i] = Convert.ToString(i, 2).PadLeft(arr.Length, '0');
        }
        int sum = 0;
        bool check = false;
        for (int j = 0; j < bin.Length; j++)
        {
            sum = 0;
            for (int k = 0; k < arr.Length; k++)
            {
                if (bin[j][k] == '1')
                {
                    sum += arr[k];
                }
            }
            check = sum == ss;
            if (check == true)
            {
                break;
            }
        }
        return check;
    }
}