using System;
using algo.problems.common;

namespace algo.problems._450dsa.arrays
{
    /// <summary>
    /// https://leetcode.com/problems/find-the-duplicate-number/
    /// </summary>
    public class DuplicateNumber : IProblem
    {
        public void Run()
        {
            GetType().Name.Dump();
            var input = new[]
            {
                1,3,4,2,2
            };
            GetDuplicateNumberFloyd(input).Dump();
        }

        private int GetDuplicateNumber(int[] input)
        {
            var duplicate = -1;
            var current = 0;
            for (var i = 0; i < input.Length; i++)
            {
                current = Math.Abs(input[i]);
                if (input[current - 1] < 1)
                    return current;
                input[current - 1] *= -1;
            }
            return duplicate;
        }
        
        private int GetDuplicateNumberFloyd(int[] input)
        {
            var tortoise = input[0];
            var hare = input[0];
            do
            {
                tortoise = input[tortoise];
                hare = input[input[hare]];
            } while (tortoise != hare);

            tortoise = input[0];
            while (tortoise != hare)
            {
                tortoise = input[tortoise];
                hare = input[hare];
            }
            return hare;
        }
    }
}