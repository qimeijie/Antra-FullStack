namespace _06MaxFrequency
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sequence of numbers (space-separated):");
            string input = Console.ReadLine();
            int[] numbers = Array.ConvertAll(input.Split(' '), int.Parse);
            Dictionary<int, int> frequency = new Dictionary<int, int>();

            foreach (int number in numbers)
            {
                if (frequency.ContainsKey(number))
                {
                    frequency[number]++;
                }
                else
                {
                    frequency[number] = 1;
                }
            }

            int maxFrequency = frequency.Values.Max();
            int mostFrequentNumber = 0;
            foreach (int number in numbers) 
            {
                if (frequency[number] == maxFrequency)
                {
                    mostFrequentNumber = number;
                }
            }

            Console.WriteLine($"The most frequent number is: {mostFrequentNumber}");
        }
    }
}
