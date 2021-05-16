using System;
using algo.problems.common;

namespace geeksforgeeks
{
    /// <summary>
    /// https://www.geeksforgeeks.org/maximum-and-minimum-in-an-array/
    /// </summary>
    class MinMax : IProblem
    {
        public void Run()
        {
            var input = new[] {100, 33, 234, 45, 698, 567, 345};
            var (min, max) = GetMinMax(input);
            min.Dump();
            max.Dump();
        }

        private (int, int) GetMinMax(int[] input)
        {
            if (input.Length == 0) return (0, 0);
            var min = int.MaxValue;
            var max = int.MinValue;
            foreach (var num in input)
            {
                min = Math.Min(min, num);
                max = Math.Max(max, num);
            }

            return (min, max);
        }
    }
}