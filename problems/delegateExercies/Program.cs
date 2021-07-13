using System;

namespace delegateExercies
{
    class Expresion
    {
        private int first;
        private int second;
        public Expresion(int first, int second)
        {
            this.first = first;
            this.second = second;
        }

        private int Sum()
        {
            return first + second;
        }

        private int Subtract()
        {
            return first - second;
        }

        private int Multiply()
        {
            return first * second;
        }

        public int ApplyOperator(Operation operation)
        {
            OperationManager operationManager = new OperationManager();
            operationManager.AddOperation(Operation.Sum, Sum);
            operationManager.AddOperation(Operation.Substract, Subtract);
            operationManager.AddOperation(Operation.Multiply, Multiply);

            return operationManager.DelegateExecute[operation]();
            /*
            switch (operation)
            {
                case Operation.Sum:
                    return Sum();
                case Operation.Substract:
                    return Subtract();
                case Operation.Multiply:
                    return Multiply();
                default:
                    return -1;

            }
            */
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Expresion expresion = new(20, 50);
            var sum = expresion.ApplyOperator(Operation.Sum);
            Console.WriteLine($"Result Sum: {sum}");

            var multilply = expresion.ApplyOperator(Operation.Multiply);
            Console.WriteLine($"Result Multilply: {multilply}");
        }
    }
}
