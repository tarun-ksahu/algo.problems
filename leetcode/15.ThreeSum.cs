using System;
using System.Collections.Generic;

namespace leetcode
{
    /// <summary>
    /// https://leetcode.com/problems/3sum/
    /// </summary>
    public class ThreeSum : IProblem
    {
        public void Run()
        {
            this.GetType().Name.Dump();
            var input = new int[] { 1,2,-2,-1 };
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