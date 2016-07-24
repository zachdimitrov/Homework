namespace SoftwareAcademy.Interfaces
{
    using System;
    using System.Collections.Generic;

    public interface ITeacher
    {
        string Name { get; set; }
        void AddCourse(ICourse course);
        string ToString();
    }
}