namespace Question2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<int> intList = new MyList<int>();
            intList.Add(10);
            intList.Add(20);
            intList.Add(30);
            intList.Remove(2);
            Console.WriteLine($"Contains 30: {intList.Contains(30)}"); // Output: False
            Console.WriteLine($"Find at index 1: {intList.Find(1)}"); // Output: 20
            intList.InsertAt(11, 1);
            Console.WriteLine($"Find at index 1 after InsertAt: {intList.Find(1)}"); // Output: 11
            Console.WriteLine($"Removed element: {intList.Remove(0)}"); // Output: 10
            intList.DeleteAt(0);
            Console.WriteLine($"Find at index 0 after DeleteAt: {intList.Find(0)}"); // Output: 20
            intList.Clear();
        }
    }
}
