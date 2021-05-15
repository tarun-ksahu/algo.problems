using System;
using leetcode;

namespace algo.problems
{
    class Program
    {
        static void Main(string[] args)
        {
            GetProblem().Run();
            "\nDone!".Dump();
        }

        private static IProblem GetProblem()
        {
            IProblem problem;
            #region leetcode
            #region 1. twosum
            // problem = new TwoSum();
            #endregion
            #region 1. twosumsorted
            // problem = new TwoSumSorted();
            #endregion
            #region 3. longest substring without repeated characters
            // problem = new LongestSubstringNoRepeadedChars();
            #endregion
            #region 7. reverse integer
            // problem = new ReverseInteger();
            #endregion
            #region 9. palindrome number
            // problem = new PalindromeNumber();
            #endregion
            #region 9. Roman To Number
            // problem = new RomanToNumber();
            #endregion
            #region 9. Roman To Number
            problem = new ThreeSum();
            #endregion
            #endregion

            #region geeksforgeeks

            #endregion
            return problem;
        }
    }
}
