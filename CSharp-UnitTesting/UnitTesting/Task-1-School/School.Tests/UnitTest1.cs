using System;
using NUnit.Framework;
using School.Models;
using School.Utilities;
using System.Collections.Generic;

namespace School.Tests
{
    [TestFixture]
    public class UnitTests
    {
        // Student Tests

        [Test]
        public void CheckIfStudentNameIsReturnedCorrectly()
        {
            string name = "Peter Ivanov Stoyanov";
            var student = new Student(name);
            Assert.AreSame(name, student.Name);
        }

        [Test]
        public void CheckIf_Student_ToStringMethodReturns()
        {
            var student = new Student("Dimcho");
            var str = student.ToString();
            Assert.IsNotEmpty(str);
        }
        
        [Test]
        public void StudentName_ShouldThrow_IfNull()
        {
            string name = null;
            TestDelegate test = () => new Student(name);
            Assert.Throws(typeof(ArgumentNullException), test);
        }

        [Test]
        public void StudentName_ShouldThrow_IfEmpty()
        {
            string name = "     ";
            TestDelegate test = () => new Student(name);
            Assert.Throws(typeof(ArgumentOutOfRangeException), test);
        }

        [Test]
        public void CheckIf_Student_IsCreated()
        {
            var student = new Student("Pesho");
            Assert.IsNotNull(student);
        }

        [Test]
        public void CheckIfStudentNumberIsInTheCorrectRange()
        {
            var student = new Student("Gosho");
            int id = student.Number;
            Assert.IsTrue(id >= 10000 && id <= 99999);
        }

        [Test]
        public void CheckIf_TryingToJoinCourse_ThatDoesNotExistThrows()
        {
            var student = new Student("Ivan");
            Course MissingCourse = null;
            TestDelegate test = () => student.JoinCourse(MissingCourse);
            Assert.Throws(typeof(ArgumentNullException), test);
        }

        [Test]
        public void Joining_Course_ShouldWork()
        {
            var course = new Course("Math");
            var student = new Student("Kancho");
            student.JoinCourse(course);
            Assert.IsTrue(course.Students.Contains(student));
        }

        [Test]
        public void TryingTo_JoinCourse_ThatHasMoreThan_MaxNumberOfStudents_ShouldThrow()
        {
            var course = new Course("Some Course");
            for (int i = 0; i < Constants.MaxStudentsInCoure; i++)
            {
                course.AddStudent(new Student("Name"));
            }
            var student = new Student("Joro");
            TestDelegate test = () => student.JoinCourse(course);
            Assert.Throws(typeof(ArgumentOutOfRangeException), test);
        }

        [Test]
        public void IfCourseDoesNotContainStudent_LeavingIt_ShouldThrow()
        {
            var course = new Course("Music");
            var student = new Student("Pencho");
            TestDelegate test = () => student.LeaveCourse(course);
            Assert.Throws(typeof(ArgumentNullException), test);
        }

        [Test]
        public void LeavingCourseShouldWork()
        {
            var course = new Course("Math");
            var student = new Student("Kancho");
            student.JoinCourse(course);
            student.LeaveCourse(course);
            Assert.IsTrue(!course.Students.Contains(student));
        }

        // Number Generator Test

        [Test]
        public void UniqueNumbersShouldLoopIfExceedMaximalNumber()
        {
            var students = new List<Student>();
            for (int i = Constants.MinIDNumber; i < Constants.MaxIDNumber; i++)
            {
                students.Add(new Student(string.Format("Name{0}", i.ToString())));
            }
            var student = new Student("Bobi");
            TestDelegate test = () => students.Add(student);
            Assert.IsTrue(student.Number < Constants.MaxIDNumber);
        }

        // High School Tests

        [Test]
        public void CheckIf_HighSchool_ToStringMethodReturns()
        {
            var school = new HighSchool("Vasil Levski");
            var course = new Course("Kurs");
            var student = new Student("Student");
            course.AddStudent(student);
            school.AddCourse(course);
            var str = school.ToString();
            Assert.IsNotEmpty(str);
        }

        [Test]
        public void CheckIf_HighSchool_IsCreated()
        {
            var school = new HighSchool("Hristo Botev");
            Assert.IsNotNull(school);
        }

        [Test]
        public void SchoolName_ShouldReturn_Correctly()
        {
            var name = "OMG";
            var school = new HighSchool(name);
            Assert.AreSame(name, school.Name);
        }

        [Test]
        public void SchoolName_ShouldThrow_IfNull()
        {
            string name = null;
            TestDelegate test = () => new HighSchool(name);
            Assert.Throws(typeof(ArgumentNullException), test);
        }

        [Test]
        public void SchoolName_ShouldThrow_IfEmpty()
        {
            string name = "     ";
            TestDelegate test = () => new HighSchool(name);
            Assert.Throws(typeof(ArgumentOutOfRangeException), test);
        }

        [Test]
        public void CheckIf_TryingToAddCourse_ThatDoesNotExistThrows()
        {
            var school = new HighSchool("Pencho Slaveikov");
            Course MissingCourse = null;
            TestDelegate test = () => school.AddCourse(MissingCourse);
            Assert.Throws(typeof(ArgumentNullException), test);
        }

        [Test]
        public void Adding_Course_ShouldWork()
        {
            var course = new Course("Math");
            var school = new HighSchool("Kancho Penchev");
            school.AddCourse(course);
            Assert.IsTrue(school.Courses.Contains(course));
        }

        [Test]
        public void IfSchoolDoesNotContainCourse_RemovingIt_ShouldThrow()
        {
            var course = new Course("Music");
            var school = new HighSchool("Petko Petkov");
            TestDelegate test = () => school.RemoveCourse(course);
            Assert.Throws(typeof(ArgumentNullException), test);
        }

        [Test]
        public void RemovingCourseShouldWork()
        {
            var course = new Course("Math");
            var school = new HighSchool("Ne Moga Da Izmislq Ime");
            school.AddCourse(course);
            school.RemoveCourse(course);
            Assert.IsTrue(!school.Courses.Contains(course));
        }

        // Course Tests

        [Test]
        public void CourseName_ShouldThrow_IfNull()
        {
            string name = null;
            TestDelegate test = () => new Course(name);
            Assert.Throws(typeof(ArgumentNullException), test);
        }

        [Test]
        public void CourseName_ShouldThrow_IfEmpty()
        {
            string name = "     ";
            TestDelegate test = () => new Course(name);
            Assert.Throws(typeof(ArgumentOutOfRangeException), test);
        }

        [Test]
        public void CheckIf_TryingToAddStudent_ThatDoesNotExistThrows()
        {
            var course = new Course("Futbol");
            Student MissingStudent = null;
            TestDelegate test = () => course.AddStudent(MissingStudent);
            Assert.Throws(typeof(ArgumentNullException), test);
        }

        [Test]
        public void TryingTo_AddStudent_ToCourse_ThatHasMoreThan_MaxNumberOfStudents_ShouldThrow()
        {
            var course = new Course("Some Course");
            for (int i = 0; i < Constants.MaxStudentsInCoure; i++)
            {
                course.AddStudent(new Student("Name"));
            }
            var student = new Student("Joro");
            TestDelegate test = () => course.AddStudent(student);
            Assert.Throws(typeof(ArgumentOutOfRangeException), test);
        }

        [Test]
        public void IfCourseDoesNotContainStudent_RemovingIt_ShouldThrow()
        {
            var course = new Course("Gotvarstvo");
            var student = new Student("Petko");
            TestDelegate test = () => course.RemoveStudent(student);
            Assert.Throws(typeof(ArgumentNullException), test);
        }
    }
}
