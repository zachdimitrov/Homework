using System;

class DecVar
{
    static void Main()
    {
        byte byteNumber = 97;
        sbyte sbyteNumber = -115;
        short shortNumber = -10000;
        ushort ushortNumber = 52130;
        uint uintNumber = 4825932;

        Console.WriteLine("byte: {0}", byteNumber);
        Console.WriteLine("sbyte: {0}", sbyteNumber);
        Console.WriteLine("short: {0}", shortNumber);
        Console.WriteLine("ushort: {0}", ushortNumber);
        Console.WriteLine("uint: {0}",uintNumber);
    }
}

/*
Declare Variables
Description

Declare five variables choosing for each of them the most appropriate
of the types byte, sbyte, short, ushort, int, uint, long, ulong 
to represent the following values: 52130, -115, 4825932, 97, -10000. 
Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.

Submission

You do not have to submit anything for this problem
*/