namespace SoftwareAcademy.Models
{
    using Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Teacher : ITeacher
    {
        private ICollection<ICourse> courses;

        public string Name { get; set; }

        public Teacher(string name)
        {
            this.Name = name;
            this.courses = new List<ICourse>();
        }

        public void AddCourse(ICourse course)
        {
            this.courses.Add(course);
        }

        public override string ToString()
        {
            string format = "Teacher: Name={0}";
            if (this.courses.Count > 0)
            {
                format += "; Cоurses=[{1}]";
            }
            var courseNames = this.courses.Select(x => x.Name);
            string result = string.Format(format, this.Name, string.Join(", ", courseNames));
            return result;
        }
    }
}
