using System;
using algo.problems.common;

namespace algo.problems.basics
{
    public class MergeSort : IProblem
    {
        public void Run()
        {
            var input = new[] {1, 25, 12, 45, 78, 96, 15, 19, 26, 38, 75};
            Sort(input, 0, input.Length);
            input.Dump();
        }

        private void Sort(int[] input, int start, int end)
        {
            if (start >= end) return;
            
            var mid = (start + end) / 2;
            Sort(input, start, mid);
            Sort(input, mid + 1, end);
            Merge(input, start, mid, end);
        }

        private void Merge(int[] numbers, int left, int mid, int right)
        {
            int[] temp = new int[numbers.Length];
            int i, left_end, num_elements, tmp_pos;

            left_end = (mid - 1);
            tmp_pos = left;
            num_elements = (right - left + 1);

            while ((left <= left_end) && (mid <= right))
            {
                if (numbers[left] <= numbers[mid])
                    temp[tmp_pos++] = numbers[left++];
                else
                    temp[tmp_pos++] = numbers[mid++];
            }

            while (left <= left_end)
                temp[tmp_pos++] = numbers[left++];

            while (mid <= right)
                temp[tmp_pos++] = numbers[mid++];

            for (i = 0; i < num_elements; i++)
            {
                numbers[right] = temp[right];
                right--;
            }
        }
    }
}