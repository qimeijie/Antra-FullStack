namespace Question1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyStack<string> stack = new MyStack<string>();
            stack.Push("Hello");
            stack.Push("World");
            Console.WriteLine($"Count: {stack.Count()}"); // Output: 2
            Console.WriteLine($"Popped: {stack.Pop()}"); // Output: World
            Console.WriteLine($"Count: {stack.Count()}"); // Output: 1
        }
    }
}
