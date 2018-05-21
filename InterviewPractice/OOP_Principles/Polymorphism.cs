
namespace Practice.OOP_Principles
{
    class Polymorphism
    {
        public string AddSome()
        {
            return "Add.";
        }

        public int AddSome(int a)
        {
            return ++a;
        }

        public double AddSome(int a, int b)
        {
            return a + b;
        }

        public int AddSome(int a, int? b, int? c)
        {
            return a + (b ?? 1) + (c ?? 1);
        }

        public virtual double AddSome(params double [] ps)
        {
            double sum = 0;

            foreach (var item in ps)
            {
                sum += item;
            }

            return sum;
        }
    }
}