using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPractice.Design_Patterns.StrategyPattern2
{
    class StrategyContext2
    {
        private IAction action;

        public StrategyContext2(IAction action)
        {
            this.action = action;
        }

        public void PerformAction(string mess)
        {
            action.DoAction(mess);
        }
    }
}
