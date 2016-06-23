namespace ExtMethodsLambdaLINQ.Extention
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Problem 1. StringBuilder Substring
    /// </summary>
    public static class StringBuilderExt
    {
        /// <summary>
        /// Extention method SubString
        /// </summary>
        public static StringBuilder SubString(this StringBuilder s, int i, int length)
        {
            CheckIfValid(s, i, length);
            var result = new StringBuilder(s.ToString(i, length));
            return result;
        }
        /// <summary>
        /// Validator
        /// </summary>
        private static void CheckIfValid(StringBuilder s, int i, int length)
        {
            if (i < 0 || i > s.Length)
            {
                throw new ArgumentOutOfRangeException("Index 'i' was out of range!");
            }
            if (length < 0 || length > s.Length - i)
            {
                throw new ArgumentException("Length is not accepted!");
            }
        }
    }
}
