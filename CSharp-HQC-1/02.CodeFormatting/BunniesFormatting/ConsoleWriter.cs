// <copyright file="ConsoleWriter.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace High.Quality.Code.BadExample
{
    using System;
    using CodeFormatting;

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
}