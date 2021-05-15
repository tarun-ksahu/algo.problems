using algo.problems.common;

namespace algo.problems._450dsa.arrays
{
    /// <summary>
    /// geeksforgeeks.org/move-negative-numbers-beginning-positive-end-constant-extra-space/
    /// </summary>
    public class MoveNegativesToLeft : IProblem
    {
        public void Run()
        {
            var input = new[] { -12, 11, -13, -5, 6, -7, 5, -3, -6 };
            ReArrange(input);
            input.Dump();
        }

        private void ReArrange(int[] input)
        {
            int seeker = 0, start = 0;
            while (seeker < input.Length)
            {
                if (input[seeker] > 0)
                    seeker++;
                else
                {
                    if (seeker != start) input.Swap(seeker, start);
                    start++;
                    seeker++;
                }
            }
        }
    }
}