using System.Collections;

namespace algo.problems.common
{
    public static class Extensions
    {
        public static void Dump(this object input, bool newline = true)
        {
            if (input is IEnumerable && input is not string)
            {
                foreach (var item in (IEnumerable)input)
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
        public static void Swap(this int[] input, int start, int mid)
        {
            int temp = input[start];
            input[start] = input[mid];
            input[mid] = temp;
        }
    }
}