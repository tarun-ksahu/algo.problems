using basics;
using leetcode;
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
            // problem = new Fibbonacci();
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
            // problem = new MaxContigousArray();
            // problem = new NeighbouringNumbers();
            problem = new LongestConsecutiveSubsequence();
            #endregion
            return problem;
        }
    }
}
