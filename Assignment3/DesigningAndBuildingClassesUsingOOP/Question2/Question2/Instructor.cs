using System.Xml.Linq;

namespace Question2
{
    internal class Instructor : Person
    {
        public string Department { get; set; }

        public Instructor(string name, int age, string department) : base(name, age)
        {
            Department = department;
        }

        public override void Description()
        {
            Console.WriteLine($"{Name} is a {Age}-year-old instructor in the {Department} department.");
        }

        public void Teach()
        {
            Console.WriteLine($"{Name} is giving a lecture.");
        }
    }
}
