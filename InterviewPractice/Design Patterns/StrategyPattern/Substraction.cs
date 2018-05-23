
namespace InterviewPractice.Design_Patterns.StrategyPattern
{
    class Substraction : IOperation
    {
        public int DoOperation(int a, int b)
        {
            return a - b;
        }
    }
}
