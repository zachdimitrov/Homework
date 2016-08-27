// <copyright file="Bunnies.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace High.Quality.Code.BadExample
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;

    /// <summary>
    /// simple writer interface
    /// </summary>
    public interface IWriter
    {
        /// <summary>
        /// write a message somewhere on one line
        /// </summary>
        /// <param name="message">string message</param>
        void Write(string message);

        /// <summary>
        /// write message somewhere on a new line
        /// </summary>
        /// <param name="message">string message</param>
        void WriteLine(string message);
    }

    public enum FurType
    {
        /// <summary>not fluffy</summary>
        NotFluffy,

        /// <summary>a little fluffy</summary>
        ALittleFluffy,

        /// <summary>just fluffy</summary>
        Fluffy,

        /// <summary>too fluffy</summary>
        FluffyToTheLimit
    }

    /// <summary>
    /// creates a bunch of bunnies and outputs info about them
    /// </summary>
    public class Bunnies
    {
        /// <summary>
        /// main bunny method
        /// </summary>
        /// <param name="args">main method arguments</param>
        private static void Main(string[] args)
        {
            var bunnies = new List<Bunny>
            {
                new Bunny
                {
                    Name = "Leonid",
                    Age = 1,
                    FurType = FurType.NotFluffy
                },
                new Bunny
                {
                    Age = 2,
                    Name = "Rasputin",
                    FurType = FurType.ALittleFluffy
                },
                new Bunny
                {
                    FurType = FurType.ALittleFluffy,
                    Name = "Tiberii",
                    Age = 3
                },
                new Bunny
                {
                    Name = "Neron",
                    FurType = FurType.ALittleFluffy,
                    Age = 1
                },
                new Bunny
                {
                    Name = "Klavdii",
                    Age = 3,
                    FurType = FurType.Fluffy
                },
                new Bunny
                {
                    Name = "Vespasian",
                    Age = 3,
                    FurType = FurType.Fluffy
                },
                new Bunny
                {
                    Name = "Domician",
                    Age = 4,
                    FurType = FurType.FluffyToTheLimit
                },
                new Bunny
                {
                    Name = "Tit",
                    Age = 2,
                    FurType = FurType.FluffyToTheLimit
                }
            };

            // Introduce all bunnies
            var consoleWriter = new ConsoleWriter();
            foreach (var bunny in bunnies)
            {
                bunny.Introduce(consoleWriter);
            }

            // Create bunnies text file
            var bunniesFilePath = @"..\..\bunnies.txt";
            var fileStream = File.Create(bunniesFilePath);

            fileStream.Close();

            // Save bunnies to a text file
            using (var streamWriter = new StreamWriter(bunniesFilePath))
            {
                foreach (var bunny in bunnies)
                {
                    streamWriter.WriteLine(bunny.ToString());
                }
            }
        }
    }

    [Serializable]
    public class Bunny
    {
        public int Age { get; set; }

        public string Name { get; set; }

        public FurType FurType { get; set; }

        public void Introduce(IWriter writer)
        {
            // sorry, style-cop does not recognise C#-6 here!
            writer.WriteLine($"{this.Name} - \"I am {this.Age} years old!\"");
            writer.WriteLine($"{this.Name} - \"And I am {this.FurType.ToString().SplitToSeparateWordsByUppercaseLetter()}");
        }

        public override string ToString()
        {
            var builderSize = 200;
            var builder = new StringBuilder(builderSize);

            builder.AppendLine($"Bunny name: {this.Name}");
            builder.AppendLine($"Bunny age: {this.Age}");
            builder.AppendLine($"Bunny fur: {this.FurType.ToString().SplitToSeparateWordsByUppercaseLetter()}");

            return builder.ToString();
        }
    }

    /// <summary>
    /// writes to console
    /// </summary>
    public class ConsoleWriter : IWriter
    {
        /// <summary>
        /// writes messages on one line
        /// </summary>
        /// <param name="message">string message</param>
        public void Write(string message)
        {
            Console.Write(message);
        }

        /// <summary>
        /// writes messages on a new line
        /// </summary>
        /// <param name="message">string message</param>
        public void WriteLine(string message)
        {
            Console.WriteLine(message);
        }
    }

    public static class StringExtensions
    {
        /// <summary>
        /// splits a string to separate words by uppercase letter
        /// </summary>
        /// <param name="sequence">string input</param>
        /// <returns>string output</returns>
        public static string SplitToSeparateWordsByUppercaseLetter(this string sequence)
        {
            var probableStringMargin = 10;
            var probableStringSize = sequence.Length + probableStringMargin;
            var builder = new StringBuilder(probableStringSize);
            var singleWhitespace = ' ';

            foreach (var letter in sequence)
            {
                if (char.IsUpper(letter))
                {
                    builder.Append(singleWhitespace);
                }

                builder.Append(letter);
            }

            return builder.ToString().Trim();
        }
    }
}