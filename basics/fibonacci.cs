using System;
using leetcode;

namespace basics
{
    public class Fibbonacci : IProblem
    {
        public void Run()
        {
            GetNthFibonacci(10).Dump();
            GetNthFibonacci(10).Dump();
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
            if(index == 0) return 0;
            return GetNthFibonacciRecursive(index - 1) + GetNthFibonacciRecursive(index - 2);
        }
    }
}