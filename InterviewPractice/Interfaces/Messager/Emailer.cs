using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Interfaces.Messager
{
    class Emailer : IMessager
    {
        public string SendMessage(string mes)
        {
            return mes + "\nEmail from Emailer.";
        }
    }
}
