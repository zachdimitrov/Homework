using System;

class CompInfo
{
    static void Main()
    {
        string compName = Console.ReadLine();
        string compAddr = Console.ReadLine();
        string phoneNum = Console.ReadLine();
        string faxNum = Console.ReadLine();
        string webSite = Console.ReadLine();
        string manFirstName = Console.ReadLine();
        string manLastName = Console.ReadLine();
        string manAge = Console.ReadLine();
        string manPhone = Console.ReadLine();
        Console.Write("{0}\nAddress: {1}\nTel. {2}\nFax: {3}\nWeb site: {4}\nManager: {5} {6} (age: {7}, tel. {8})", compName, compAddr, phoneNum, faxNum, webSite, manFirstName, manLastName, manAge, manPhone);
    }
}

/*
A company has name, address, phone number, fax number, 
web site and manager. The manager has first name, 
last name, age and a phone number.
Write a program that reads the information about a 
company and its manager and prints it back on the console.

Input

You will each piece of information about the company on a separate line,
in the same order as in the example

Company name
Company address
Phone number
Fax number
Web site
Manager first name
Manager last name
Manager age
Manager phone
Output

Print the information the same way as shown in the sample test. Make sure that you print "(no fax)" if an empty line is passed as fax number.
Constraints

The input will always be in the described format
Only the fax number field can be empty, all other fields will have be least one symbol
Time limit: 0.1s
Memory limit: 8MB
*/
