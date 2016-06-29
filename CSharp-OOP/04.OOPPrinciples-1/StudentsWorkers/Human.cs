namespace StudentsWorkers
{
    using System;

    public abstract class Human
    {
        private string firstName;
        private string lastName;

        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            private set
            {
                CheckNullOrEmpty(value, "Wrong First Name!");
                this.firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return this.lastName;
            }
            private set
            {
                CheckNullOrEmpty(value, "Wrong Last Name!");
                this.lastName = value;
            }
        }

        private static void CheckNullOrEmpty(string value, string message)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException(message);
            }
        }

        public override string ToString()
        {
            return this.FirstName + " " + this.LastName;
        }
    }
}
