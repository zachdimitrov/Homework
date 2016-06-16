namespace DefineClasses2
{
    using System;
    using DefineClasses2.Matrices;
    using DefineClasses2.Point;

    /// <summary>
    /// Main Class
    /// </summary>
    /// 
    [Version(1, 0)]
    class ProgramStart
    {
        static void Main()
        {
            Console.WriteLine(TestAttribute.PrintInfo(typeof(Matrix<>)));
            Console.WriteLine("===============================");
            Console.WriteLine("PROBLEMS 1, 2, 3, 4 - POINT TEST");
            Console.WriteLine("===== Add and print Point =====");
            Point3D point = new Point3D(5, 5, 7);
            Console.WriteLine(point);

            Console.WriteLine("--------- static point O ------");
            Console.WriteLine(Point3D.Origin);

            Console.WriteLine("===== Read Path from file =====");
            Console.WriteLine("      and write to output");
            Path way = new Path();
            way = PathStorage.Load(@"..\..\input.txt");
            Console.WriteLine(way);
            PathStorage.Save("output.txt", way);
            Console.WriteLine("------- calculate distance ----");
            Console.WriteLine(Calculate.Distance(Point3D.Origin, point));

            Console.WriteLine("===============================");
            Console.WriteLine("PROBLEMS 5, 6, 7 - GENERIC LIST");
            Console.WriteLine("=== Properties and Methods ====");
            GenericList<int> gen = new GenericList<int>();
            gen.Add(1, -5, 6, -8, 22, -124);
            gen.AddAt(-11, 5);
            Console.WriteLine("Count:    {0}", gen.Count);
            Console.WriteLine("Capacity: {0}", gen.Capacity);

            Console.WriteLine("-------------------------------- original list");
            Console.WriteLine(gen + "\n");

            Console.WriteLine("-------------------------------- print value at index");
            Console.WriteLine(gen[5] + "\n");

            Console.WriteLine("-------------------------------- remove value at index");
            gen.RemoveAt(6);
            Console.WriteLine(gen + "\n");
            Console.WriteLine("-------------------------------- find value (returns index if found and -1 if not)");
            Console.WriteLine(gen.Find(11) + "\n");
              
            Console.WriteLine("-------------------------------- print MAX and MIN values");
            Console.WriteLine(gen.Max());
            Console.WriteLine(gen.Min() + "\n");

            Console.WriteLine("===============================");
            Console.WriteLine("PROBLEMS 8, 9, 10 - MATRIX TEST");
            Console.WriteLine("================ Matrix m =====");
            var m = new Matrix<int>(5, 5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20);
            Console.WriteLine(m);
            Console.WriteLine("========== Matrix n ===========");
            var n = new Matrix<int>(5, 5, 2, 5, 1, 7, 3, 2, 4, 6, 3, 1, 2, 7, 3, 1, 10, 21, 12, 3, 334, 1, 126, 57, 2, 12, 21);
            Console.WriteLine(n);
            Console.WriteLine("========== Operator + =========");
            Console.WriteLine(m + n);
            Console.WriteLine("========== Operator - =========");
            Console.WriteLine(m - n);
            Console.WriteLine("========== Operator * =========");
            Console.WriteLine(m * n);
            Console.WriteLine("=== Operators True and False ==");
            var r = new Matrix<int>(0, 0, 0, 0, 0);
            if (m)
            {
                Console.WriteLine("m returned - true");
            }
            else
            {
                Console.WriteLine("m returned - false");
            }
            if (r)
            {
                Console.WriteLine("r returned - true");
            }
            else
            {
                Console.WriteLine("r returned - false");
            }
        }
    }
}
