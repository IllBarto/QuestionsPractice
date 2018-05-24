using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InterviewPractice.Concurrency
{
    static class MainThread
    {
        public static void DoFirstTask(int seconds)
        {
            Console.WriteLine("Doing sleep method for "+seconds+" seconds...");
            Thread.Sleep(seconds * 1000);
            Console.WriteLine("Sleeping task finished.");

        }
    }
}
