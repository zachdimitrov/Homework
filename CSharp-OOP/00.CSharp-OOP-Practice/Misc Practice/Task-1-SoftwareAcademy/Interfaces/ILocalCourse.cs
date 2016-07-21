namespace SoftwareAcademy.Interfaces
{
    using System;
    using System.Collections.Generic;

    public interface ILocalCourse : ICourse
    {
        string Lab { get; set; }
    }
}