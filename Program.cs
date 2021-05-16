using algo.problems._450dsa.arrays;
using algo.problems.basics;
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
            #endregion
            #region sorts
            // problem = new MergeSort();
            #endregion
            #region search
            problem = new BinarySearch();
            #endregion
            #region leetcode
            // problem = new TwoSum();
            // problem = new TwoSumSorted();
            // problem = new LongestSubstringNoRepeatedChars();
            // problem = new ReverseInteger();
            // problem = new PalindromeNumber();
            // problem = new RomanToNumber();
            // problem = new ThreeSum();
            #endregion
            #region geeksforgeeks
            // problem = new Sort012Array();
            // problem = new MoveNegativesToLeft();
            // problem = new MaxContiguousArray();
            // problem = new NeighbouringNumbers();
            // problem = new LongestConsecutiveSubsequence();
            // problem = new MergeSortedArraysWithoutExtraSpace();
            // problem = new DuplicateNumber();
            // problem = new MinMax();
            // problem = new RotateArray();
            #endregion
            return problem;
        }
    }
}
