﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPractice.Design_Patterns.StrategyPattern2
{
    class TextMessage : IAction
    {
        public void DoAction(string message)
        {
            Console.WriteLine("Sending message through SMS: " + message);
        }
    }
}
