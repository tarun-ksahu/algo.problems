using algo.problems.common;

namespace algo.problems.leetcode
{
    /// <summary>
    /// https://leetcode.com/problems/reverse-integer
    /// </summary>
    public class ReverseInteger : IProblem
    {
        public void Run()
        {
            GetType().Name.Dump();
            var input = 467846568;
            Reverse(input).Dump();
        }

        private int Reverse(int input)
        {
            var reverse = 0;
            while(input > 0){
                reverse = reverse * 10 + input % 10;
                input /= 10;
            }
            return reverse;
        }
    }
}