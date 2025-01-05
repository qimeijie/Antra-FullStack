
namespace Question1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = GenerateNumbers(10);
            Reverse(numbers);
            PrintNumbers(numbers);
        }

        private static void PrintNumbers(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
        }

        private static void Reverse(int[] numbers)
        {
            for (int i = 0; i <= numbers.Length / 2; i++)
            {
                int temp = numbers[i];
                numbers[i] = numbers[numbers.Length - 1 - i];
                numbers[numbers.Length - 1 - i] = temp;
            }
        }

        private static int[] GenerateNumbers(int v)
        {
            int[] numbers = new int[v];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i + 1;
            }
            return numbers;
        }
    }
}
