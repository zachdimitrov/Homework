using System;
using System.Numerics;

class Speeds
{
    static void Main()
    {
        int c = int.Parse(Console.ReadLine());
        int count = 1;
        decimal frontSpeed = decimal.Parse(Console.ReadLine());
        decimal speedSum = frontSpeed;
        int finalCount = 1;
        decimal finalSpeedSum = speedSum;
        decimal nextSpeed = 0;
        for (int i = 0; i < c - 1; i++)
        {
            decimal speed = decimal.Parse(Console.ReadLine());
            nextSpeed = speed;
            if (nextSpeed > frontSpeed)
            {
                speedSum += nextSpeed;
                count++;
                if (count > finalCount)
                {
                    finalCount = count;
                    finalSpeedSum = speedSum;
                }
                else if (count == finalCount)
                {
                    if (speedSum > finalSpeedSum)
                    {
                        finalSpeedSum = speedSum;
                    }
                }
            }
            if (nextSpeed <= frontSpeed)
            {
                count = 1;
                if (count > finalCount)
                {
                    finalSpeedSum = speedSum;
                }
                else if (count == finalCount)
                {
                    if (speedSum > finalSpeedSum)
                    {
                        finalSpeedSum = speedSum;
                    }
                }
                speedSum = nextSpeed;
            }
            frontSpeed = nextSpeed;
        }
        Console.WriteLine(finalSpeedSum);
    }
}
