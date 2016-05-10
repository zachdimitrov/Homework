using System;

class maxSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        int sum = 0;
        int maxSum = 0;
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        for (int j = 0; j < arr.Length; j++)
        {
            sum = arr[j];
            for (int k = j+1; k < arr.Length; k++)
            {
                sum += arr[k];
                if (maxSum < sum)
                {
                    maxSum = sum;
                }
            }
        }
        Console.WriteLine(maxSum);
    }
}