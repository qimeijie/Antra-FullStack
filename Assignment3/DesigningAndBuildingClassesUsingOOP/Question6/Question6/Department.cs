namespace Question6
{
    internal class Department : IDepartmentService
    {
        public string DepartmentName { get; set; }
        private Instructor DepartmentHead { get; set; }
        private List<Course> Courses { get; } = new List<Course>();
        private decimal Budget { get; set; }

        public Department(string name, decimal budget)
        {
            DepartmentName = name;
            Budget = budget;
        }

        public void SetDepartmentHead(Instructor head)
        {
            DepartmentHead = head;
            head.Department = this;
        }

        public void AddCourse(Course course)
        {
            Courses.Add(course);
        }

        public decimal GetAnnualBudget()
        {
            return Budget;
        }
    }
}
