namespace Question6
{
    internal class Instructor : Person, IInstructorService
    {
        public DateTime JoinDate { private get; set; }
        public decimal Bonus { private get; set; }
        public Department Department { get; set; }
        public Instructor(string name, DateTime dob, decimal salary, DateTime joinDate, decimal bonus, Department department)
            : base(name, dob, salary)
        {
            JoinDate = joinDate;
            Bonus = bonus;
            Department = department;
        }

        public int CalculateYearsOfExperience()
        {
            return Utility.CalculateYear(JoinDate);
        }
        public override decimal CalculateSalary()
        {
            return Salary + Bonus;
        }
    }
}
