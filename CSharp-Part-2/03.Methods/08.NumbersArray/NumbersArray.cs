using System;
using System.Collections.Generic;

class NumbersArray
{
    static void Main()
    {
        string[] sizes = Console.ReadLine().Split(' ');
        int size1 = int.Parse(sizes[0]);
        int size2 = int.Parse(sizes[1]);
        string[] arr1 = new string[size1];
        arr1 = ReceiveArray(size1);
        string[] arr2 = new string[size2];
        arr2 = ReceiveArray(size2);
        List<string> sum = SumArrays(arr1, arr2);
        PrintReverse(sum);
    }

    private static void PrintReverse(List<string> sum)
    {
        for (int i = 0; i < sum.Count; i++)
        {
            if (i < sum.Count - 1)
            {
                Console.Write("{0} ", sum[i]);
            }
            else
            {
                Console.WriteLine("{0}", sum[i]);
            }
        }
    }

    private static List<string> SumArrays(string[] arr1, string[] arr2)
    {
        int longer = arr1.Length > arr2.Length ? arr1.Length : arr2.Length;
        int shorter = arr1.Length < arr2.Length ? arr1.Length : arr2.Length;
        int left = 0;
        List<string> sum = new List<string>();
        for (int i = 0; i < longer; i++)
        {
            int numSum = new int();
            if (i < shorter)
            {
                numSum = int.Parse(arr1[i]) + int.Parse(arr2[i]) + left;
            }
            else
            {
                numSum = int.Parse(arr1.Length > arr2.Length ? arr1[i] : arr2[i]) + left;
            }
            if (numSum < 10)
            {
                sum.Add(Convert.ToString(numSum));
                left = 0;
            }
            else
            {
                sum.Add(Convert.ToString(numSum % 10));
                left = 1;
            }
        }
        if (left == 1)
        {
            sum.Add("1");
        }
        return sum;
    }

    private static string[] ReverseArray(string[] arr)
    {
        string[] rev = new string[arr.Length];
        int j = 0;
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            rev[j] = arr[i];
            j++;
        }

        return rev;
    }

    private static string[] ReceiveArray(int size)
    {
        string[] arr = new string[size];
        arr = (Console.ReadLine()).Split(' ');
        return arr;
    }
}