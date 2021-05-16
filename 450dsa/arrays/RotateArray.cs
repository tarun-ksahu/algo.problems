using System;
using algo.problems.common;

namespace algo.problems._450dsa.arrays
{
    /// <summary>
    /// https://practice.geeksforgeeks.org/problems/cyclically-rotate-an-array-by-one/0
    /// </summary>
    public class RotateArray : IProblem
    {
        public void Run()
        {
            var input = new[] {1, 2, 3, 4, 5};
            ShiftArray(input, 3);
            input.Dump();
        }

        private void ShiftArray(int[] input, int places)
        {
            while (places > 0)
            {
                for (var i = input.Length - 1; i > 0; i--)
                {
                    input.Swap(i, i - 1);
                }
                places--;
            }
        }
    }
}