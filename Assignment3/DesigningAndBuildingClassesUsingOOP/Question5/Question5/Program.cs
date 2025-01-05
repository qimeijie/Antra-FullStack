namespace Question5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person student = new Student("Maggie", 20, "Full Stack", 0);
            Person instructor = new Instructor("Smith", 40, "Computer Science", 35, 1000, 40 * 52);

            student.DisplaySalary();
            instructor.DisplaySalary();
        }
    }
}
