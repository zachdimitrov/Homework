using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToEnterNumbers
{
    class EnterNum
    {
        static void Main()
        {
            try
            {
                EnterNumbers(1, 100, 10);
            }
            catch (Exception)
            {
                Console.WriteLine("Exception");
            }
        }
        static void EnterNumbers(int start, int end, int count)
        {
            List<int> numbers = new List<int>();
            for (int i = 0; i < count; i++)
            {
                numbers.Add(int.Parse(Console.ReadLine()));
            }
            for (int j = 0; j < numbers.Count - 1; j++)
            {
                    if (numbers[j] <= start || numbers[j + 1] <= numbers[j] || numbers[j + 1] >= end)
                    {
                        throw new ArgumentException();
                    }
            }
            Console.Write("{0} < ", start);
            Console.Write(String.Join(" < ", numbers));
            Console.WriteLine(" < {0}", end);
        }
    }
}
