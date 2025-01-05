namespace Question2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person student = new Student("Maggie", 20, "Full Stack");
            Person instructor = new Instructor("Smith", 40, "Computer Science");

            student.Description();
            instructor.Description();

            ((Student)student).Study();
            ((Instructor)instructor).Teach();
        }
    }
}
