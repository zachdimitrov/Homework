using System;

namespace ForStringLength
{
    class StringLenght
    {
        static void Main()
        {
                string str = Console.ReadLine();
                str = str.Trim('\n', '\t', ' ');
                string result = str.PadRight(20, '*');
                Console.WriteLine(result);
            
        }
    }
}