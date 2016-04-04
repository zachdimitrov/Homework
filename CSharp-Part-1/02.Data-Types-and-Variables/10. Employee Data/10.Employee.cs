using System;

class EmployeeData
{
    static void Main()
    {
        string fName = "Ivan";
        string lName = "Petrov";
        byte age = 33;
        char gender = 'm';
        ulong idNumber = 8306112507;
        uint empNumber = 27561234;

        Console.WriteLine("Full name: {0} {1}", fName, lName);
        Console.WriteLine("Age: {0}", age);
        Console.WriteLine("Gender: {0}", gender);
        Console.WriteLine("Personal ID: {0}", idNumber);
        Console.WriteLine("Unique employee number: {0}", empNumber);
    }
}

/*
Employee Data
Description

A marketing company wants to keep record of its employees. 
Each record would have the following characteristics:

First name
Last name
Age (0...100)
Gender (m or f)
Personal ID number (e.g. 8306112507)
Unique employee number (27560000…27569999)

Declare the variables needed to keep the information 
for a single employee using appropriate primitive data types.
Use descriptive names. Print the data at the console.

Submission

You do not have to submit anything for this problem 
*/
