namespace Question5
{
    internal class Student : Person
    {
        private string major;

        public Student(string name, int age, string major, decimal scholarship) : base(name, age)
        {
            Scholarship = scholarship;
        }

        public string Major {
            get 
            { 
                return major; 
            }
            set 
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Major cannot be null or empty.");
                }
                major = value;
            } 
        }

        public decimal Scholarship { get;set; }

        public override void Description()
        {
            Console.WriteLine($"{Name} is a {Age}-year-old student majoring in {Major}.");
        }
        public override decimal CalculateSalary()
        {
            return Scholarship;
        }
    }
}
