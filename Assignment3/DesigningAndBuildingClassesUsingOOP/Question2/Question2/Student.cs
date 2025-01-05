namespace Question2
{
    internal class Student : Person
    {
        public string Major { get; set; }

        public Student(string name, int age, string major) : base(name, age)
        {
            Major = major;
        }

        public override void Description()
        {
            Console.WriteLine($"{Name} is a {Age}-year-old student majoring in {Major}.");
        }

        public void Study()
        {
            Console.WriteLine($"{Name} is studying for exams.");
        }
    }

}
