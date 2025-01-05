namespace Question7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Color redColor = new Color(255, 0, 0);
            Color blueColor = new Color(0, 0, 255);

            Ball ball1 = new Ball(5, redColor);
            Ball ball2 = new Ball(10, blueColor);

            ball1.Throw();
            ball1.Throw();
            ball2.Throw();
            ball2.Pop(); 
            ball2.Throw();

            Console.WriteLine($"Ball 1 (Red) Throw Count: {ball1.ThrowCount}");
            Console.WriteLine($"Ball 2 (Blue) Throw Count: {ball2.ThrowCount}");
        }
    }
}
