namespace Question6
{
    internal interface IDepartmentService
    {
        void SetDepartmentHead(Instructor head);
        void AddCourse(Course course);
        decimal GetAnnualBudget();
    }
}
