namespace Question4
{
    internal class Instructor : Person
    {
        private string department;

        public Instructor(string name, int age, string department) : base(name, age)
        {
            Department = department;
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

        public override void Description()
        {
            Console.WriteLine($"{Name} is a {Age}-year-old instructor in {Department}.");
        }
    }
}
