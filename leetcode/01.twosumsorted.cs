using algo.problems.common;

namespace algo.problems.leetcode
{
    /// <summary>
    /// https://leetcode.com/problems/two-sum/
    /// </summary>
    public class TwoSumSorted : IProblem
    {
        public void Run()
        {
            GetType().Name.Dump();
            var input = new[] { 1, 3, 4, 5, 8, 13, 21 };
            var indexes = GetTwoSumIndexes(input, 13);
            indexes.Dump();
        }

        private int[] GetTwoSumIndexes(int[] input, int sum)
        {
            int low = 0, high = input.Length - 1;
            while (low < high)
            {
                if (input[low] + input[high] == sum)
                    return new[] { low, high };
                if (input[low] + input[high] > sum)
                    high--;
                else
                    low++;
            }
            return null;
        }
    }
}