using System;
using CohesionAndCoupling.Utilities;
using CohesionAndCoupling.Models;

namespace CohesionAndCoupling
{
    class UtilsExamples
    {
        static void Main()
        {
            Console.WriteLine(FileUtils.GetFileExtension("example"));
            Console.WriteLine(FileUtils.GetFileExtension("example.pdf"));
            Console.WriteLine(FileUtils.GetFileExtension("example.new.pdf"));

            Console.WriteLine(FileUtils.GetFileNameWithoutExtension("example"));
            Console.WriteLine(FileUtils.GetFileNameWithoutExtension("example.pdf"));
            Console.WriteLine(FileUtils.GetFileNameWithoutExtension("example.new.pdf"));

            Console.WriteLine("Distance in the 2D space = {0:f2}",
                CalcUtils.CalcDistance2D(1, -2, 3, 4));
            Console.WriteLine("Distance in the 3D space = {0:f2}",
                CalcUtils.CalcDistance3D(5, 2, -1, 3, -6, 4));

            var prism = new Prism(3, 4, 5);
         
            Console.WriteLine("Volume = {0:f2}", prism.CalculateVolume());
            Console.WriteLine("Diagonal XYZ = {0:f2}", prism.CalculateDiagonal3D());
            Console.WriteLine("Diagonal XY = {0:f2}", prism.CalculateDiagonal2D("XY"));
            Console.WriteLine("Diagonal XZ = {0:f2}", prism.CalculateDiagonal2D("XZ"));
            Console.WriteLine("Diagonal YZ = {0:f2}", prism.CalculateDiagonal2D("YZ"));
        }
    }
}
