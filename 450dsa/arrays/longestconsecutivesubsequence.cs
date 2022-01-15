using System;
using System.Collections.Generic;
using algo.problems.common;

namespace algo.problems._450dsa.arrays
{
    /// <summary>
    /// https://practice.geeksforgeeks.org/problems/longest-consecutive-subsequence2449/1
    /// </summary>
    public class LongestConsecutiveSubsequence : IProblem
    {
        public void Run()
        {
            GetType().Name.Dump();
            var input = new[] { 6, 6, 2, 3, 1, 4, 1, 5, 6, 2, 8, 7, 4, 2, 1, 3, 4, 5, 9, 6 };
            GetLongestSequenceCountWithSet(input).Dump();
            // GetLongestSequenceCount(input).Dump();
        }

        private object GetLongestSequenceCount(int[] input)
        {
            Array.Sort(input);
            var max = 1;
            var current = 1;
            for (var i = 1; i < input.Length; i++)
            {
                if (input[i] - input[i - 1] == 1)
                {
                    current++;
                    max = Math.Max(max, current);
                }
                else if (input[i] == input[i - 1]) continue;
                else current = 1;
            }
            return max;
        }

        private object GetLongestSequenceCountWithSet(int[] input)
        {
            var set = new HashSet<int>();
            for (var i = 0; i < input.Length; i++)
            {
                if (!set.Contains(input[i])) set.Add(input[i]);
            }
            int max = 0, current = 0;
            foreach (var item in set)
            {
                if (set.Contains(item - 1) || set.Contains(item + 1))
                {
                    current++;
                    max = Math.Max(max, current);
                }
                else current = 1;
            }
            return max;
        }
    }
}