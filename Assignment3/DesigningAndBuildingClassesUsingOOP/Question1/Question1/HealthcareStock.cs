using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    internal class HealthcareStock : Stock
    {
        public HealthcareStock(string symbol, double currentPrice) : base(symbol, currentPrice)
        {
        }

        public override void DescribeSector()
        {
            Console.WriteLine($"{Symbol} operates in the Healthcare sector.");
        }
    }
}
