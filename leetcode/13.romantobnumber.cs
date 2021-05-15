using algo.problems.common;

namespace algo.problems.leetcode
{
    /// <summary>
    /// https://leetcode.com/problems/roman-to-integer/
    /// </summary>
    public class RomanToNumber : IProblem
    {
        public void Run()
        {
            GetType().Name.Dump();
            var input = "MCMXCIV";
            GetIntFromRoman(input).Dump();
        }

        private int GetIntFromRoman(string input)
        {
            var num = 0;
            var prev = '0';
            for (var i = 0; i < input.Length; i++)
            {
                switch (input[i])
                {
                    case 'I':
                        num += 1;
                        break;
                    case 'V':
                        num += prev == 'I' ? 3 : 5;
                        break;
                    case 'X':
                        num += prev == 'I' ? 8 : 10;
                        break;
                    case 'L':
                        num += prev == 'X' ? 30 : 50;
                        break;
                    case 'C':
                        num += prev == 'X' ? 80 : 100;
                        break;
                    case 'D':
                        num += prev == 'C' ? 300 : 500;
                        break;
                    case 'M':
                        num += prev == 'C' ? 800 : 1000;
                        break;
                }
                prev = input[i];
            }
            return num;
        }
    }
}