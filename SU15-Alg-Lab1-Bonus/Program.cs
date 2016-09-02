using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SU15_Alg_Lab1_Bonus
{
    class Program
    {
        static void Main(string[] args)
        {
            //ulong[] fib = Problem.FibonacciForLoop(100);
            //Console.WriteLine(string.Join(",", fib));


            Problem5.Permutations();

        }

        static void PrintSet<T>(IEnumerable<T> set)
        {
            string output = string.Join(", ", set);
            Console.WriteLine($"{{ {output} }}");
        }
    }
}
