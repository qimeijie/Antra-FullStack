namespace Question6
{
    internal interface ICourseService
    {
        public void AddStudent(Student student);
        public List<Student> GetEnrolledStudents();
    }
}
