using System;

class Decoding
{
    static void Main()
    {
        int salt = int.Parse(Console.ReadLine());
        double result = 0;
        string text = Console.ReadLine();
        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == '@')
            {
                break;
            }
            if (text[i] >= 48 && text[i]<=57  )
            {
                result = text[i] + salt + 500;
            }
            else if ((text[i]>=65 && text[i]<=90) || (text[i]>=97 && text[i]<=122))
            {
                result = text[i] * salt + 1000;
            }
            else
            {
                result = text[i] - salt;
            }
            // second modification and print
            if (i % 2 != 0)
            {
                result *= 100;
                Console.WriteLine(result);
            }
            else
            {
                result /= 100;
                Console.WriteLine("{0:F2}", result);
            }
        }
    }
}
