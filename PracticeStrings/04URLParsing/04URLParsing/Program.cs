namespace _04URLParsing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input URL");
            string input = Console.ReadLine();
            string[] parsed = input.Split("://");
            if (parsed.Length > 1)
            {
                Console.WriteLine("[protocol] = " + parsed[0]);
                input = parsed[1];
            }
            else
            {
                Console.WriteLine("[protocol] = ");
                input = parsed[0];
            }
            parsed = input.Split("/");
            if (parsed.Length > 1)
            {
                Console.WriteLine("[server] = " + parsed[0]);
                Console.WriteLine("[resource] = " + parsed[1]);
            }
            else
            {
                Console.WriteLine("[server] = " + parsed[0]);
                Console.WriteLine("[resource] = ");
            }
        }
    }
}
