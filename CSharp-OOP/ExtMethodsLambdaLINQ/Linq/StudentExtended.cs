using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtMethodsLambdaLINQ.Linq
{
    public class StudentExtended : Student
    {
        private int fn;
        private string tel;
        private string email;
        private int[] marks;
        private int groupNumber;

        public StudentExtended()
        {
        }

        public StudentExtended(string FName, string LName, int Age, int FacNumber, string Telephone, string EMail, int[] Marks, int GroupNumber ) : base (FName, LName, Age)
        {
            this.FirstName = FName;
            this.LastName = LName;
            this.Age = Age;
            this.FN = FacNumber;
            this.Tel = Telephone;
            this.Email = EMail;
            this.Marks = Marks;
            this.GroupNumber = GroupNumber;
        }

        public string Department
        {
            get
            {
                switch (this.GroupNumber)
                {
                    case 1: return "Mathematics";
                    case 2: return "Physics";
                    case 3: return "English";
                    default: return "No department";
                }
            }
        }

        public int GroupNumber
        {
            get { return groupNumber; }
            set { groupNumber = value; }
        }

        public int[] Marks
        {
            get { return marks; }
            set { marks = value; }
        }


        public string Email
        {
            get { return email; }
            set { email = value; }
        }


        public string Tel
        {
            get { return tel; }
            set { tel = value; }
        }


        public int FN
        {
            get { return fn; }
            set { fn = value; }
        }
        // random create a list of students
        public static List<StudentExtended> ExtStudents(int count)
        {
            var result = new List<StudentExtended>();
            for (int i = 0; i < count; i++)
            {
                var born = GenerateStudent();
                var person = new StudentExtended();
                person.FirstName = born.FirstName;
                person.LastName = born.LastName;
                person.Age = born.Age;
                person.Tel = String.Format($"08{RandomGen.Instance.Next(75, 99)} {RandomGen.Instance.Next(100, 1000)} {RandomGen.Instance.Next(100, 1000)}");
                person.email = String.Format("{0}{1}{2}{3}@{4}{5}{6}{7}.com", 
                    (char)RandomGen.Instance.Next(97, 99), 
                    (char)RandomGen.Instance.Next(97, 99), 
                    (char)RandomGen.Instance.Next(97, 99), 
                    (char)RandomGen.Instance.Next(97, 99), 
                    (char)RandomGen.Instance.Next(97, 99), 
                    (char)RandomGen.Instance.Next(97, 99), 
                    (char)RandomGen.Instance.Next(97, 99), 
                    (char)RandomGen.Instance.Next(97, 99)
                    );
                person.FN = int.Parse(RandomGen.Instance.Next(1234, 9999).ToString() + "0" +
                                      RandomGen.Instance.Next(1, 10).ToString());
                int numberOfMarks = RandomGen.Instance.Next(2, 11);
                int[] marks = new int[numberOfMarks];
                for (int j = 0; j < marks.Length; j++)
                {
                    marks[j] = RandomGen.Instance.Next(2, 7);
                }
                person.Marks = marks;
                person.GroupNumber = RandomGen.Instance.Next(1, 4);
                result.Add(person);
            }
            return result;
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.AppendLine($"{this.FirstName} {this.LastName}");
            str.AppendLine($"Age:    {this.Age}");
            str.AppendLine($"FN:     {this.FN}");
            str.AppendLine($"Tel:    {this.Tel}");
            str.AppendLine($"E-mail: {this.Email}");
            str.AppendLine($"Marks:  {String.Join(", ", Marks)}");
            str.Append($"Group:  {this.GroupNumber}");
            return str.ToString();
        }
    }
}
