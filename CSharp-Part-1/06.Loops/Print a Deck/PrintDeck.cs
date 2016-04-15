using System;

class PrintDeck
{
    static void Main()
    {
        string result = "";
        string[] cards = new string[] 
        {
            "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"
        };
        string[] paints = new string[]
        {
            "spades", "clubs", "hearts", "diamonds"
        };
        string input = Console.ReadLine();
        for (int i = 0; i < cards.Length; i++)
        {
            if (cards[i] == input)
            {
                for (int j = 0; j <= i; j++)
                {
                    for (int k = 0; k < paints.Length; k++)
                    {
                        result = result + ", " + (cards[j] + " of " + paints[k]);
                    }
                    Console.WriteLine(result.Remove(0,2));
                    result = "";
                }
            }
        }
    }
}
