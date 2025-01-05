
namespace Question6
{
    internal abstract class Person : IPersonService
    {
        private string name;
        private decimal salary;

        public string Name
        {
            get { return name; }
            protected set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be null or empty.");
                }
                name = value;
            }
        }

        public DateTime DateOfBirth { private get; set; }
        protected decimal Salary 
        {
            get { return salary; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Salary cannot be negative number.");
                }
                salary = value;
            }
        }
        private List<string> Addresses { get; } = new List<string>();
        protected Person(string name, DateTime dob, decimal salary)
        {
            Name = name;
            DateOfBirth = dob;
            Salary = salary;
        }
        public virtual decimal CalculateSalary()
        {
            return Salary;
        }
        public void DisplaySalary()
        {
            Console.WriteLine($"{Name}'s salary: {CalculateSalary():C}");
        }

        public int CalculateAge()
        {
            return Utility.CalculateYear(DateOfBirth);
        }

        public List<string> GetAddresses()
        {
            return Addresses;
        }
        public void AddAddress(string address)
        {
            Addresses.Add(address);
        }
    }
}
