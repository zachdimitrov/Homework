namespace CommonTypeSystem
{
    using Enumeration;
    using System;
    using System.Collections.Generic;
    class Program
    {
        static void Main()
        {
            Console.WriteLine("+++++ ADD NEW STUDENT +++++");
            Student otlichnik = new Student("Petko", "Mitev", "Gruev");
            otlichnik.Mobile = "0888 012 345";
            otlichnik.Univ = University.UACEG;
            otlichnik.Spec = Speciality.Geodesy;
            otlichnik.Fac = Faculty.Engineering;
            otlichnik.Course = 4;
            otlichnik.Address = "Kurtovo Konare, Plovdivsko, 14 \"Bay Kancho\" str.";
            Console.WriteLine(otlichnik);

            Console.WriteLine("+++++ ADD ANOTHER STUDENT +++++");
            Student slabak = new Student("Kancho", "Ivanov", "Peshev");
            slabak.Mobile = "02 931 34 56";
            slabak.Univ = University.NBU;
            slabak.Spec = Speciality.Architecture;
            slabak.Fac = Faculty.Architecture;
            slabak.Course = 5;
            slabak.Address = "selo Podgumer, Sofiisko, tretata kyshta vlqvo";
            Console.WriteLine(slabak);

            Console.WriteLine("++++++++ CHECK IF EQUAL ++++++++");
            Console.WriteLine("Comparing \"otlichnik\" and \"slabak\"");
            Console.WriteLine($"Using '==': {otlichnik == slabak}");
            Console.WriteLine($"Using '!=': {otlichnik != slabak}");
            Console.WriteLine($"Using ComparetTo: {otlichnik.CompareTo(slabak)}");
            Console.WriteLine();

            Console.WriteLine("++++++ Problem 4 - Person ++++++");
            var man = new Person("Gosho", 25);
            var woman = new Person();
            woman.Name = "Penka";
            woman.Age = null;
            Console.WriteLine(man);
            Console.WriteLine(woman);

            Console.WriteLine("++++++ Problem 5 - Bits ++++++");
            var arr = new BitArray64(123456);
            var newArr = new BitArray64(123456);
            Console.WriteLine(arr);
            Console.WriteLine(newArr);
            Console.WriteLine("----- check if equal -----");
            Console.WriteLine($"With equals: {arr.Equals(newArr)}");
            Console.WriteLine($"With ==: {arr == newArr}");
            Console.WriteLine();
            Console.WriteLine("------ create array ------");
            List<BitArray64> combination = new List<BitArray64>();
            combination.Add(arr);
            combination.Add(newArr);
            combination.Add(new BitArray64(8590389));
            combination.Add(new BitArray64(30234923));
            combination.Add(new BitArray64(1129891));
            combination.Add(new BitArray64(2128199));

            foreach (var item in combination)
            {
                Console.WriteLine(item);
            }
        }
    }
}
