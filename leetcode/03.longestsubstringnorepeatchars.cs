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
            int start = 0;
            int seeker = 0;
            int max = 0;
            HashSet<char> set = new HashSet<char>();
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