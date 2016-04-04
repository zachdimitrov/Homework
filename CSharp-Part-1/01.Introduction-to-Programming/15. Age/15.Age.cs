using System;

class Age
{
    static void Main()
    {
        DateTime bDay = DateTime.Parse(Console.ReadLine());
        DateTime today = DateTime.Now;
        TimeSpan age = today - bDay;
        Console.WriteLine(Math.Floor(age.Days/365.25));
        Console.WriteLine(Math.Floor(age.Days / 365.25)+10);
    }
}

/*
 Age
Description

Write a program that reads your birthday(in the format MM.DD.YYYY) from the console and prints on the console how old you are you now and how old will you be after 10 years.

Input

The input will always consist of a single line - a birthdate.
Output

You should print two lines with one number on the each line:
How old are you now, on the first line.
How old will you be after 10 years, on the second line.
Constraints

The date read from the console will always be in a valid DateTime format.
All dates will be earlier than 2016.
Time limit: 0.1s
Memory limit: 16MB
Sample Tests

Input	Output
03.05.2016	0
10
05.16.1994	21
31
Submission

Submit your code here
 */
