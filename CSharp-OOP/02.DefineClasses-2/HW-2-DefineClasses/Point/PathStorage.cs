namespace DefineClasses2.Point
{
    using System;
    using System.IO;
    using System.Linq;

    /// <summary>
    /// read Point() from file input.txt and write to output.txt
    /// </summary>

    public static class PathStorage
    {
        public static Path p = new Path();

        public static Path Load(string filePath)
        {
            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {

                        char[] toTrim = { '(', ')' };
                        line = line.Trim(toTrim);
                        char[] toSplit = { ',', ' ' };
                        double[] coords = line.Split(toSplit, StringSplitOptions.RemoveEmptyEntries).Select(x => double.Parse(x)).ToArray();
                        p.AddPoint(coords[0], coords[1], coords[2]);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read!");
                Console.WriteLine("Error message:");
                Console.WriteLine(e.Message);
            }
            return p;
        }

        public static void Save(string path, Path p)
        {
            try
            {
                using (StreamWriter sr = new StreamWriter(path))
                {
                        sr.WriteLine(p);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file was not found!");
                Console.WriteLine("Error message:");
                Console.WriteLine(e.Message);
            }
        }
    }
}
