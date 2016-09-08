using System;

namespace Methods
{
    class Methods
    {
        static double CalculateTriangleArea(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentOutOfRangeException("Triangle sides should be positive!");
            }
            double halfPerimeter = (a + b + c) / 2;
            double heronNumber = (halfPerimeter - a) *(halfPerimeter - b) * (halfPerimeter - c);
            double area = Math.Sqrt(halfPerimeter * heronNumber);
            return area;
        }

        static string NumberToDigit(int number)
        {
            string result = string.Empty;
            switch (number)
            {
                case 0: result = "zero"; break;
                case 1: result = "one"; break;
                case 2: result = "two"; break;
                case 3: result = "three"; break;
                case 4: result = "four"; break;
                case 5: result = "five"; break;
                case 6: result = "six"; break;
                case 7: result = "seven"; break;
                case 8: result = "eight"; break;
                case 9: result = "nine"; break;
                default: throw new ArgumentOutOfRangeException("The number is not between 0 and 9!");
            }

            return result;
        }

        static int FindMax(params int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                throw new ArgumentOutOfRangeException("Input array is not the correct format");
            }

            var maxNumber = int.MinValue;

            foreach (var number in numbers)
            {
                if (number > maxNumber)
                {
                    maxNumber = number;
                }
            }

            return maxNumber;
        }

        static void PrintAsNumber(object number, string format)
        {
            if (number == null)
            {
                throw new ArithmeticException("number is not the correct foramt!");
            }

            var formattedString = String.Empty;

            if (format == "f")
            {
                formattedString = String.Format("{0:f2}", number);
            }

            if (format == "%")
            {
                formattedString = String.Format("{0:p0}", number);
            }

            if (format == "r")
            {
                formattedString = String.Format("{0,8}", number);
            }

            Console.WriteLine(formattedString);
        }

        static double CalcDistance(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            return distance;
        }

        static bool areEqual(double startPointCoordinate, double endPointCoordinate)
        {
            return startPointCoordinate == endPointCoordinate;
        }

        static void Main()
        {
            Console.WriteLine(CalculateTriangleArea(3, 4, 5));
            
            Console.WriteLine(NumberToDigit(5));
            
            Console.WriteLine(FindMax(5, -1, 3, 2, 14, 2, 3));
            
            PrintAsNumber(1.3, "f");
            PrintAsNumber(0.75, "%");
            PrintAsNumber(2.30, "r");

            double x1 = 3.0d;
            double y1 = -1.0d;
            double x2 = 3.0d;
            double y2 = 2.5d;

            Console.WriteLine(CalcDistance(x1, y1, x2, y2));
            Console.WriteLine("Horizontal? " + areEqual(x1, x2));
            Console.WriteLine("Vertical? " + areEqual(y1, y2));

            Student peter = new Student() { FirstName = "Peter", LastName = "Ivanov" };
            peter.OtherInfo = "From Sofia, born at 17.03.1992";

            Student stella = new Student() { FirstName = "Stella", LastName = "Markova" };
            stella.OtherInfo = "From Vidin, gamer, high results, born at 03.11.1993";

            Console.WriteLine("{0} older than {1} -> {2}",
                peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }
    }
}
