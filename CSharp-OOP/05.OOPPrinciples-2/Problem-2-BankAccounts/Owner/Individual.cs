namespace Problem_2_BankAccounts.Owner
{
    using Problem_2_BankAccounts.Utilities;

    class Individual : Customer
    {
        private int id;

        public Individual()
        {
        }

        public Individual(string Name) : base(Name)
        {
            this.ID = id;
        }

        public int ID
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = RegistrationNumberGenerator.Rand(1000000, 9999999);
            }
        }

        public override string ToString()
        {
            return $"Individual - {this.Name}, ID:{this.ID}";
        }
    }
}
