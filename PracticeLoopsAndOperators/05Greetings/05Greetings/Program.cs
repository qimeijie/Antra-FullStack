namespace _05Greetings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int currentHour = DateTime.Now.Hour;

            string greeting = currentHour switch
            {
                >= 6 and < 12 => "Good Morning",
                >= 12 and < 17 => "Good Afternoon",
                >= 17 and < 21 => "Good Evening",
                _ => "Good Night"
            };
            Console.WriteLine(greeting);
        }
    }
}
