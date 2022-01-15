using System.Collections;

namespace algo.problems.common
{
    public static class Extensions
    {
        public static void Dump(this object input, bool newline = true)
        {
            if (input is IEnumerable enumerable and not string)
            {
                foreach (var item in enumerable)
                {
                    Dump(item, false);
                    System.Console.Write(" ");
                }
                System.Console.Write("  ");
            }
            else
            {
                if (newline) System.Console.WriteLine(input);
                else System.Console.Write(input);
            }
        }
        public static void Swap(this int[] input, int index1, int index2)
        {
            var temp = input[index1];
            input[index1] = input[index2];
            input[index2] = temp;
        }
    }
}