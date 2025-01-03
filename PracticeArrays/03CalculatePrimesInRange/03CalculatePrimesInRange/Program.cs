using System;

namespace _03CalculatePrimesInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a start number: ");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input an end number: ");
            int end = Convert.ToInt32(Console.ReadLine());
            int[] result = FindPrimesInRange(start, end);
            Console.WriteLine($"The prime numbers in the range: {string.Join(" ", result)}");
        }
        static int[] FindPrimesInRange(int startNum, int endNum)
        {
            List<int> list = new List<int>();
            for (int i = startNum; i <= endNum; i++)
            {
                if (IsPrime(i) == true) 
                { 
                    list.Add(i);
                }
            }
            return list.ToArray();
        }
        static bool IsPrime(int num)
        {
            if (num <= 1) return false; 
            if (num == 2) return true;  

            int sqrt = (int)Math.Sqrt(num); 
            for (int i = 2; i <= sqrt; i++)
            {
                if (num % i == 0) return false;
            }
            return true;
        }
    }
}
