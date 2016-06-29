namespace SchoolClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Discipline Math = new Discipline("Math", 20, 2);
            Discipline English = new Discipline("English", 30, 3);

            Teacher MathTeacher = new Teacher("Ivan Petrov");
            Teacher EnglishTeacher = new Teacher("Petko Todorov");

            MathTeacher.AddDiscipline(Math);
            EnglishTeacher.AddDiscipline(English);

            Student Gosho = new Student("Georki Ivanov", 12);
            SchoolClass testClass = new SchoolClass("A");

            testClass.AddTeacher(MathTeacher);
            testClass.AddTeacher(EnglishTeacher);

            testClass.AddStudent(Gosho);

            School Treto = new School();

            Treto.AddClass(testClass);
            
                
        }
    }
}
