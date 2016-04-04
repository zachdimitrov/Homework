using System;

class UnicodeChar
{
    static void Main()
    {
        char test = '\u002A';
        Console.WriteLine("The char with value \\u002A is: {0}", test);
    }
}

/*
Unicode Character
Description

Declare a character variable and assign it with the symbol that has Unicode code 42 (decimal) 
using the \u00XX syntax, and then print it.

Hint: first, use the Windows Calculator to find the hexadecimal representation of 42. The output should be *.

Submission

You do not have to submit anything for this problem
*/