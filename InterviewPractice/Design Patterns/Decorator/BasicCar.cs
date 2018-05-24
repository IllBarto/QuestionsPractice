
// Concrete Component
namespace InterviewPractice.Design_Patterns.Decorator
{
    class BasicCar : ICar
    {
        public string Model { get => "Honda Civic"; }
        public int HorsPower { get => 100; }
        public double Consumption { get => 5.6; }
        public int Price { get => 6000; }
    }
}
