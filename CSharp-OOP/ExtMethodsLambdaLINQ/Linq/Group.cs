namespace ExtMethodsLambdaLINQ.Linq
{
    public class Group
    {
        public Group()
        {
        }

        public Group(int groupNumber, string department)
        {
            this.GroupNumber = groupNumber;
            this.DepartmentName = department;
        }

        public int GroupNumber { get; }

        public string DepartmentName { get; set; }
    }
}
