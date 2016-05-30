using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4Konspiration
{
    class Konspiration
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var lines = new string[n];
            for (int i = 0; i < lines.Length; i++)
            {
                lines[i] = Console.ReadLine();
            }
            // drug nachin
            // var lines2 = Enumerable.Range(0, n).Select(x => Console.ReadLine()).ToArray();
            for (int i = 0; i < n; i++)
            {
                if (lines[i].Contains(" static "))
                {
                    var name = lines[i].Split(new[] { ' ', '(' }, StringSplitOptions.RemoveEmptyEntries)[2];
                    i+=2;
                    var openBrackets = 1;
                    var methodCalls = new List<string>();
                    while (openBrackets > 0)
                    {
                        var splitByRdBrackets = lines[i].Split('(');
                        if (splitByRdBrackets.Length > 1)
                        {
                            for (int k = 0; k < splitByRdBrackets.Length - 1; k++)
                            {
                                var methodName = ExtractmethodName(splitByRdBrackets[k]);
                                if (methodName != null)
                                {
                                    methodCalls.Add(methodName);
                                }
                            }
                        }
                        foreach (var symbol in lines[i])
                        {
                            if (symbol == '{')
                            {
                                openBrackets++;
                            }
                            else if(symbol == '}')
                            {
                                openBrackets--;
                            }
                        }
                        i++;
                    }
                    if (methodCalls.Count > 0)
                    {
                        Console.WriteLine(name + " -> " + methodCalls.Count + " -> " + String.Join(", ", methodCalls));
                    }
                    else
                    {
                        Console.WriteLine(name + " -> None");
                    }
                }
            }
        }
        static string ExtractmethodName(string codePiece)
        {
            var beforBracket = codePiece.Split(new[] { ' ', '.', '!' }, StringSplitOptions.RemoveEmptyEntries);
            var methodname = beforBracket[beforBracket.Length - 1];

            if (char.IsUpper(methodname[0]) && !beforBracket.Contains("new"))
            {
                return methodname;
            }
            return null;
        }
    }
}
