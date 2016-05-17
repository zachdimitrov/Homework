using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class NumCalc
{
    static void Main()
    {
        int[] arr = ReceiveIntArray();
        Console.WriteLine(Minimum(arr));
        Console.WriteLine(Maximum(arr));
        Console.WriteLine("{0:F2}", Average(arr));
        Console.WriteLine(Sum(arr));
        Console.WriteLine(Product(arr));
    }

    static T Product<T>(params T[] arr) // Return Product of Int Array
    {
        dynamic prod = 1;
        foreach (var i in arr)
        {
            prod *= i;
        }
        return prod;
    }

    static T Sum<T>(params T[] arr) // Return Sum of Int array
    {
        dynamic sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        return sum;
    }

    static T Average<T>(params T[] arr) // Return Average of Int Array
    {
        dynamic sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        return sum / arr.Length;
    }

    static T Maximum<T>(params T[] arr) // Return Maximum Value
    {
        dynamic max = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }
        return max;
    }

    static T Minimum<T>(params T[] arr) // Return Minimum Value
    {
        dynamic min = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] < min)
            {
                min = arr[i];
            }
        }
        return min;
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
}
