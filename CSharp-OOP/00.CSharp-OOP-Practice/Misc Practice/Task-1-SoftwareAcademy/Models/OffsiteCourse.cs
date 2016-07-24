namespace SoftwareAcademy.Models
{
    using SoftwareAcademy.Interfaces;
    using SoftwareAcademy.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class OffsiteCourse : Course, IOffsiteCourse, ICourse
    {
        public string Town { get; set; }

        public OffsiteCourse(string name, ITeacher teacher, string town) : base(name, teacher)
        {
            this.Town = town;
        }

        public override string ToString()
        {
            return string.Format("{0}; Town={1}", base.ToString(), this.Town);
        }
    }
}
