using System;

class Appearance
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] nums = Console.ReadLine().Split(' ');
        int[] arr = new int[n];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(nums[i]);
        }
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine(CountAppearance(arr, x));
    }

    private static int CountAppearance(int[] arr, int x)
    {
        int count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == x)
            {
                count++;
            }
        }
        return count;
    }
}