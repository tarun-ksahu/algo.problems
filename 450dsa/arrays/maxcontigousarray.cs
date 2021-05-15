using System;
using leetcode;

namespace geeksforgeeks
{
    /// <summary>
    /// https://practice.geeksforgeeks.org/problems/kadanes-algorithm-1587115620/1
    /// </summary>
    public class MaxContigousArray : IProblem
    {
        public void Run()
        {
            var input = new int[] { -1, -2, -3, -4 };
            GetMaxSum(input).Dump();
        }

        private int GetMaxSum(int[] input)
        {
            int max = Int16.MinValue;
            int currentSum = Int16.MinValue;
            for (var i = 0; i < input.Length; i++)
            {
                currentSum = Math.Max(currentSum + input[i], input[i]);
                max = Math.Max(currentSum, max);
            }
            return max;
        }
    }
}