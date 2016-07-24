namespace SoftwareAcademy.Models
{
    using SoftwareAcademy.Interfaces;
    using SoftwareAcademy.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class LocalCourse : Course, ILocalCourse, ICourse
    {
        public string Lab { get; set; }

        public LocalCourse(string name, ITeacher teacher, string lab) : base(name, teacher)
        {
            this.Lab = lab;
        }

        public override string ToString()
        {
            return string.Format("{0}; Lab={1}", base.ToString(), this.Lab);
        }
    }
}
