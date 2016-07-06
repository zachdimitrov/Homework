namespace CommonTypeSystem
{
    using Enumeration;
    using System;
    using System.Text;

    public class Student : ICloneable, IComparable<Student>
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private int ssn;
        private string address;
        private string mobile;
        private int course;
        private Speciality spec;
        private Faculty fac;
        private University univ;

        public Student()
        {
            this.SSN = ssn;
        }

        public Student(string FirstName, string MidName, string LastName)
        {
            this.FirstName = FirstName;
            this.MiddleName = MidName;
            this.LastName = LastName;
            this.SSN = ssn;
        }

        public University Univ
        {
            get { return univ; }
            set { univ = value; }
        }

        public Faculty Fac
        {
            get { return fac; }
            set { fac = value; }
        }

        public Speciality Spec
        {
            get { return spec; }
            set { spec = value; }
        }

        public int Course
        {
            get { return course; }
            set { course = value; }
        }

        public string Mobile
        {
            get { return mobile; }
            set { mobile = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public int SSN
        {
            get { return ssn; }
            private set { ssn = GenerateID.Next(); }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string MiddleName
        {
            get { return middleName; }
            set { middleName = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public override int GetHashCode()
        {
            return this.SSN;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Student);
        }

        public bool Equals(Student someInstance)
        {
            return Object.ReferenceEquals(this, someInstance)
                || (!Object.ReferenceEquals(someInstance, null)
                    && this.FirstName == someInstance.FirstName
                    && this.MiddleName == someInstance.MiddleName
                    && this.LastName == someInstance.LastName
                    && this.SSN == someInstance.SSN
                    && this.Address == someInstance.Address
                    && this.Course == someInstance.Course
                    && this.Mobile == someInstance.Mobile
                    && this.Univ == someInstance.Univ
                    && this.Fac == someInstance.Fac
                    && this.Spec == someInstance.Spec);
        }

        public static bool operator ==(Student lhs, Student rhs)
        {  
            return Object.ReferenceEquals(lhs, rhs)
                    || (!Object.ReferenceEquals(lhs, null)
                        && !Object.ReferenceEquals(rhs, null)
                        && lhs.FirstName == rhs.FirstName
                        && lhs.MiddleName == rhs.MiddleName
                        && lhs.LastName == rhs.LastName
                        && lhs.SSN == rhs.SSN
                        && lhs.Address == rhs.Address
                        && lhs.Course == rhs.Course
                        && lhs.Mobile == rhs.Mobile
                        && lhs.Univ == rhs.Univ
                        && lhs.Fac == rhs.Fac
                        && lhs.Spec ==rhs.Spec);
        }

        public static bool operator !=(Student lhs, Student rhs)
        {
            return (Object.ReferenceEquals(lhs, null) || !lhs.Equals(rhs))
                    && !Object.ReferenceEquals(lhs, rhs);
        }

        public override string ToString()
        {
            var str = new StringBuilder();
            Console.WriteLine("===============================");
            Console.WriteLine($"{this.FirstName} {this.MiddleName} {this.LastName}");
            Console.WriteLine($"Address: {this.Address}");
            Console.WriteLine($"Phone: {this.Mobile}");
            Console.WriteLine($"Student in: {this.Univ}");
            Console.WriteLine($"Faculty of {this.Fac}, SSN: {this.SSN}");
            Console.WriteLine($"Master degree of {this.Spec}, {this.Course} course");
            Console.WriteLine("===============================");
            return str.ToString();
        }

        public object Clone()
        {
            Student newStudent = (Student)this.MemberwiseClone();
            newStudent.FirstName = String.Copy(FirstName);
            newStudent.MiddleName = String.Copy(MiddleName);
            newStudent.LastName = String.Copy(LastName);
            newStudent.SSN = this.SSN;
            newStudent.Address = String.Copy(this.Address);
            newStudent.Course = this.Course;
            newStudent.Mobile = String.Copy(this.Mobile);
            newStudent.Univ = this.Univ;
            newStudent.Spec = this.Spec;
            newStudent.Fac = this.Fac;
            return (object)newStudent;
        }

        public int CompareTo(Student obj)
        {
            int i = FirstName.CompareTo(obj.FirstName);
            if (i != 0) return i;

            i = MiddleName.CompareTo(obj.MiddleName);
            if (i != 0) return i;

            i = LastName.CompareTo(obj.LastName);
            if (i != 0) return i;

            if (SSN == obj.SSN)
            {
                return 0;
            }
            else if (SSN < obj.SSN)
            {
                return -1;
            }
            else
            {
                return 1;
            }
        }
    }
}
