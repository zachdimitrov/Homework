using System;

class LargerNeighbours
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
        int count = 0;
        for (int j = 0; j < arr.Length; j++)
        {
            if (checkNeighbous(arr, j))
            {
                count++;
            }
        }
        Console.WriteLine(count);
    }

    private static bool checkNeighbous(int[] arr, int j)
    {
        bool result = false;
        if (j == 0 || j == arr.Length -1 )
        {
            result = false;
            return result;
        }
        else if (arr[j] > arr[j - 1] && arr[j] > arr[j + 1])
        {
            result = true;
        }
        return result;
    }
}