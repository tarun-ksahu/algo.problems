using System;
using System.Collections.Generic;
using System.Linq;

namespace leetcode
{
    /// <summary>
    /// https://leetcode.com/problems/two-sum/
    /// </summary>
    public class TwoSum : IProblem
    {
        public void Run()
        {
            this.GetType().Name.Dump();
            var input = new[] { 1, 3, 4, 2, 5, 8, 13, 9, 21, 10 };
            var indexes = GetTwoSumIndexes(input, 13);
            indexes.Dump();
        }

        private int[] GetTwoSumIndexes(int[] input, int sum)
        {
            IDictionary<int, int> complements = new Dictionary<int, int>();
            var complement = 0;
            for (var i = 0; i < input.Length; i++)
            {
                complement = sum - input[i];
                if (complements.ContainsKey(complement)) 
                    return new int[] { i, complements[complement] };
                complements.Add(input[i], i);
            }
            return null;
        }
    }
}