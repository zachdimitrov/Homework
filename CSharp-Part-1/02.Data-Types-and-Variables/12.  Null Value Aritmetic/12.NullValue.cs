using System;

class NullValue
{
    static void Main()
    {
        int? nullInt = null;
        double? nullDoub = null;
        Console.WriteLine("print numbers: {0}, {1}", nullInt, nullDoub);
        Console.WriteLine("add Null: {0}, {1}", nullInt + null, nullDoub + null);
        Console.WriteLine("add 10: {0}, {1}", nullInt + 10, nullDoub + 10);
    }
}

/*
Null Values Arithmetic
Description

Create a program that assigns null values to an integer and to a double variable.

Try to print these variables at the console.
Try to add some number or the null literal to these variables and print the result.
Submission

You do not have to submit anything for this problem
*/
