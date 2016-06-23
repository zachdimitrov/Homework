namespace ExtMethodsLambdaLINQ.Linq
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public static class LinqUsage
    {
        // Problem 3. First before last
        public static IEnumerable<T> FirstBeforeLast<T>(IEnumerable<T> students) where T : Student
        {
            var result = students
                .Where(x => (x.FirstName).CompareTo(x.LastName) < 0)
                .ToArray();
            return result;
        }
        // Problem 4. Age range
        public static IEnumerable<string> AgeRange<T>(IEnumerable<T> students, int min, int max) where T : Student
        {
            var result = students
                .Where(x => x.Age >= min && x.Age <= max)
                .Select(x => String.Format($"Name: {x.FirstName} {x.LastName}, age: {x.Age}"))
                .ToArray();
            return result;
        }
        // Problem 5. Order Students
        public static IEnumerable<T> OrderStudents<T>(IEnumerable<T> students) where T : Student
        {
            var ordered = students
                .OrderByDescending(x => x.FirstName)
                .ThenByDescending(x => x.LastName)
                .ToArray();
            return ordered;
        }
        // Problem 6. using System.Linq;
        public static string PrintDivisiblesBy3and7(int[] array)
        {
            int[] result = array
                .Where(x => x % 7 == 0 && x % 3 == 0)
                .ToArray();
            return String.Join(", ", result);
        }
        // Problem 10. Student groups
        public static IEnumerable<T> StudentsFromGroup<T>(IEnumerable<T> students) where T : StudentExtended
        {
            var result = students
                .Where(x => x.GroupNumber == 2)
                .ToArray();
            return result;
        }
        // Problem 11. Extract students by email
        public static IEnumerable<T> StudentsByMailDomain<T>(IEnumerable<T> students, string domain) where T : StudentExtended
        {
            var result = students
                .Where(x => x.Email.Split('@').Last() == domain)
                .ToArray();
            return result;
        }
        // Problem 12. Extract students by phone
        public static IEnumerable<T> StudentsByPhone<T>(IEnumerable<T> students, int phoneGroup, string expectedGroupContain) where T : StudentExtended
        {
            var result = students
                .Where(x => x.Tel.Split(' ')
                .Skip(phoneGroup - 1)
                 .FirstOrDefault() == expectedGroupContain)
                .ToArray();
            return result;
        }
        // Problem 13. Extract students by marks
        public static void StudentsByMark<T>(IEnumerable<T> students, int mark) where T : StudentExtended
        {
            var result = students
                .Where(m => m.Marks.Contains(6))
                .Select(x => new
                {
                    FullName = string.Format($"{x.FirstName} {x.LastName}"),
                    Marks = x.Marks
                });
            foreach (var item in result)
            {
                Console.WriteLine($"<{item.FullName}>");
                Console.WriteLine(string.Join(", ", item.Marks));
            }
        }
        // Problem 14. Extract students with two marks
        public static void StudentWithTwoMarks<T>(IEnumerable<T> students, int n) where T : StudentExtended
        {
            var withTwoMarks = students
                .Where(x => x.Marks.Length == 2)
                .ToArray();
            foreach (var item in withTwoMarks)
            {
                Console.WriteLine(string.Join(", ", item));
            }
        }
        // Problem 15. Extract marks
        public static void ExtractMarks<T>(IEnumerable<T> students, string year) where T : StudentExtended
        {
            var markOfStudents = students
                .Where(x => x.FN.ToString()[4] == year[2] && x.FN.ToString()[5] == year[3])
                .Select(y => y.Marks)
                .ToArray();

            foreach (var item in markOfStudents)
            {
                Console.WriteLine(string.Join(", ", item));
            }
        }
        // Problem 16.* Groups
        public static void ExtractFromDept<T>(IEnumerable<T> students, string dept) where T : StudentExtended
        {
            var result = students
                .Where(x => x.Department == dept)
                .Select(y => string.Format($"{y.FirstName} {y.LastName}"))
                .ToArray();
            Console.WriteLine($"Students in {dept} department:");
            Console.WriteLine("- - - - - - ");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
        // Problem 17. Longest string - DONE
        // Problem 18. Grouped by GroupNumber - DONE
        // Problem 19. Grouped by GroupName extensions
        // Problem 20.* Infinite convergent series
    }
}
