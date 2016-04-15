using System;

class GCD
{
    static void Main()
    {
        string AB = Console.ReadLine();
        int A = new int();
        int B = new int();
        string[] numbers = AB.Split(' ');
        A = Math.Abs(int.Parse(numbers[0]));
        B = Math.Abs(int.Parse(numbers[1]));
        while (A>=1 && B>=1)
        {
            if (A == B)
            {
                Console.WriteLine(A);
                break;
            }
            if (A > B)
            {
                A = A - B;
            }
            if (B > A)                                      
            {
                B = B - A;
            }
        }
    }
}
