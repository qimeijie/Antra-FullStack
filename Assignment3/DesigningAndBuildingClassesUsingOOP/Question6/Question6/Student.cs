namespace Question6
{
    internal class Student : Person, IStudentService
    {
        private Dictionary<Course, char> CourseGrades { get; } = new Dictionary<Course, char>();
        public Student(string name, DateTime dob, decimal scholarship) : base(name, dob, scholarship) { }
        public void EnrollInCourse(Course course)
        {
            CourseGrades[course] = 'N';
            course.AddStudent(this);
        }

        public double CalculateGPA()
        {
            if (CourseGrades.Count == 0) return 0;

            double totalPoints = 0;
            int courseCount = CourseGrades.Count;

            foreach (char grade in CourseGrades.Values)
            {
                totalPoints += grade switch
                {
                    'A' => 4.0,
                    'B' => 3.0,
                    'C' => 2.0,
                    'D' => 1.0,
                    'F' => 0.0,
                    _ => 0.0
                };
            }

            return totalPoints / courseCount;
        }
    }
}
