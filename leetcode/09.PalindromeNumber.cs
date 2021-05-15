using algo.problems.common;

namespace algo.problems.leetcode
{
    /// <summary>
    /// https://leetcode.com/problems/palindrome-number/
    /// </summary>
    public class PalindromeNumber : IProblem
    {
        public void Run()
        {
            GetType().Name.Dump();
            var input = 1234321;
            (Reverse(input) == input).Dump();
        }

        private int Reverse(int input)
        {
            var reverse = 0;
            while (input > 0)
            {
                reverse = reverse * 10 + input % 10;
                input /= 10;
            }
            return reverse;
        }
    }
}