namespace ExtMethodsLambdaLINQ.Extention
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Problem 2. IEnumerable extensions
    /// </summary>
    public static class IEnumerableExt
    {
        /// <summary>
        /// Returns Sum of elements in collection of any type
        /// </summary>
        public static T eSum<T>(this IEnumerable<T> collection)
        {
            T result = default(T);
            foreach (var item in collection)
            {
                result += item as dynamic;
            }
            return result;
        }
        /// <summary>
        /// Returns Product of elements in collection of any type
        /// </summary>
        public static T eProduct<T>(this IEnumerable<T> collection)
        {
            T result = default(T);
            foreach (var item in collection)
            {
                result *= item as dynamic;
            }
            return result;
        }
        /// <summary>
        /// Returns MIN of elements in collection of any type
        /// </summary>
        public static T eMin<T>(this IEnumerable<T> collection) where T : IComparable
        {
            T result = default(T);
            foreach (var item in collection)
            {
                if (item.CompareTo(result) < 0)
                {
                    result = item;
                }
            }
            return result;
        }
        /// <summary>
        /// Returns MAX of elements in collection of any type
        /// </summary>
        public static T eMax<T>(this IEnumerable<T> collection) where T : IComparable
        {
            T result = default(T);
            foreach (var item in collection)
            {
                if (item.CompareTo(result) > 0)
                {
                    result = item;
                }
            }
            return result;
        }
    }
}
