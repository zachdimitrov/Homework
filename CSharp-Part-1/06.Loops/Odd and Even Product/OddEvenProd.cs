using System;


class OddEvenProd
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        string readNumbers = Console.ReadLine();
        ulong evenProduct = 1;
        ulong oddProduct = 1;
        for (int i = 0; i <= readNumbers.Length; i=i+4)
        {
            evenProduct *= ulong.Parse(readNumbers[i]+"");
        }
        for (int i = 2; i <= readNumbers.Length; i=i+4)
        {
            oddProduct *= ulong.Parse(readNumbers[i]+"");
        }
        if (evenProduct == oddProduct)
        {
            Console.WriteLine("yes {0}", evenProduct);
        }
        else
        {
            Console.WriteLine("no {1} {0}", oddProduct, evenProduct);
        }
    }
}
