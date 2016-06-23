namespace ExtMethodsLambdaLINQ
{
    using Extention;
    using Linq;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class ProgramStart
    {
        static void Main()
        {
            // StringBuilde Extention
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Test 1. StringBuilder Substring");
            Console.WriteLine("-------------------------------");
            var str = new StringBuilder(@"Implement an extension method Substring(int index, int length) for the class StringBuilder that returns new StringBuilder and has the same functionality as Substring in the class String.");
            Console.WriteLine("Input: {0}", str.ToString());
            Console.WriteLine("***");
            var subStr = str.SubString(20, 19);
            Console.WriteLine("Result: {0}", subStr.ToString());
            // IEnumerable Extentions
            List<int> list = new List<int> { 5, 12, 33, -55, 21, 73, 42, 44, 63, 67, -32 };
            Console.WriteLine("------------------------");
            Console.WriteLine("Test 2. IEnumerable SUM");
            Console.WriteLine("------------------------");
            Console.WriteLine("List: {0}", String.Join(", ", list));
            Console.Write("Sum:     ");
            Console.WriteLine(list.eSum());
            Console.Write("Product:  ");
            Console.WriteLine(list.eProduct());
            Console.Write("Min:      ");
            Console.WriteLine(list.eMin());
            Console.Write("Max:      ");
            Console.WriteLine(list.eMax());
            Console.WriteLine("------------------");
            Console.WriteLine("Test 3. LINQ Tests");
            Console.WriteLine("------------------");
            Console.WriteLine("automatically generated lists");
            Console.WriteLine("*************** simple students");
            int num = 1;
            var students = new List<Student>(5);
            students = Student.Students(5);
            Console.WriteLine(String.Join(", ", students));
            Console.WriteLine("*************** extended students");
            var studentsExt = new List<StudentExtended>(5);
            studentsExt = StudentExtended.ExtStudents(5);
            num = 1;
            foreach (var student in studentsExt)
            {
                Console.WriteLine("*************** student {0} *", num);
                Console.WriteLine(student);
                num++;
            }
            Console.WriteLine("************** first name before last");
            var listFirstLast = LinqUsage.FirstBeforeLast(students);
            foreach (var item in listFirstLast)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("************** age range");
            var ageRangeNames = LinqUsage.AgeRange(students, 16, 29);
            foreach (var item in ageRangeNames)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("************** order students");
            var orderedStudents = LinqUsage.OrderStudents(students);
            foreach (var item in orderedStudents)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("************** divide by 7 and 3");
            Console.WriteLine(LinqUsage.PrintDivisiblesBy3and7(new int[] { 5, 12, 33, -55, 21, 73, 42, 44, 63, 67, -32 }));
            Console.WriteLine("************** student groups");
            var listByGroup = LinqUsage.StudentsFromGroup(studentsExt);
            foreach (var item in listByGroup)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName + " - group: " + item.GroupNumber);
            }
            Console.WriteLine("************** student e-mails");
            var listByMail = LinqUsage.StudentsByMailDomain(studentsExt, "baab.com");
            foreach (var item in listByMail)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName + ": e-mail: " + item.Email);
            }
            Console.WriteLine("************** students that have 6");
            LinqUsage.StudentsByMark(studentsExt, 6);
            Console.WriteLine("************** students with two marks");
            LinqUsage.StudentWithTwoMarks(studentsExt, 2);
            Console.WriteLine("************** students marks from 2006");
            LinqUsage.ExtractMarks(studentsExt, "2006");
            Console.WriteLine("************** students from Mathematics department");
            LinqUsage.ExtractFromDept(studentsExt, "Mathematics");
            Console.WriteLine("************** students grouped by group number");
            Console.WriteLine("Students grouped by GroupNumber");

            var groupedByGroupNumber = studentsExt.OrderBy(x => x.GroupNumber).GroupBy(s => s.GroupNumber);

            foreach (var group in groupedByGroupNumber)
            {
                foreach (var student in group)
                {
                    Console.WriteLine("Student {0} {1} is in group {2}.", student.FirstName, student.LastName, group.Key);
                }
            }

            Console.WriteLine();
            Console.WriteLine("----------------------");
            Console.WriteLine("Test 4. Longest string");
            Console.WriteLine("----------------------");
            var arrOfStrings = new string[5]
            {
                "write a program",
                "to return the string",
                "with maximum length",
                "from an array of strings",
                "use LINQ"
            };

            var longestString = arrOfStrings
                .OrderByDescending(s => s.Length)
                .First();

            Console.WriteLine("String with maximum length from an array: [" + longestString + "]");
            Console.WriteLine();
        }
    }
}
