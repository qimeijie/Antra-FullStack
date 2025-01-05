namespace Question6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Department scienceDepartment = new Department("Science Department", 100000);
            Student student = new Student("Maggie", new DateTime(1990, 5, 15), 100);
            Instructor instructor = new Instructor("Smith", new DateTime(1990, 5, 15), 40000, new DateTime(1990, 5, 15),1000, scienceDepartment);

            Course course1 = new Course("Math");
            Course course2 = new Course("Physics");
            student.EnrollInCourse(course1);
            student.EnrollInCourse(course2);
            scienceDepartment.SetDepartmentHead(instructor);
            student.DisplaySalary();
            instructor.DisplaySalary();
        }
    }
}
