using System;

class charArrays
{
    static void Main()
    {
        string arr1 = Console.ReadLine();
        string arr2 = Console.ReadLine();
        int result = 0;
        if (arr1.Length < arr2.Length)
        {
            result = 1;
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] < arr2[i])
                {
                    result = 1; break;
                }
                else if (arr1[i] > arr2[i])
                {
                    result = 2; break;
                }
            }
        }
        else if (arr1.Length > arr2.Length)
        {
            result = 2;
            for (int i = 0; i < arr2.Length; i++)
            {
                if (arr1[i] < arr2[i])
                {
                    result = 1; break;
                }
                else if (arr1[i] > arr2[i])
                {
                    result = 2; break;
                }
            }
        }
        else if (arr1.Length == arr2.Length)
        {
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] < arr2[i])
                {
                    result = 1; break;
                }
                else if (arr1[i] > arr2[i])
                {
                    result = 2; break;
                }
            }
        }
        switch (result)
        {
            case 0: Console.WriteLine("="); break;
            case 1: Console.WriteLine("<"); break;
            case 2: Console.WriteLine(">"); break;
        }
    }
}