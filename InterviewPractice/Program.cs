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
            #region ProgramActions
            //ProgramActions.Perform_Abstractions();
            //ProgramActions.Perform_AttributesReflections();
            //ProgramActions.Perform_Automapper();
            //ProgramActions.Perform_Extension();
            //ProgramActions.Perform_Interfaces();
            //ProgramActions.Perform_MultipleInheritance();
            //ProgramActions.Perform_Polymorphism();
            //ProgramActions.Perform_Polymorphism2();
            //ProgramActions.Perform_Queue();
            //ProgramActions.Perform_StrategyPattern();
            //ProgramActions.Perform_StragetyPattern2();
            //ProgramActions.Perform_Concurrency();
            //ProgramActions.Perform_StrategySingleton();
            //ProgramActions.Perform_Decorator();
            //ProgramActions.Perform_EF();
            //ProgramActions.Perform_Count();
            //ProgramActions.Perform_AsyncAwait();
            //ProgramActions.Perform_JSON();
            #endregion
            ProgramActions.Perform_Lock();
            //Go();

            Console.ReadLine();
        }

        public static void Go()
        {
            GoAsync();
        }
        public static async void GoAsync()
        {
            Console.WriteLine("Starting");

            Task<int> task1 = Sleep(25000);
            Task<int> task2 = Sleep(35000);

            int[] result = await Task.WhenAll(task1, task2);

            Console.WriteLine("Slept for a total of " + result.Sum() + " ms");
        }
        private async static Task<int> Sleep(int ms)
        {
            Console.WriteLine("Sleeping for {0} at {1}", ms, Environment.TickCount);
            await Task.Delay(ms);
            Console.WriteLine("Sleeping for {0} finished at {1}", ms, Environment.TickCount);
            return ms;
        }
    }

    abstract class Operation
    {
        public void Method() { }

        public abstract void Method1();
    }
}
