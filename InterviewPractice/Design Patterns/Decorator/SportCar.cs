using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPractice.Design_Patterns.Decorator
{
    class SportCar: CarDecorator
    {
        public SportCar(ICar car) : base(car)
        {
        }

        public new string Model => base.Model + " Sport";
        public new int HorsPower => base.HorsPower + 40;
        public new double Consumption => base.Consumption + 5;
        public new int Price => base.Price + 4000;
    }
}
