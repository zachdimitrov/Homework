// <copyright file="StringExtensions.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace High.Quality.Code.BadExample
{
    using System.Text;

    /// <summary>
    /// extends string 
    /// </summary>
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