using System;
using System.Collections.Generic;
using System.Linq;

namespace DSA
{
    public class Program
    {
        public static void Main(string[] args)
        {
        /// Factorial 
            /*
            // With loop
            Console.WriteLine(Factorial.WithLoop(10));            
            
            // With recursion
            Console.WriteLine(Factorial.WithRecursion(10));

            // Iterative
            long[] factorial = new long[21];
            factorial[0] = 1;
            for (int i = 1; i < factorial.Length; i++)
            {
                factorial[i] = factorial[i-1] * i;
            }
            Console.WriteLine(factorial[8]);
            */

        /// Binary and any system vectors
            /*
            BinVectors.Output(8);
            
            DecVectors.Output(3);
            */

        /// Eight queeens problem
            /* int n = 8; // http://oeis.org/
            Console.WriteLine(EightQueens.Queens(n, new bool[n, n]));
            */

        /// Sudocu
            /*
            int[,] table = 
            {
                {0,0,0, 0,0,0, 0,0,0},
                {0,0,0, 0,0,3, 0,8,5},
                {0,0,1, 0,2,0, 0,0,0},

                {0,0,0, 5,0,7, 0,0,0},
                {0,0,4, 0,0,0, 1,0,0},
                {0,9,0, 0,0,0, 0,0,0},

                {5,0,0, 0,0,0, 0,7,3},
                {0,0,2, 0,1,0, 0,0,0},
                {0,0,0, 0,4,0, 0,0,9}                
            };

            Sudocu.Solve(table);

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Console.Write("  " + table[i, j]);
                }
                Console.WriteLine();
            }
            */

        /// Fibonacci numbers
            /*
            Fibonacci.FibMemo = new decimal[100];
            int n = 50;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(Fibonacci.WithRecursion(i));
            }
            */

        /// Variations
            /*
            int n = 10; // broi elementi
            int k = 8;  // broi pozicii
            Console.WriteLine(Variations.Calculate(k, n));
            Console.WriteLine(Variations.Generate(k, n));
            */

        /// Permutations with repetitions
            /*
            var groups = new List<int> {1, 1, 1, 2};
            Permutation.Calculate(groups.Sum(), groups, new List<int>());
            */
        
        /// Iterative solution
            /*
            var array = new int[] {1,3,3,2,6,6};
            do
            {
                System.Console.WriteLine(string.Join(" ", array));
            }
            while(Permutation.Iterate(array));
            */

        /// Combinations
            /*
            Combination.Calculate(7, 3, new List<int>());
            */
        }
    }
}
