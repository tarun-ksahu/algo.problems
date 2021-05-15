using System;
using System.Collections.Generic;
using algo.problems.common;

namespace algo.problems.leetcode
{
    /// <summary>
    /// https://leetcode.com/problems/3sum/
    /// This solution uses the 2sum solution. We first sort the array and then for each number, try to find another
    /// pair to the right of it, that produces 0 - current item value.
    /// </summary>
    public class ThreeSum : IProblem
    {
        public void Run()
        {
            GetType().Name.Dump();
            var input = new[] { -4, -1, -1, 0, 1, 2 };
            Solution(input).Dump();
        }

        public IList<IList<int>> Solution(int[] input)
        {
            IList<IList<int>> result = new List<IList<int>>();
            Array.Sort(input);
            for (var i = 0; i < input.Length - 2; i++)
            {
                if (i == 0 || (input[i] != input[i - 1]))
                {
                    int low = i + 1, high = input.Length - 1;
                    while (low < high)
                    {
                        if (input[low] + input[high] == 0 - input[i])
                        {
                            result.Add(new List<int>() { input[i], input[low], input[high] });

                            // skip duplicates
                            while (low < high && input[low] == input[low + 1])
                                low++;
                            while (low < high && input[high] == input[high - 1])
                                high--;
                            low++;
                            high--;
                        }
                        else if (input[low] + input[high] > 0 - input[i])
                            high--;
                        else
                            low++;
                    }
                }
            }
            return result;
        }
    }
}