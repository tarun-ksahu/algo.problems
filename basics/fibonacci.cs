using algo.problems.common;

namespace algo.problems.basics
{
    public class Fibonacci : IProblem
    {
        public void Run()
        {
            GetType().Name.Dump();
            // GetNthFibonacci(10).Dump();
            GetNthFibonacciRecursive(10).Dump();
        }

        private int GetNthFibonacci(int index)
        {
            int last = 0, current = 1, i = 3;
            if (index <= 1) return last;
            if (index == 2) return current;

            while (i <= index)
            {
                var temp = current;
                current += last;
                last = temp;
                i++;
            }
            return current;
        }

        private int GetNthFibonacciRecursive(int index)
        {
            if(index <= 1) return 1;
            return GetNthFibonacciRecursive(index - 1) + GetNthFibonacciRecursive(index - 2);
        }
    }
}