using System.Collections.Generic;
using System.Linq;
using algo.problems._450dsa.arrays;
using algo.problems.basics;
using algo.problems.common;
using algo.problems.leetcode;
using geeksforgeeks;

public class Runner
{
    public static IList<IProblem> problems = new List<IProblem>()
    {
        new LC_01_TwoSum(),
        new LC_01_TwoSumSorted(),
        new LC_03_LongestSubstringNoRepeatedChars(),
        new LC_07_ReverseInteger(),
        new LC_09_PalindromeNumber(),
        new LC_15_ThreeSum(),
        new DuplicateNumber(),
        new LongestConsecutiveSubsequence(),
        new MaxContiguousArray(),
        new MergeSortedArraysWithoutExtraSpace(),
        new MinimizeHeight(),
        new MinMax(),
        new MoveNegativesToLeft(),
        new NeighbouringNumbers(),
        new RotateArray(),
        new BinarySearch(),
        new Fibonacci(),
        new MergeSort(),
        new Sort012Array(),
    };
    public IProblem LastProblem => problems.Last();
}