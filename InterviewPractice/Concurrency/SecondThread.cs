using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InterviewPractice.Concurrency
{
    static class SecondThread
    {
        public static void DoSecondTask(int seconds)
        {
            Console.WriteLine("\nSecond task performing for " +seconds +" seconds...");
            Thread.Sleep(seconds * 1000);
            Console.WriteLine("Second task finished.");

        }
    }
}
