using System;
using System.Collections.Generic;

class subsetKsumS
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
        int kk = int.Parse(Console.ReadLine());
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
        Console.WriteLine("length of subset is: {0}", kk);

        List<int> subset = new List<int>();
        bool result = new bool();

        // don't use method
        string[] bin = new string[(int)Math.Pow(2, arr.Length)];
        for (int i = 0; i < bin.Length; i++)
        {
            bin[i] = Convert.ToString(i, 2).PadLeft(arr.Length, '0');
        }
        int sum = 0;
        int count = 0;
        for (int j = 0; j < bin.Length; j++)
        {
            sum = 0;
            subset.Clear();
            for (int k = 0; k < arr.Length; k++)
            {
                if (bin[j][k] == '1')
                {
                    sum += arr[k];
                    subset.Add(arr[k]);
                }
            }
            result = sum == ss;
            if (result == true && subset.Count == kk)
            {
                Console.WriteLine(String.Join(", ", subset));
                count++;
            }
        }
        // don't use method

        if (count > 0)
        {
            Console.WriteLine("yes there are {0} subsets of {1} elements that have sum of {2}", count, kk, ss);
            // Console.WriteLine(String.Join(", ", subset));
        }
        else
        {
            Console.WriteLine("No subset with sum of {0} exists!", ss);
        }
    }

    private static void CheckSubsets(int[] arr, int ss, List<int> subset, bool result)
    {
        string[] bin = new string[(int)Math.Pow(2, arr.Length)];
        for (int i = 0; i < bin.Length; i++)
        {
            bin[i] = Convert.ToString(i, 2).PadLeft(arr.Length, '0');
        }
        int sum = 0;
        for (int j = 0; j < bin.Length; j++)
        {
            sum = 0;
            subset.Clear();
            for (int k = 0; k < arr.Length; k++)
            {
                if (bin[j][k] == '1')
                {
                    sum += arr[k];
                    subset.Add(arr[k]);
                }
            }
            result = sum == ss;
            if (result == true)
            {
                return;
            }
        }
    }
}