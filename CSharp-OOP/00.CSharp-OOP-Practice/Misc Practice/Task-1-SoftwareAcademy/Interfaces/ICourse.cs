namespace SoftwareAcademy.Interfaces
{
    using System;
    using System.Collections.Generic;

    public interface ICourse
    {
        string Name { get; set; }
        ITeacher Teacher { get; set; }
        void AddTopic(string topic);
        string ToString();
    }
}