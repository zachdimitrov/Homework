namespace EvilConductors
{
    using System;

    class Conductor
    {
        static void Main()
        {
            int perforatingChecker = int.Parse(Console.ReadLine());
            int numberOfTickets = int.Parse(Console.ReadLine());

            int ticket = 0;
            int test = 0;
            int testTicket = 0;
            int perforatorDigits = Convert.ToString(perforatingChecker, 2).Length;

            for (int count = 0; count < numberOfTickets; count++)
            {
                ticket = int.Parse(Console.ReadLine());

                for (int binaryDigits = 0; binaryDigits < 32 - perforatorDigits; binaryDigits++)
                {
                    testTicket = ticket >> binaryDigits;

                    for (int k = 0; k < perforatorDigits; k++)
                    {
                        int mask = (perforatingChecker >> k) & 1;
                        int checkValue = (testTicket >> k) & 1;

                        if (checkValue == mask)
                        {
                            test++;
                        }
                    }

                    if (test == perforatorDigits)
                    {
                        for (int countOfDigits = binaryDigits; countOfDigits < binaryDigits + perforatorDigits; countOfDigits++)
                        {
                            int zero = ~(1 << countOfDigits);
                            ticket = (int)(ticket & zero);
                        }
                    }

                    test = 0;
                }

                Console.WriteLine(ticket);
            }
        }
    }
}