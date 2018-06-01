using Practice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //ProgramActions.Perform_Abstractions();
            //ProgramActions.Perform_AttributesReflections();
            //ProgramActions.Perform_Automapper();
            //ProgramActions.Perform_Extension();
            //ProgramActions.Perform_Interfaces();
            //ProgramActions.Perform_MultipleInheritance();
            //ProgramActions.Perform_Polymorphism();
            //ProgramActions.Perform_Queue();
            //ProgramActions.Perform_StrategyPattern();
            //ProgramActions.Perform_StragetyPattern2();
            //ProgramActions.Perform_Concurrency();
            //ProgramActions.Perform_StrategySingleton();
            //ProgramActions.Perform_Decorator();
            //ProgramActions.Perform_EF();
            ProgramActions.Perform_Count();

            Console.ReadLine();
        }
    }

    abstract class Operation
    {
        public void Method() { }

        public abstract void Method1();
    }
}
