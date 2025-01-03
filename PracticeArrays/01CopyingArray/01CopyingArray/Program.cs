namespace _01CopyingArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            for (int i = 0; i < 10; i++)
            {
                numbers[i] = i;
            }
            Console.WriteLine($"The original array is {string.Join(" ", numbers)}");
            int[] numbers2 = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++) 
            { 
                numbers2[i] = numbers[i];
            }
            Console.WriteLine($"\nThe copied array is {string.Join(" ", numbers2)}");
        }
    }
}
