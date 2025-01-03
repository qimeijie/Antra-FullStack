using System.Text;

namespace _06Counting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                List<int> numbers = new List<int>();
                for (int j = 0; j <= 24; j += i) {
                    numbers.Add(j);
                }
                Console.WriteLine(string.Join(", ", numbers));
            }
        }
    }
}
