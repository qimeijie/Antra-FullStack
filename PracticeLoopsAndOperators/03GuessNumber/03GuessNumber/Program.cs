namespace _03GuessNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int correctNumber = new Random().Next(3) + 1;
            Console.WriteLine("Please guess the number: ");
            int input = Convert.ToInt32(Console.ReadLine());
            if (input < 1 || input > 3)
            {
                Console.WriteLine("Your answer is outside of the range of numbers that are valid guesses (less than 1 or more than 3).");
            }
            else if (input > correctNumber)
            {
                Console.WriteLine("Your answer is higher.");
            }
            else if (input < correctNumber)
            {
                Console.WriteLine("Your answer is lower.");
            }
            else
            {
                Console.WriteLine("Your answer is correct!");
            }
        }
    }
}
