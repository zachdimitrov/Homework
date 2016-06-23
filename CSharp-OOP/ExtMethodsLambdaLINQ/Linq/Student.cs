namespace ExtMethodsLambdaLINQ.Linq
{
    using ExtMethodsLambdaLINQ;
    using ExtMethodsLambdaLINQ.Enumerator;
    using System.Collections.Generic;
    using System.Text;
    /// <summary>
    /// Class for student objects
    /// </summary>
    public class Student
    {
        private string firstName;
        private string lastName;
        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public Student()
        {
        }

        public Student(string firstName = "Ivan", string lastName = "Petrov", int age = 20)
        {
            this.Age = age;
            this.FirstName = firstName;
            this.LastName = lastName;
        }
   

        /// <summary>
        /// generate single student
        /// </summary>
        /// <returns>Student</returns>
        public static Student GenerateStudent()
        {
            string FName = string.Empty;
            string LName = string.Empty;
            int indexFirstName = 0;
            int indexLastName = 0;

            indexFirstName = RandomGen.Instance.Next(0, 16);
            if (indexFirstName % 2 == 0)
            {
                indexLastName = RandomGen.Instance.Next(0, 15);
                if (indexLastName % 2 != 0)
                {
                    indexLastName++;
                }
            }
            else
            {
                indexLastName = RandomGen.Instance.Next(1, 16);
                if (indexLastName % 2 == 0)
                {
                    indexLastName--;
                }
            }
            FName = ((NamesFirst)indexFirstName).ToString();
            LName = ((NamesLast)indexLastName).ToString();
            int Age = RandomGen.Instance.Next(16, 89);
            return new Student(FName, LName, Age);
        }
        /// <summary>
        /// returns list of random students
        /// </summary>
        public static List<Student> Students(int count)
        {
            var result = new List<Student>();
            for (int i = 0; i < count; i++)
            {
                result.Add(GenerateStudent());
            }
            return result;
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append($"{this.FirstName} {this.LastName} - ");
            str.Append($"{this.Age}");
            return str.ToString();
        }
    }
}
