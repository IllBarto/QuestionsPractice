using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Abstractions
{
    class AirMarket : Market
    {
        public AirMarket(string marketType, string location): base(marketType, location)
        {

        }

        public override string MarketActivity()
        {
            return base.MarketActivity() + "\nBeside this, its the safest market in the region.";
        }
        private List<string> items;

        public override List<string> SelledItems { get => items; set { items = value; } }
    }
}
