using System;
using System.Collections.Generic;

class findSumInArray
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
        Console.WriteLine("check number is: {0}", ss);
        List<int> subList = new List<int>();
        int s = ss;
        for (int j = 0; j < arr.Length; j++)
        {
            for (int k = j; k < arr.Length; k++)
            {
                s -= arr[k];
                subList.Add(arr[k]);
                if (s == 0)
                {
                    Console.Write("result list is: ");
                    for (int l = 0; l < subList.Count; l++)
                    {
                        Console.Write(subList[l]);
                        if (l < subList.Count - 1)
                        {
                            Console.Write(", ");
                        }
                    }
                    Console.WriteLine();
                    break;
                }
                else if (s < 0)
                {
                    subList.Clear();
                    s = ss;
                }
            }
        }
        if (subList.Count == 0)
        {
            Console.WriteLine("sorry, there is no subsequence with sum = {0} in the given list!", ss);
        }
    }
}