namespace Question3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person student = new Student("Maggie", 20, "Full Stack");
            Person instructor = new Instructor("Smith", 40, "Computer Science");

            student.Description();
            instructor.Description();
        }
    }
}
