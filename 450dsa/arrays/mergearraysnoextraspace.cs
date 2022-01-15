using System;
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
            GetType().Name.Dump();
            var input1 = new[] {4, 6, 9, 15};
            var input2 = new[] {0, 1, 2, 3};
            MergeArrays(input1, input2);
            input1.Dump();
            input2.Dump();
        }

        private void MergeArrays(int[] input1, int[] input2)
        {
            int i = input1.Length - 1, j = 0;
            // move smaller items in second array to first, and keep sorting using insertion sort
            while (i >= 0 && j < input2.Length)
            {
                if (input1[i] <= input2[j]) break;

                var temp = input2[j];
                input2[j] = input1[i];
                input1[i] = temp;
                i--;
                j++;
            }
            Array.Sort(input1);
            Array.Sort(input2);
        }

        private void Sort(int[] input)
        {
            for (var i = 1; i < input.Length; i++)
            {
                if (input[i] < input[i - 1])
                {
                    var temp = input[i - 1];
                    input[i - 1] = input[i];
                    input[i] = temp;
                }
                else break;
            }
        }
    }
}