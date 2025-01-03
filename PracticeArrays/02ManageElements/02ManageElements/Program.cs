namespace _02ManageElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<String> elements = new List<String>();
            while (true) 
            {
                Console.WriteLine("Enter command (+ item, - item, or -- to clear)):");
                string input = Console.ReadLine();
                if (input == null)
                {
                    continue;
                }
                else if (input.StartsWith("--"))
                {
                    elements.Clear();
                }
                else if (input.StartsWith("-"))
                {
                    elements.Remove(input.Substring(1).Trim());
                } else if (input.StartsWith("+"))
                {
                    elements.Add(input.Substring(1).Trim());
                }
                Console.WriteLine("Current list: ");
                for (int i = 0; i < elements.Count; i++)
                {
                    Console.WriteLine($"{elements[i]}");
                }
            }
        }
    }
}
