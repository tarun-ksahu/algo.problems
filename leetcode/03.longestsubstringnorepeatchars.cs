using System;
using System.Collections.Generic;
using algo.problems.common;

namespace algo.problems.leetcode
{
    /// <summary>
    /// https://leetcode.com/problems/longest-substring-without-repeating-characters/
    /// </summary>
    public class LongestSubstringNoRepeadedChars : IProblem
    {
        public void Run()
        {
            GetType().Name.Dump();
            var input = "abcdaghjk";
            var maxlength = Solution(input);
            maxlength.Dump();
        }

        private int Solution(string input)
        {
            var start = 0;
            var seeker = 0;
            var max = 0;
            var set = new HashSet<char>();
            while(seeker < input.Length)
            {
                if (set.Contains(input[seeker]))
                {
                    set.Remove(input[start]);
                    start++;
                }
                else
                {
                    set.Add(input[seeker]);
                    seeker++;
                    max = Math.Max(set.Count, max);
                }
            }
            return max;
        }
    }
}