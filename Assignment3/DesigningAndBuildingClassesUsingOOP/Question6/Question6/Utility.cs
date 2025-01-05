namespace Question6
{
    internal class Utility
    {
        public static string Greeting() 
        {
            int hour = DateTime.Now.Hour;
            string message = hour switch
            {
                >= 5 and < 12 => "Good Morning",
                >= 12 and < 18 => "Good Afternoon",
                >= 18 and < 22 => "Good Evening",
                _ => "Good Night"

            };
            return message;
        }
        public static int CalculateYear(DateTime startYear) {
            DateTime today = DateTime.Now;
            int years = today.Year - startYear.Year;
            if (startYear.Date > today.AddYears(-years)) years--;
            return years;
        }
    }
}
