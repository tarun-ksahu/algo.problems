using algo.problems._450dsa.arrays;
using algo.problems.common;
using geeksforgeeks;

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

            #region basics
            // problem = new Fibonacci();
            #region sorts
            #endregion

            #region search
            #endregion
            #endregion

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
            #region 15. three sum
            // problem = new ThreeSum();
            #endregion
            #endregion

            #region geeksforgeeks
            // problem = new Sort012Array();
            // problem = new MoveNegativesToLeft();
            // problem = new MaxContiguousArray();
            // problem = new NeighbouringNumbers();
            // problem = new LongestConsecutiveSubsequence();
            // problem = new MergeSortedArraysWithoutExtraSpace();
            // problem = new DuplicateNumber();
            problem = new MinMax();
            #endregion
            return problem;
        }
    }
}
