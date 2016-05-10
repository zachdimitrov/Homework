using System;

class maxSequence
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        int count = 1;
        int result = 1;
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        for (int j = 0; j < arr.Length - 1; j++)
        {
            if (arr[j+1] == arr[j])
            {
                count++;
                if (count > result)
                {
                    result = count;
                }
            }
            else
            {
                count = 1;
            }
        }
        Console.WriteLine(result);
    }
}