// Given a list of n integers print two numbers before and after a specific integer occurrence 
// Ex - {1,3,5,6,8,9,7,6,2,0,4,6}

using System.Collections.Generic;
using algo.problems.common;

namespace algo.problems._450dsa.arrays
{
    public class NeighbouringNumbers : IProblem
    {
        public void Run()
        {
            GetType().Name.Dump();
            var input = new[] { 1, 3, 5, 6, 8, 9, 7, 6, 2, 0, 4, 6 };
            GetNeighbors(input, 6).Dump();
        }

        private object GetNeighbors(int[] input, int value)
        {
            var neighbors = new List<int>();
            for (var i = 0; i < input.Length; i++)
            {
                if (input[i] == value)
                {
                    if (i >= 2) neighbors.Add(input[i - 2]);
                    if (i >= 1) neighbors.Add(input[i - 1]);
                    if (i <= input.Length - 3) neighbors.Add(input[i + 2]);
                    if (i <= input.Length - 2) neighbors.Add(input[i + 1]);
                }
            }
            return neighbors.ToArray();
        }
    }
}