using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Abstractions
{
    public abstract class Market
    {
        private string mkType, loc;

        public Market(string marketType, string location)
        {
            mkType = marketType;
            loc = location;
        }

        public virtual string GetMarketType { get => mkType; }
        public virtual string GetLocation { get => loc; }

        public virtual string MarketActivity()
        {
            return "This market's purpose is to sell items at the market price.";
        }

        public abstract List<string> SelledItems { get; set; }
    }
}
