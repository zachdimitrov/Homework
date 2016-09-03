namespace CreatePerson
{
    using System;

    class StartUp
    {
        static void Main(string[] args)
        {
            // Just for test
            var Pesho = new Person(22);
            Console.WriteLine($"{Pesho.Name}, {Pesho.Age}");
        }
    }
}
