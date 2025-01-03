namespace _04CalculateDays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the birth date (yyyy-mm-dd): ");
            DateTime birthday = Convert.ToDateTime(Console.ReadLine());
            DateTime today = DateTime.Now;
            int daysOld = (today - birthday).Days;
            int daysToNextAnniversary = 10000 - (daysOld % 10000);
            DateTime nextAnniversaryDate = today.AddDays(daysToNextAnniversary);
            Console.WriteLine($"You are {daysOld} days old.");
            Console.WriteLine($"Your next 10000 day anniversary will be on: {nextAnniversaryDate:yyyy-MM-dd}");
        }
    }
}
