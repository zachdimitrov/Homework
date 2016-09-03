// <copyright file="IWriter.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CodeFormatting
{
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
}
