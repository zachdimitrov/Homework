namespace CreatePerson
{
    public class Person
    {
        public Gender Gender { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(int age)
        {
            this.Age = age;

            if (age % 2 == 0)
            {
                this.Name = "Батката";
                this.Gender = Gender.Male;
            }
            else
            {
                this.Name = "Мацето";
                this.Gender = Gender.Female;
            }
        }
    }
}