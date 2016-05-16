using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Methods
{
    static void Main() // Useful Code Lines
    {
      int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();  // read array printed on 1 line
    }
    // Useful Methods To Use in Programs
    private static string[] ReceiveStringArray(int size) // Receive String Array from Console
    {
        string[] arr = new string[size];
        arr = (Console.ReadLine()).Split(' ');
        return arr;
    }
    private static int[] ReceiveIntArray() // Receive Int Array from Console
    {
        string[] arrS = (Console.ReadLine()).Split(' ');
        int[] arr = new int[arrS.Length];
        for (int i = 0; i < arrS.Length; i++)
        {
            arr[i] = int.Parse(arrS[i]);
        }
        return arr;
    }
    private static void PrintReverse(List<string> sum) // Print String List
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
    private static string[] ReverseArray(string[] arr) // Reverse String Array
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
    private static string ReverseString(string s) // Reverse String
    {
        char[] arr = s.ToCharArray();
        Array.Reverse(arr);
        return new string(arr);
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
}