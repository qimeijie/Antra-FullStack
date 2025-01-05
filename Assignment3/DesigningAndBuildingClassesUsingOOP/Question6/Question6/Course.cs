
namespace Question6
{
    internal class Course : ICourseService
    {
        public string CourseName { get; set; }
        private List<Student> EnrolledStudents { get; } = new List<Student>();
        public Course(string name)
        {
            CourseName = name;
        }
        public void AddStudent(Student student)
        {
            EnrolledStudents.Add(student);
        }

        public List<Student> GetEnrolledStudents()
        {
            return new List<Student>(EnrolledStudents);
        }
    }
}