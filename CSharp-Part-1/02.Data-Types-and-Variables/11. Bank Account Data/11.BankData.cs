using System;

class BankData
{
    static void Main()
    {
        string fName = "Ivan";
        string mName = "Petrov";
        string lName = "Dimitrov";
        decimal balance = 123.35M;
        string bank = "Unicredit Bulbank";
        string iban = "BG23UNCR23213048372";
        ulong creditCardOne = 1122334455667788;
        ulong creditCardTwo = 8877665544332211;
        ulong creditCardThr = 1827365120228382;

        Console.WriteLine("Full name: {0} {1} {2}", fName, mName, lName);
        Console.WriteLine("Available ammount: {0}lv.", balance);
        Console.WriteLine("Bank: {0}", bank);
        Console.WriteLine("IBAN: {0}", iban);
        Console.WriteLine("Credit card numbers:");
        Console.WriteLine(creditCardOne);
        Console.WriteLine(creditCardTwo);
        Console.WriteLine(creditCardThr);
    }
}

/*
Bank Account Data
Description

A bank account has a 
holder name (first name, middle name and last name), 
available amount of money (balance), 
bank name, 
IBAN, 
3 credit card numbers associated with the account. 

Declare the variables needed to keep the information for a 
single bank account using the appropriate data types and descriptive names.

Submission

You do not have to submit anything for this problem
*/
