namespace Question1
{
    internal abstract class Stock
    {
        public string Symbol { get; set; }
        public double CurrentPrice { get; set; }
        public Stock(string symbol, double currentPrice)
        {
            Symbol = symbol;
            CurrentPrice = currentPrice;
        }
        public abstract void DescribeSector();

        public double CalculateMarketCap(double numberOfShares) 
        {
            return numberOfShares * CurrentPrice;
        }

        public double CalculateMarketCap(int numberOfShares)
        {
            return numberOfShares * CurrentPrice;
        }
    }
}
