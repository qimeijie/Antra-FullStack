
namespace Question2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(Fibonacci(i));
            }
        }

        private static int Fibonacci(int i)
        {
            if (i <= 0) return 0;
            if (i == 1 || i == 2) return 1;
            return Fibonacci(i - 1) + Fibonacci(i - 2);
        }
    }
}
