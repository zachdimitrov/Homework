using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using School;
using School.Models;

namespace UserProject

{
    class Program
    {
        static void Main()
        {
            try
            {
                // create school
                var Gimnaziq = new HighSchool("Very Cool High Schoool");
                // create courses
                var Angliiski = new Course("English Course");
                var Matematika = new Course("Math Course");
                // add courses to school
                Gimnaziq.AddCourse(Angliiski);
                Gimnaziq.AddCourse(Matematika);
                // create students
                var Pesho = new Student("Pesho");
                var Gosho = new Student("Georgi Petrov");
                var Ivan = new Student("Ivan Stoqnov");
                // add students to courses
                Matematika.AddStudent(Pesho);
                Matematika.AddStudent(Gosho);
                Angliiski.AddStudent(Ivan);
                Angliiski.AddStudent(Pesho);

                // print info for school
                Console.WriteLine(Gimnaziq);

                Console.WriteLine("++++++++++++ SOME CHANGES +++++++++++++");

                Matematika.AddStudent(Ivan);
                Angliiski.RemoveStudent(Ivan);

                Gimnaziq.AddCourse(new Course("Music Course"));
                var Peene = Gimnaziq.Courses.FirstOrDefault(x => x.Name == "Music Course");
                Peene.AddStudent(Pesho);
                Peene.AddStudent(Gosho);
                Peene.AddStudent(Ivan);
                Peene.AddStudent(new Student("Stoyan Andreev"));

                Console.WriteLine(Gimnaziq);

            }
            // Check if Null
            catch (ArgumentNullException)
            {
                Console.WriteLine("Name of was set to \"null\", please do not do this!");
            }
            // Name set to an empty string
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Name of was set to an empty string, please do not do this!");
            }
            // Least specific:
            catch (Exception)
            {
                Console.WriteLine("Something very wrong hust happened! Sorry!");
            }
        }
    }
}
