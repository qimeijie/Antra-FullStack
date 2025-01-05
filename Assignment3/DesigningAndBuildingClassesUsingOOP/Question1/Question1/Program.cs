namespace Question1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stock stock = new TechnologyStock("ABC", 100.45);
            stock.DescribeSector();
            stock = new HealthcareStock("EFG", 3.5);
            stock.DescribeSector();
            Console.WriteLine("Market Cap for 100 shares is: " + stock.CalculateMarketCap(100));
        }
    }
}
