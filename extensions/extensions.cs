using System;
using System.Collections;

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
}