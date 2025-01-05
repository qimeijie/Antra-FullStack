namespace Question3
{
    internal class Student : Person
    {
        private string major;

        public Student(string name, int age, string major) : base(name, age)
        {
            Major = major;
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

        public override void Description()
        {
            Console.WriteLine($"{Name} is a {Age}-year-old student majoring in {Major}.");
        }
    }
}
