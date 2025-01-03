namespace _01FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int max = 500;
            for (byte i = 0; i < max; i++)
            {
                if (i > 100)
                {
                    break;
                }
                else if (i % (3 * 5) == 0)
                {
                    Console.WriteLine("fizzbuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
