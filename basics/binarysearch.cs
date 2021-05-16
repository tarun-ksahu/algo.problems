using algo.problems.common;

namespace algo.problems.basics
{
    public class BinarySearch : IProblem
    {
        public void Run()
        {
            var input = new[] {1, 5, 7, 8, 10};
            // Search(input, 5).Dump();
            SearchRecursive(input, 10, 0, input.Length).Dump();
        }

        private int SearchRecursive(int[] input, int target, int start, int end)
        {
            if (end <= start) return -1;
            var mid = start + (end - start) / 2;
            if (input[mid] == target) return mid;
            return input[mid] > target
                ? SearchRecursive(input, target, start, mid - 1)
                : SearchRecursive(input, target, mid + 1, end);
        }

        private int Search(int[] input, int numToFind)
        {
            int start = 0, mid = input.Length / 2, end = input.Length - 1;
            while (mid <= end)
            {
                if (input[mid] == numToFind)
                    return mid;
                if (input[mid] > numToFind)
                    end = mid - 1;
                else
                    start = mid + 1;
                mid = (end - start) / 2 + start;
            }

            return -1;
        }
    }
}