namespace Question1
{
    internal class TechnologyStock : Stock
    {
        public TechnologyStock(string symbol, double currentPrice) : base(symbol, currentPrice) { }

        public override void DescribeSector()
        {
            Console.WriteLine($"{Symbol} operates in the Technology sector.");
        }
    }
}
