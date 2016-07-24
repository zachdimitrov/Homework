using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_1_CatSystem
{
    class CatSystemStart
    {
        static void Main()
        {
            var peshoOwner = new Owner("Pesho", "Ivanov");
            peshoOwner.IncreaseAge();
            peshoOwner.IncreaseAge();
            peshoOwner.IncreaseAge();
            peshoOwner.IncreaseAge();
            peshoOwner.IncreaseAge();

            var goshoOwner = new Owner("Gosho", "Petrov");

            var cat = new Cat(CatColor.Brown);
            var oneCat = new Cat(CatColor.Black);
            var anotherCat = new Cat(CatColor.Red);
            cat.Owner = peshoOwner;
            peshoOwner.AddCat(oneCat, "Maca");
            peshoOwner.AddCat(anotherCat, "Silvester");

            Console.WriteLine(peshoOwner.AllCats);
            Console.WriteLine(Cat.NumberOfLegs);
            Console.WriteLine(Cat.CatSais());

            Printer.PrintCat(anotherCat);
            var point = new Point();
            point.X = 4.56m;
            point.Y = 5.34m;
            Console.WriteLine(point.GetCoords());
        }
    }
}
