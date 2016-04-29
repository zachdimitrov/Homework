using System;
using System.Numerics;

class SecretOfNumbers
{
    static void Main()
    {
        BigInteger N = BigInteger.Parse(Console.ReadLine());
        if (N<0)
        {
            N *= -1;
        }
        string stringN = N + "";
        int sum = new int();
        int j = 1;
        for (int i = stringN.Length - 1; i >= 0; i = i - 2)
        {

            sum = sum + int.Parse(stringN[i] + "") * j * j;
            if (i > 0)
            {
                sum = sum + int.Parse(stringN[i - 1] + "") * int.Parse(stringN[i - 1] + "") * (j + 1);
            }
            j = j + 2;
        }
        Console.WriteLine(sum);
        int alfaLength = sum % 10;
        int R = sum % 26;
        string alfa = "";
        if (alfaLength == 0)
        {
            Console.WriteLine("{0} has no secret alpha-sequence", N);
        }
        else
        {
            int ch = R + 65;
            for (int k = 0; k < alfaLength; k++)
            {
                    if (ch > 90)
                    {
                        ch = 65;
                    }
                    char letter = Convert.ToChar(ch);
                    alfa = alfa + letter;
                ch = ch + 1;
            }
        }
        Console.WriteLine(alfa);
    }
}