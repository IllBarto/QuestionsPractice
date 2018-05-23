
namespace InterviewPractice.Design_Patterns.StrategyPattern
{
    class Multiplication : IOperation
    {
        public int DoOperation(int a, int b)
        {
            return a * b;
        }
    }
}
