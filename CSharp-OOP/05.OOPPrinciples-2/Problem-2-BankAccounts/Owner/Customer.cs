namespace Problem_2_BankAccounts.Owner
{
    public abstract class Customer
    {
        private string name;

        public Customer()
        {
        }

        public Customer(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

    }
}
