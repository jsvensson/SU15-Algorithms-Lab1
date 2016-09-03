using System;
using System.Collections.Generic;
using System.IO;
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

            var startTime = DateTime.Now;
            IEnumerable<IEnumerable<int>> set = Problem5.FindPermutations();
            var endTime = DateTime.Now;


            Console.WriteLine($"Run time: {endTime - startTime}");
            Console.WriteLine($"{set.Count()} permutations");
            Console.WriteLine();


            using (StreamWriter writer =
                new StreamWriter("out.txt"))
            {
                foreach (IEnumerable<int> permutation in set)
                {
                    writer.WriteLine($"{{ {string.Join(", ", permutation)} }}");
                }
            }


            //foreach (IEnumerable<int> permutation in set)
            //{
            //    Console.WriteLine($"{{ {string.Join(", ", permutation)} }}");
            //    //if (permutation.Sum() == 100)
            //    //{
            //    //    Console.WriteLine($"{{ {string.Join(", ", permutation)} }}");
            //    //}

            //}

            Console.ReadKey();
        }

        static void PrintSet<T>(IEnumerable<T> set)
        {
            string output = string.Join(", ", set);
            Console.WriteLine($"{{ {output} }}");
        }
    }
}
