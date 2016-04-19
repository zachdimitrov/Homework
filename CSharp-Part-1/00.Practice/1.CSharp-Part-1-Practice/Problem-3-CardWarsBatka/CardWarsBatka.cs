using System;
using System.Numerics;

class CardWarsBatka
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        string card = "";
        int points = 0;
        BigInteger resultA = 0;
        BigInteger resultB = 0;
        bool xcardA = false;
        bool xcardB = false;
        int gamesA = 0;
        int gamesB = 0;
        BigInteger iresultA = 0;
        BigInteger iresultB = 0;

        for (int i = 0; i < N; i++)
        {
            iresultA = 0;
            iresultB = 0;
            int j = 0;
            for (j = 0; j < 3; j++)
            {
                card = Console.ReadLine();
                if (card == "Z")
                {
                    resultA = resultA * 2;
                }
                if (card == "Y")
                {
                    resultA = resultA - 200;
                }
                if (card == "X")
                {
                    xcardA = true;
                }
                iresultA += calculate(card, points);
            }
            for (j = 3; j < 6; j++)
            {
                card = Console.ReadLine();
                if (card == "Z")
                {
                    resultB = resultB * 2;
                }
                if (card == "Y")
                {
                    resultB = resultB - 200;
                }
                if (card == "X")
                {
                    xcardB = true;
                }
                iresultB += calculate(card, points);
            }
            if (xcardA && !xcardB)
            {
                Console.WriteLine("X card drawn! Player one wins the match!");
                return;
            }
            else if (xcardB && !xcardA)
            {
                Console.WriteLine("X card drawn! Player two wins the match!");
                return;
            }
            else if (xcardA && xcardB)
            {
                resultA += 50;
                resultB += 50;
                xcardA = false;
                xcardB = false;
            }
            if (iresultA > iresultB)
            {
                resultA += iresultA;
                gamesA++;
            }
            else if (iresultB > iresultA)
            {
                resultB += iresultB;
                gamesB++;
            }
        }
        if (resultA > resultB)
        {
            Console.WriteLine("First player wins!");
            Console.WriteLine("Score: {0}", resultA);
            Console.WriteLine("Games won: {0}", gamesA);
        }
        else if (resultB > resultA)
        {
            Console.WriteLine("Second player wins!");
            Console.WriteLine("Score: {0}", resultB);
            Console.WriteLine("Games won: {0}", gamesB);
        }
        else if (resultA == resultB)
        {
            Console.WriteLine("It's a tie!");
            Console.WriteLine("Score: {0}", resultA);
        }
    }

    private static int calculate(string card, int pp)
    {
        switch (card)
        {
            case "2": pp = 10;
                break;
            case "3": pp = 9;
                break;
            case "4": pp = 8;
                break;
            case "5": pp = 7;
                break;
            case "6": pp = 6;
                break;
            case "7": pp = 5;
                break;
            case "8": pp = 4;
                break;
            case "9": pp = 3;
                break;
            case "10": pp = 2;
                break;
            case "A": pp = 1;
                break;
            case "J": pp = 11;
                break;
            case "Q": pp = 12;
                break;
            case "K": pp = 13;
                break;
        }
        return pp;
    }
}