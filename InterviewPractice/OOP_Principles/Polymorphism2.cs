using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPractice.OOP_Principles
{
    class Polymorphism2
    {
        public void Method(int a)
        {
            Console.Write("\n" + a);
        }

        public void Method(int a, int b, int c, int q)
        {
            Console.Write($"\n{a}, {b}.");
        }

        public void Method(params int [] l)
        {
            Console.WriteLine("Params method:");
            for (int i = 0; i < l.Count(); i++)
            {
                Console.Write($"{l[i]}");
                if (i != l.Count() - 1) { Console.Write(", "); }
            }
        }
    }
}
