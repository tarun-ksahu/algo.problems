using algo.problems.common;

namespace algo.problems._450dsa.arrays
{
    /// <summary>
    /// https://practice.geeksforgeeks.org/problems/minimize-the-heights3351/1
    /// </summary>
    public class MinimizeHeight : IProblem
    {
        public void Run()
        {
            GetType().Name.Dump();
            var input = new[] {3, 9, 12, 16, 20};
            Minimize(input);
            input.Dump();
        }

        private void Minimize(int[] input)
        {
            
        }
    }
}