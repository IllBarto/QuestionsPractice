
namespace InterviewPractice.Design_Patterns.StrategyPattern
{
    class Addition : IOperation
    {
        public int DoOperation(int a, int b)
        {
            return a + b;
        }
    }
}
