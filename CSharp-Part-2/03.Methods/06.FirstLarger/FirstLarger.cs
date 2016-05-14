using System;

class FirstLarger
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
        int index = FirLarger(arr);
        Console.WriteLine(index);
    }

    private static int FirLarger(int[] arr)
    {
        int result = -1;
        for (int i = 1; i < arr.Length - 1; i++)
        {
            if (arr[i] > arr[i-1] && arr[i] > arr[i + 1])
            {
                result = i;
                break;
            }
        }
        return result;
    }
}