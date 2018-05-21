using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Abstractions
{
    class Supermarket : Market
    {
        private List<string> itemsSelled;

        public Supermarket(string marketType, string location): base(marketType, location)
        {

        }

        public override List<string> SelledItems { get => itemsSelled; set { itemsSelled = value; } }
    }
}
