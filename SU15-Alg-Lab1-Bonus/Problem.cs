using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SU15_Alg_Lab1_Bonus
{
    public static class Problem
    {
        public static int SumWithFor(List<int> numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                sum += i;
            }

            return sum;
        }

        public static int SumWithWhile(List<int> numbers)
        {
            int position = 0;
            int sum = 0;

            while (position < numbers.Count)
            {
                sum += numbers[position];
                position++;
            }

            return sum;
        }

        public static int SumWithRecursion(int head, List<int> tail)
        {
            if (tail.Count == 1)
            {
                return head + tail[0];
            }

            int newHead = tail[0];
            List<int> newTail = tail.GetRange(1, tail.Count - 1);

            return head + SumWithRecursion(newHead, newTail);
        }

        public static int SumWithRecursion2(List<int> numbers)
        {
            if (numbers.Count == 1)
            {
                return numbers[0];
            }

            int head = numbers[0];
            List<int> tail = numbers.GetRange(1, numbers.Count - 1);

            return head + SumWithRecursion2(tail);
        }

        public static string AlternateLists(List<string> list1, List<string> list2)
        {
            int length = list1.Count + list2.Count;
            string[] result = new string[length];


            for (int i = 0; i < list1.Count; i++)
            {
                int firstPos = i*2;
                int secondPos = i*2 + 1;

                result[firstPos] = list1[i];
                result[secondPos] = list2[i];
            }

            string outString = string.Join(", ", result);
            return $"{{ {outString} }}";
        }

        public static ulong[] FibonacciForLoop(int count)
        {
            ulong[] fib = new ulong[count];
            fib[0] = 0;
            fib[1] = 1;

            for (int i = 2; i < count; i++)
            {
                fib[i] = fib[i - 1] + fib[i - 2];
            }

            return fib;
        }

        public static bool IntComparator(int higher, int lower)
        {
            int[] high = higher.Split().ToArray();
            int[] low = lower.Split().ToArray();

            // If both digits as pos x are equal, shortest number is bigger
            //  7 > 70
            //  7 == 77

            // If digits at pos x are not equal, highest digit is larger
            // 7 > 69
            // 71 < 72

            // Compare length-wise
            int length = Math.Min(high.Length, low.Length);

            for (int i = 0; i < length; i++)
            {
                if (high[i] >= low[i])
                {
                    return true;
                }
            }

            return false;
        }

        public static IEnumerable<int> Split(this int number)
        {
            var stack = new Stack<int>();

            do
            {
                stack.Push(number % 10);
                number /= 10;
            } while (number > 0);

            return stack;
        }

        public static string SortNumbers(IEnumerable<int> numbers)
        {
            //string[] result = numbers.Cast<string>().ToArray();
            string[] result = numbers.Select(i => i.ToString()).ToArray();
            Array.Sort(result);
            Array.Reverse(result);
            return string.Join("", result);
        }
    }
}
