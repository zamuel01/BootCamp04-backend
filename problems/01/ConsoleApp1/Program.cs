using System;
namespace DotNetDebugging
{
    class Program
    {
        static void Main(string[] args)
        {
            Array.ForEach(Fibonacci(6), Console.WriteLine);
            Console.ReadKey(true);
        }
        static int[] Fibonacci(int n)
        {
            int[] solution = new int[n];
            int n1 = 0;
            int n2 = 1;
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                sum = n1 + n2;
                solution[i] = n1;
                n1 = n2;
                n2 = sum;
            }

            return solution;
        }
    }
}
//0 1 1 2 3 5