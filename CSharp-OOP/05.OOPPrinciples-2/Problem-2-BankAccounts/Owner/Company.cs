namespace Problem_2_BankAccounts.Owner
{
    using Utilities;

    public class Company : Customer
    {
        private string registration;

        public Company(string name) : base(name)
        {
            this.Registration = registration;
        }

        public string Registration
        {
            get
            {
                return registration;
            }

            private set
            {
                registration = RegistrationNumberGenerator.Next();
            }
        }
        public override string ToString()
        {
            return $"Company - {this.Name}, RN:{this.Registration}";
        }
    }
}
