using System;

public class CharsInString
{
    public static void Main()
    {

        int count = 0;
        bool rev = false;
        int tests = int.Parse(Console.ReadLine());
        for (int i = 0; i < tests; i++)
        {
            string s = Console.ReadLine();
            if (s.Length % 2 == 0)
            {
                for (int j = 0; j < s.Length; j++)
                {
                    for (int k = 0; k < s.Length; k++)
                    {
                        if (j != k)
                        {
                            if (s[j] == s[k])
                            {
                                count++;
                            }
                        }
                    }
                    if (count == (s.Length / 2) - 1)
                    {
                        rev = true;
                        break;
                    }
                    count = 0;
                }
            }
            if (rev)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            rev = false;
            count = 0;
        }
    }
}
