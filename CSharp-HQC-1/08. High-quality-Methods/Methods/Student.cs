using System;

namespace Methods
{
    /// <summary>
    /// Store info about a student - names, birth date
    /// Compare students by age
    /// </summary>
    class Student
    {
        private const int DateLength = 10;
        private const int StringLength = 3;

        private string firstName;
        private string lastName;

        // asssumed that 'OtherInfo' is a string containing a Date + 10 more symbols on front
        // Example - "birth day 2009-06-15"
        private string otherInfo;

        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (value == null)
                {
                    throw new NullReferenceException("First name cannot be null!");
                }

                CheckForAppropriateStringLength(value);

                firstName = value;
            }
        }

        public string LastName
        {
            get { return lastName; }
            set
            {
                if (value == null)
                {
                    throw new NullReferenceException("Last name cannot be null!");
                }

                CheckForAppropriateStringLength(value);

                lastName = value;
            }
        }

        public string OtherInfo
        {
            get { return otherInfo; }
            set
            {
                if (value == null)
                {
                    throw new NullReferenceException("Date of birth cannot be null!");
                }

                otherInfo = value;
            }
        }

        /// <summary>
        /// Checks if a student is older than an other one. A comparison method.
        /// </summary>
        /// <param name="other">An instance of another Student</param>
        /// <returns>True if student is older and false if not</returns>
        public bool IsOlderThan(Student other)
        {
            if (other.IsSameAs(this))
            {
                throw new ArgumentException("Possible to compare a student by himself! Check Students ID cards");
            }

            DateTime firstDate = BirthDay(this.OtherInfo);
            DateTime secondDate = BirthDay(other.OtherInfo);
            // if date has a smaller value a person is older
            return firstDate < secondDate;
        }

        // return a parsed DateTime value of the students birthday
        private DateTime BirthDay(string dateOfBirth)
        {
            string birthDayAsString = dateOfBirth.Substring(dateOfBirth.Length - DateLength);
            DateTime birthDay = new DateTime();
            bool correctDateString = DateTime.TryParse(birthDayAsString, out birthDay);

            if (!correctDateString)
            {
                throw new ArgumentException("Date of birth is not specified!");
            }

            return birthDay;
        }

        // Checks if current student is the same as another instance of Student
        private bool IsSameAs(Student student)
        {
            bool sameStudent = false;
            if (this.firstName == student.firstName &&
                this.lastName == student.lastName &&
                this.otherInfo == student.otherInfo)
            {
                sameStudent = true;
            }

            return sameStudent;
        }

        // check for name validity
        private void CheckForAppropriateStringLength(string value)
        {
            if (value.Length < StringLength)
            {
                throw new ArgumentException("Name is too short. Are you sure it is correct?");
            }
        }
    }
}
