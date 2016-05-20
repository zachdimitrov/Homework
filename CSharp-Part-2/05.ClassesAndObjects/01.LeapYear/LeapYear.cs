using System;

class LeapYear
{
    static void Main()
    {
        int year = int.Parse(Console.ReadLine());
        DateTime lastDay = new DateTime(year, 12, 31);
        if (lastDay.DayOfYear == 365)
        {
            Console.WriteLine("Common");
        }
        else
        {
            Console.WriteLine("Leap");
        }
    }
}
