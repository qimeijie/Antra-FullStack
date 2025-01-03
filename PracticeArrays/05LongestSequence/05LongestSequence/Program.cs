namespace _05LongestSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter integers separated by spaces:");
            string input = Console.ReadLine();
            string[] inputNumbers = input.Split(' ');
            int[] numbers = Array.ConvertAll(inputNumbers, int.Parse);
            if (numbers.Length == 0)
            {
                return;
            }
            int maxLength = 0;
            int number = 0;
            int index = 0;
            while (index < numbers.Length)
            {
                int curLength = 1;
                while (curLength + index < numbers.Length && numbers[index] == numbers[index + curLength]) 
                { 
                    curLength++;
                }
                if (curLength > maxLength)
                {
                    number = numbers[index];
                    maxLength = curLength;
                }
                index += curLength;
            }
            for (int i = 0; i < maxLength; i++)
            {
                Console.Write($"{number} ");
            }
        }
    }
}
