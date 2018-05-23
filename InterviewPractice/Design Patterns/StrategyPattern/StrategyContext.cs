
namespace InterviewPractice.Design_Patterns.StrategyPattern
{
    class StrategyContext
    {
        private IOperation operation;

        public StrategyContext(IOperation operation)
        {
            this.operation = operation;
        }

        public int ExecuteOperation(int a, int b)
        {
            return operation.DoOperation(a, b);
        }
    }
}
