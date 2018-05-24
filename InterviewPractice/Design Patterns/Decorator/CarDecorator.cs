
namespace InterviewPractice.Design_Patterns.Decorator
{
    abstract class CarDecorator : ICar
    {
        private ICar car;

        public CarDecorator(ICar car)
        {
            this.car = car;
        }

        public string Model => car.Model;

        public int HorsPower => car.HorsPower;

        public double Consumption => car.Consumption;

        public int Price => car.Price;
    }
}
