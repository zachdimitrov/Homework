using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using School.Utilities;
using School.Contracts;

namespace School.Models
{
    public class HighSchool
    {
        private string name;
        private ICollection<Course> courses;

        public HighSchool(string Name)
        {
            this.Name = Name;
            this.Courses = new List<Course>();
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

        public ICollection<Course> Courses
        {
            get { return courses; }
            private set { courses = value; }
        }

        public void AddCourse(Course course)
        {
            if (course == null)
            {
                throw new ArgumentNullException("Course you want to add does not exist!");
            }
            this.Courses.Add(course);
        }

        public void RemoveCourse(Course course)
        {
            if (!this.Courses.Contains(course))
            {
                throw new ArgumentNullException("Student you want to remove does not exist!");
            }
            this.Courses.Remove(course);
        }

        public override string ToString()
        {
            var str = new StringBuilder();
            str.AppendLine(new String('*', (Constants.SeparatorLength + 8)));
            str.AppendFormat("  School Name: {0}\n", this.Name);
            str.AppendLine(new String('*', (Constants.SeparatorLength + 8)));
            foreach (Course course in Courses)
            {
                str.AppendLine(course.ToString());
            }
            return str.ToString();
        }
        
    }
}
