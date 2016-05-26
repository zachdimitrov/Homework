namespace _003.ExtractStrings
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class ExtractString
    {
        static List<int> FindDoubleSlash(string code) // Method 1 - s indeksi
        {
            List<int> indices = new List<int>();
            int nextComment = code.IndexOf("//");
            int nextNewLine = 0;
            while (nextComment != -1 && nextNewLine != -1)
            {
                indices.Add(nextComment);
                nextNewLine = code.IndexOf(Environment.NewLine, nextComment);
                indices.Add(nextNewLine);
                nextComment = code.IndexOf("//", nextNewLine);
            }
            return indices;
        }
        static string ExtractComments(string code) // Method 2 - s tyrsene po simvol
        {
            var result = new StringBuilder();
            bool isSingleLine = false;
            bool isMultiLine = false;
            char last = ' ';
            foreach (char c in code)
            {
                if (isSingleLine || isMultiLine)
                {
                    result.Append(c);
                }
                if (last == '/' && c == '/' && !isMultiLine)
                {
                    isSingleLine = true;
                    result.Append("//");
                }
                if (last == '/' && c == '*' && !isSingleLine)
                {
                    isMultiLine = true;
                    result.Append("/*");
                }
                if (last == '\r' && c == '\n')
                {
                    isSingleLine = false;
                }
                if (last == '*' && c == '/')
                {
                    isMultiLine = false;
                }
                last = c;
            }
            return result.ToString();
        }
        static void Main()
        {
            string code = @"using System;
// this is comment
using System.Collections.Generic;
// this is another // comment
using System.Linq;
/* stupid comment
on two lines */
using System.Text;
using System.Threading.Tasks;";
            Console.WriteLine("----------- Method 1 -------------");  // test na Method 1
            var indices = FindDoubleSlash(code);
            Console.WriteLine(String.Join(", ", indices));
            for (int i = 0; i < indices.Count - 1; i = i + 2)
            {
                int start = indices[i];
                int end = indices[i + 1];
                var comment = code.Substring(start, end - start);
                Console.WriteLine(comment);
            }
            Console.WriteLine("----------- Method 2 -------------"); // test na Method 2
            Console.WriteLine(ExtractComments(code));
            Console.WriteLine("----------- Split Test -----------");
            int[] readFromString = "122 434   55  666"               // Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            Console.WriteLine(String.Join(", ", readFromString));
            Console.WriteLine("------- Count with Split ---------");
            var splitText = code.Split(new[] { "using" }, StringSplitOptions.None);
            for (int i = 0; i < splitText.Length; i++)
            {
                Console.WriteLine(splitText[i]);
            }
            Console.WriteLine("------- Replace Substrings -------");
            var badUserName = "<script> alert </script>";
            var sanitised = badUserName.Replace("<", "&#60;")
                                       .Replace(">", "&#62;");
            Console.WriteLine(sanitised);
            Console.WriteLine("---------- Censorship ------------ ");
            var censorshipSymbols = "@#-%+=$^!%^&*#@%=+";
            var swearWords = new string[]
            {
                "bau",
                "mqu",
                "pur",
                "FAQ",
                "Programist",
                "kraen avtomat",
                "rekursiq"
            };
            var forumPost = @"Kotkite pravqt cur i pur i pishat rekirsiq kato FAQ i edin programist 
                e kraen avtomat mnogo typo izrechenie se poluchi";
            foreach (var swear in swearWords)
            {
                forumPost = forumPost.Replace(" " + swear + " ", " " + censorshipSymbols.Substring(0, swear.Length) + " ");
            }
            Console.WriteLine(forumPost);
            Console.WriteLine("--------- Case Transform -----------");
            string name = "internet";
            Console.WriteLine("Lowercase: {0}", name);
            string nameUpper = name.ToUpper();
            Console.WriteLine("Uppercase: {0}", nameUpper);
            Console.WriteLine("ot F stava " + (char)('F' | ' '));
            Console.WriteLine("ot a stava " + (char)('a' & '_'));
            Console.WriteLine("-------------- Trimming ------------");
            Console.WriteLine("Ot 'aaa 00  01101aaa011' stava " + "aaa 00  01101011".TrimStart('0', ' ', 'a'));
            // TrimEnd - ot dqsno, Trim - ot dvete strani
            Console.WriteLine("------------ Padding ---------------");
            var binary = "110101";
            Console.WriteLine("110101 stava " + binary.PadLeft(16, '0'));
            // PadRight - dobavq otdqsno
            Console.WriteLine("---------- StringBuilder -----------");
            StringBuilder str = new StringBuilder();
            for (int i = 0; i < 10; i++)
            {
                str.Append("a");
            }
            Console.WriteLine(str);
            Console.WriteLine("---------- Compress String ----------");
            var text = "aaaab bbbbbr bc aaaaaa bbbbbbbb";
            var compressed = new StringBuilder();
            char last = text[0];
            int count = 1;
            for (int i = 1; i < text.Length; i++)
            {
                if (text[i-1] == text[i])
                {
                    count++;
                }
                else
                {
                    compressed.Append(text[i]);
                    if (count >= 2)
                    {
                        compressed.Append(count);
                    }
                    count = 1;
                }
            }
            compressed.Append(text[text.Length - 1]);
            if (count >= 2)
            {
                compressed.Append(count);
            }
            Console.WriteLine(compressed);
            Console.WriteLine("------ Methods for StringBuilder -----");
            var builder = new StringBuilder("This i a StringBuilder Demo");
            builder.Append("100");    //dobavq 100 v kraq
            builder.Insert(5, "100"); // dobavq 100 na 5-ta poziciq
            builder.AppendFormat("**{0}**", "aaa");
            builder[9] = 'X';
            Console.WriteLine(builder);

            string example = string.Format("{0, 5} + {1}", 100, 200);
            Console.WriteLine(example);
        }
    }
}
