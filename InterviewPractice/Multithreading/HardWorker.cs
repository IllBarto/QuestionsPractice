using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace InterviewPractice.Multithreading
{
    class HardWorker
    {
        public async void BeginWork()
        {
            DoEasyWork();
            DoHardWorkAsync();

            await Task.Run(() => 
            {
                double i;
                Console.WriteLine("\nInline task begin.");
                for (i = 0; i < 100000111; i++) ;
                Console.WriteLine("\nInline task completed : " + i);
            });

            DoFinalWork();
        }

        private void DoFinalWork()
        {
            Console.WriteLine("\nPerforming final work...");
        }

        private async Task DoHardWorkAsync()
        {
            double i = 0;
            Console.WriteLine("\nPerforming hard work...");
            await Task.Run(() => {
                for (i = 0; i < 100000011; i++) ;
            });
            Console.WriteLine("\nHard work done : " + i);
        }

        private void DoEasyWork()
        {
            Console.WriteLine("\nPerforming easy work...");
        }
    }
}
