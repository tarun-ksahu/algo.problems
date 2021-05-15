using System;
using leetcode;

namespace geeksforgeeks
{
    /// <summary>
    /// https://practice.geeksforgeeks.org/problems/sort-an-array-of-0s-1s-and-2s4231/1
    /// </summary>
    public class Sort012Array : IProblem
    {
        public void Run()
        {
            // var input = new int[] { 0, 2, 1, 2, 0 };
            var input = new int[] { 1, 2, 1, 0, 1, 0, 0, 2, 1, 2, 0 };
            Sort(input);
            input.Dump();
        }

        private void Sort(int[] input)
        {
            int start = 0, mid = 0, end = input.Length - 1;
            while (end > mid)
            {
                if (input[mid] == 0)
                {
                    if (mid != start)
                        input.Swap(mid, start);
                    mid++;
                    start++;
                }
                else if (input[mid] == 2)
                {
                    input.Swap(mid, end);
                    end--;
                }
                else
                    mid++;
            }
        }
    }
}