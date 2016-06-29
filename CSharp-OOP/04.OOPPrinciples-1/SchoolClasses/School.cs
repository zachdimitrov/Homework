namespace SchoolClasses
{
    using System;
    using System.Collections.Generic;

    public class School
    {
        private List<SchoolClass> schoolClasses;

        public School()
        {
            this.schoolClasses = new List<SchoolClass>();
        }

        public List<SchoolClass> SchoolClasses
        {
            get
            {
                return this.schoolClasses;
            }
            private set
            {
                this.schoolClasses = value;
            }
        }

        public void AddClass(SchoolClass schoolClass)
        {
            this.schoolClasses.Add(schoolClass);
        }
        public void RemoveClass(SchoolClass schoolClass)
        {
            this.schoolClasses.Remove(schoolClass);
        }
    }
}
