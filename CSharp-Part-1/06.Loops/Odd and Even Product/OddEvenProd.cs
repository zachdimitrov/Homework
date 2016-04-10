using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class OddEvenProd
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        string readNumbers = Console.ReadLine();
        char[] spaces = new char[] { ' ' };
        string[] numbers = readNumbers.Split(spaces);
        int evenProduct = 1;
        int oddProduct = 1;
        for (int i = 0; i < numbers.Length; i++)
        {
            int number = int.Parse(numbers[i]);
            if (number % 2 == 0)
            {
                evenProduct *= number;
            }
            else
            {
                oddProduct *= number;
            }
            // Console.WriteLine(numbers[i]);
        }
        if (evenProduct == oddProduct)
        {
            Console.WriteLine("yes {0}", evenProduct);
        }
        else
        {
            Console.WriteLine("no {0} {1}", oddProduct, evenProduct);
        }
    }
}
