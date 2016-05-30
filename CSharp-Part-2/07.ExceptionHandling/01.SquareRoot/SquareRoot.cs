using System;

namespace ToSquareRoot
{
    class SquareRoot
    {
        static void Main()
        {
            try
            {
                double number = double.Parse(Console.ReadLine());
                if (number < 0 || number == 0 || number == double.NaN)
                {
                    throw new Exception("Invalidnumber");
                }
                else
                {
                    double result = Math.Sqrt(number);
                    Console.WriteLine("{0:F3}", result);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}
