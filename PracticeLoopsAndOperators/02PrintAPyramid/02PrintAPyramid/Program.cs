using System.Text;

namespace _02PrintAPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                StringBuilder spaces = new StringBuilder();
                StringBuilder star = new StringBuilder();
                for (int j = 4 - i; j > 0; j--)
                {
                    spaces.Append(" ");
                }
                for (int k =i * 2 + 1; k > 0; k--)
                {
                    star.Append("*");
                }
                Console.WriteLine($"{spaces.ToString()}{star.ToString()}{spaces.ToString()}");
            }
        }
    }
}
