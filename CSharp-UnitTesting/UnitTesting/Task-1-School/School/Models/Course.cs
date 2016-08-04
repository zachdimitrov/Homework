using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using School.Utilities;
using School.Contracts;

namespace School.Models
{
    public class Course : ICourse
    {
        private string name;
        private ICollection<IStudent> students;

        public Course(string Name)
        {
            this.Name = Name;
            this.Students = new List<IStudent>();
        }

        public string Name
        {
            get { return name; }
            private set 
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

        public ICollection<IStudent> Students
        {
            get { return students; }
            private set 
            {
                students = value; 
            }
        }


        public void AddStudent(IStudent student)
        {
            if (student == null)
            {
                throw new ArgumentNullException("Student you want to add does not exist!");
            }
            if (this.Students.Count >= 30)
            {
                throw new ArgumentOutOfRangeException("Students in a class must be 30 or less!");
            }
            this.Students.Add(student);
        }

        public void RemoveStudent(IStudent student)
        {
            if (!this.Students.Contains(student))
            {
                throw new ArgumentNullException("Student you want to remove does not exist!");
            }
            this.Students.Remove(student);
        }

        public override string ToString()
        {
            var str = new StringBuilder();
            str.AppendFormat("    Students in:  {0}\n", this.Name);
            str.AppendLine("    " + new String('=', (Constants.SeparatorLength + 4)));
            foreach (IStudent student in Students)
            {
                str.AppendLine(student.ToString());
            }
            return str.ToString();
        }
    }
}
