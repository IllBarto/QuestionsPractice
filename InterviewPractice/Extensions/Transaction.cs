using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Extentions
{
    class Transaction
    {
        private double amount { get; set; }

        public double Value
        {
            get { return amount; }
            private set { }
        }

        public Transaction(double amount)
        {
            this.amount = amount;
        }

        public bool TransactionPassed()
        {
            if (amount > 0) return true;

            return false;
        }
    }
}
