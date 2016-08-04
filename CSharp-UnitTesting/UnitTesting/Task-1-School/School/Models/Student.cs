using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using School.Utilities;
using School.Contracts;

namespace School.Models
{
    public class Student : IStudent
    {
        private string name;
        private int number;

        public Student(string Name)
        {
            this.Name = Name;
            this.Number = GenerateUniqueNumber.GetUniqueNumber();
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Name can not be null!");
                }
                if (value.Trim() == "")
                {
                    throw new ArgumentOutOfRangeException("Name can not be empty string!");
                }
                name = value;
            }
        }

        public int Number
        {
            get { return number; }
            private set { number = value; }
        }

        public override string ToString()
        {
            var str = new StringBuilder();
            str.AppendFormat("        {0} - {1}\n", this.Number, this.Name);
            str.Append("        " + new String('-', Constants.SeparatorLength));
            return str.ToString();
        }

        public void JoinCourse(Course course)
        {
            if (course == null)
            {
                throw new ArgumentNullException("Course you want to add to does not exist!");
            }
            if (course.Students.Count >= 30)
            {
                throw new ArgumentOutOfRangeException("Students in a course must be 30 or less!");
            }
            course.AddStudent(this);
        }

        public void LeaveCourse(Course course)
        {
            if (!course.Students.Contains(this))
            {
                throw new ArgumentNullException("Student you want to remove is not part of this course!");
            }
            course.RemoveStudent(this);
        }
    }
}
