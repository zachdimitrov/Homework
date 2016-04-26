using System;
using System.Numerics;

class ConsoleApp1
{
    static void Main()
    {
        BigInteger finalResult1 = 1;
        BigInteger finalResult2 = 1;
        int numberCount = 0;
        for (int i = 0; i < 10; i++)
        {
            string number = Console.ReadLine();
            numberCount++;
            BigInteger result = 1;
            if (number == "END")
            {
                Console.WriteLine(finalResult1);
                return;
            }
            if (number == "0")
            {
                result = 1;
            }
            else
            {
                if (i % 2 != 0)
                {
                    for (int j = 0; j < number.Length; j++)
                    {
                        int digit = int.Parse(number[j] + "");
                        if (digit > 0)
                        {
                            result *= digit;
                        }
                    }
                }
            }
            finalResult1 *= result;
        }
        while (true)
        {
            string number = Console.ReadLine();
            numberCount++;
            BigInteger result = 1;
            if (number == "END")
            {
                break;
            }
            if (number == "0")
            {
                result = 1;
            }
            else
            {
                if (numberCount % 2 == 0)
                {
                    for (int j = 0; j < number.Length; j++)
                    {
                        int digit = int.Parse(number[j] + "");
                        if (digit > 0)
                        {
                            result *= digit;
                        }
                    }
                }
            }
            finalResult2 *= result;
        }
        Console.WriteLine(finalResult1);
        Console.WriteLine(finalResult2);
    }
}
