using Practice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPractice.CountObjects
{
    class Car
    {
        public static int MyCarCounter { get; set; } = 0;
        public Car()
        {
            CarCounter.Count++;
            MyCarCounter++;
        }

        public string Model { get; set; }

        public int NumberOfCars => CarCounter.Count;
    }
}
