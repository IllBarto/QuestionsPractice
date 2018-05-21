using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Extentions
{
    static class Extention
    {
        public static string GetTransactionError(this Transaction transaction)
        {
            if (transaction.Value < 0) return "Error. Amount of transaction is negative.";

            if (transaction.Value == 0)
            {
                return "Error. Amount of transaction is zero.";
            }

            return "Unkown error accoured.";
        }
    }
}
