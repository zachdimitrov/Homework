namespace Problem_3_RangeException
{
    using System;
    using System.Globalization;

    class ExceptionTestStart
    {
        static void Main()
        {
            Console.WriteLine("Select [1] for Number test or [2] for Date test?");
            if (Console.ReadLine() == "1")
            {

                Console.WriteLine("Input a number between [1 … 100]");
                double input = double.Parse(Console.ReadLine());
                if (input >= 1 && input <= 100)
                {
                    Console.WriteLine($"Number {input} is correct!");
                }
                else
                {
                    throw new InvalidRangeException<double>("Input was not in the range [1 … 100]", 1, 100);
                }
            }
            else
            {
                Console.WriteLine("Input a date between [1.1.1980 … 31.12.2016]");
                string[] dateString = Console.ReadLine().Split('.');
                var date = new DateTime(int.Parse(dateString[2]), int.Parse(dateString[1]), int.Parse(dateString[0]));
                var min = new DateTime(1980, 01, 01);
                var max = new DateTime(2016, 12, 31);

                if (date.CompareTo(min) > 0 && date.CompareTo(max) < 0)
                {
                    Console.WriteLine($"Date {date.ToString("dd.MM.yyyy")} is correct!");
                }
                else
                {
                    throw new InvalidRangeException<double>("Input was not in the range [1.1.1980 … 31.12.2016]");
                }
            }  
        }
    }
}
