namespace _04RotateArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter integers separated by spaces:");
            string input = Console.ReadLine();
            string[] inputNumbers = input.Split(' ');
            int[] numbers = Array.ConvertAll(inputNumbers, int.Parse);
            Console.WriteLine("Please enter rotate number:");
            int k = int.Parse(Console.ReadLine());
            int[] sum = new int[numbers.Length];
            k = k % numbers.Length;
            for (int i = 1; i <= k; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    sum[(j + i) % numbers.Length] += numbers[j];
                }
            }
            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
