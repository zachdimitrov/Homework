using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_1_CatSystem
{
    public class Cat
    {
        public static int NumberOfLegs
        {
            get
            {
                return 4;
            }
        }
        public Cat(CatColor color)
        {
            this.Color = color;
        }
        public string Name { get; set; }
        public int Age { get; private set; }
        public Owner Owner { get; set; }
        public CatColor Color { get; private set; }
        public static string CatSais()
        {
            return "Mew!";
        }
    }
}
