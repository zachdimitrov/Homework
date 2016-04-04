using System;
using System.Text;

class IsoscelesTriangle
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        char ch = '\u00a9';
        Console.WriteLine("   {0}", ch);
        Console.WriteLine(" ");
        Console.WriteLine("  {0} {0}", ch);
        Console.WriteLine(" ");
        Console.WriteLine(" {0}   {0}", ch);
        Console.WriteLine(" ");
        Console.WriteLine("{0} {0} {0} {0}", ch);
    }
}

/*
Isosceles Triangle
Description

Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:

   ©

  © ©

 ©   ©

© © © ©
Note: The © symbol may be displayed incorrectly at the console so you may need to change the console character encoding to UTF-8 and assign a Unicode-friendly font in the console.

Note: Under old versions of Windows the © symbol may still be displayed incorrectly, regardless of how much effort you put to fix it.

Submission

You do not have to submit anything for this problem
*/