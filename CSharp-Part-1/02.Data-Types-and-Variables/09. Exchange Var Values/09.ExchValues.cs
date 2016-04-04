using System;

class ExchangeValue
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        int c = a;
        a = b;
        b = c;
        Console.WriteLine("a = {0}, b = {1}", a, b);
    }
}

/*
Exchange Variable Values
Description

Declare two integer variables a and b and assign them with 5 and 10 
and after that exchange their values by using some programming logic. 
Print the variable values before and after the exchange.

Submission

You do not have to submit anything for this problem
*/