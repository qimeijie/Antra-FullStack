namespace _01ReverseString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a string");
            string input = Console.ReadLine();
            char[] chars = input.ToCharArray();
            for (int start = 0, end = chars.Length - 1; start < end; start++, end--)
            {
                char temp = chars[start];
                chars[start] = chars[end];
                chars[end] = temp;
            }
            Console.WriteLine(new string(chars));
            for (int i = input.Length - 1; i >= 0; i--)
            {
                Console.Write(input[i]);
            }
            Console.WriteLine();
        }
    }
}
