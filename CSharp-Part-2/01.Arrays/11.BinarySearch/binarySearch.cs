using System;

class binarySearch
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        int x = int.Parse(Console.ReadLine());
        int first = 0;
        int last = arr.Length;
        int index = -1;
        while (first <= last)
        {
            int mid = (first + last) / 2;
            if (arr[mid] > x)
            {
                last = mid-1;
            }
            else if (arr[mid] < x)
            {
                first = mid+1;
            }
            else
            {
                index = mid;
                break;
            }
        }
        Console.WriteLine(index);
    }
}
