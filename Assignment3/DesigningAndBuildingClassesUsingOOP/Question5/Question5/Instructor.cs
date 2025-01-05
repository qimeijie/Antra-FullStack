namespace Question5
{
    internal class Instructor : Person
    {
        private string department;

        public Instructor(string name, int age, string department, decimal hourlyRate, decimal bonus, decimal workingHour) : base(name, age)
        {
            Department = department;
            HourlyRate = hourlyRate;
            Bonus = bonus;
            WorkingHour = workingHour;
        }

        public string Department
        {
            get
            {
                return department;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Department cannot be null or empty.");
                }
                department = value;
            }
        }

        public decimal HourlyRate { get; set; }

        public decimal Bonus { get; set; }
        public decimal WorkingHour { get; set; }

        public override void Description()
        {
            Console.WriteLine($"{Name} is a {Age}-year-old instructor in {Department}.");
        }
        public override decimal CalculateSalary()
        {
            return HourlyRate * WorkingHour + Bonus;
        }
    }
}
