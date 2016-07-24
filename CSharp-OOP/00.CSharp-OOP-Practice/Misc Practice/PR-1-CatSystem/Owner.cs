using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_1_CatSystem
{
    public class Owner
    {
        private string firstName;
        private string lastName;
        public int Age { get; private set; }
        private List<Cat> cats;

        public Owner(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.Age = 0;
            this.cats = new List<Cat>();
        }

        public string FullName
        {
            get
            {
                return string.Format("{0} {1}", this.firstName, this.lastName);
            }
        }

        public string AllCats
        {
            get
            {
                return string.Join(", ", this.cats.Select(c => c.Name));
            }
        }

        public string FirstName
        {
            get { return this.firstName; }
        }

        public string LastName
        {
            get { return this.lastName; }
        }

        public void IncreaseAge()
        {
            this.Age++;
        }

        public void AddCat(Cat cat, string name)
        {
            if (this.cats.Contains(cat))
            {
                throw new ArgumentException("This owner already owns the cat: " + cat.Name);
            }
            cat.Name = name;
            cat.Owner = this;
            this.cats.Add(cat);
        }
    }
}
