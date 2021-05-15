using algo.problems.common;

namespace algo.problems._450dsa.arrays
{
    /// <summary>
    /// https://practice.geeksforgeeks.org/problems/merge-two-sorted-arrays5135/1
    /// </summary>
    public class MergeSortedArraysWithoutExtraSpace : IProblem
    {
        public void Run()
        {
            var input1 = new[] { 1, 3, 5, 7 };
            var input2 = new[] { 0, 2, 6, 8, 9 };
            MergeArrays(input1, input2);
            input1.Dump();
            input2.Dump();
        }

        private void MergeArrays(int[] input1, int[] input2)
        {
        }
    }
}