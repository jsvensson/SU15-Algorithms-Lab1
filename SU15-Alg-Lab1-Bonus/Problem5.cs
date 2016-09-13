using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Set;

namespace SU15_Alg_Lab1_Bonus
{

    public class Problem5
    {
        private static int iterations;
        public static IEnumerable<IEnumerable<int>> FindPermutations()
        {
            var digits = new Sequence {1, 2, 3, 4, 5, 6, 7, 8, 9};
            var set = new Set<Sequence> {digits};

            // Slow-ass join loop
            //Set<Sequence> join;
            //int length = digits.Count - 1;
            //for (int i = 0; i < length; i++)
            //{
            //    var newSet = (Set<Sequence>)set.Copy();
            //    join = PermutateJoin(newSet);
            //    set.Add(join);
            //}

            Set<Sequence> join1 = PermutateJoin(set);
            Set<Sequence> join2 = PermutateJoin(join1);
            Set<Sequence> join3 = PermutateJoin(join2);
            Set<Sequence> join4 = PermutateJoin(join3);
            Set<Sequence> join5 = PermutateJoin(join4);
            //Set<Sequence> join6 = PermutateJoin(join5);
            //Set<Sequence> join7 = PermutateJoin(join6);
            //Set<Sequence> join8 = PermutateJoin(join7);

            set.Add(join1);
            set.Add(join2);
            set.Add(join3);
            set.Add(join4);
            set.Add(join5);
            //set.Add(join6);
            //set.Add(join7);
            //set.Add(join8);

            Set<Sequence> sub1 = PermutateSubtraction(set);
            Set<Sequence> sub2 = PermutateSubtraction(sub1);
            Set<Sequence> sub3 = PermutateSubtraction(sub2);
            Set<Sequence> sub4 = PermutateSubtraction(sub3);
            Set<Sequence> sub5 = PermutateSubtraction(sub4);
            //Set<Sequence> sub6 = PermutateSubtraction(sub5);
            //Set<Sequence> sub7 = PermutateSubtraction(sub6);
            //Set<Sequence> sub8 = PermutateSubtraction(sub7);
            set.Add(sub1);
            set.Add(sub2);
            set.Add(sub3);
            set.Add(sub4);
            set.Add(sub5);
            //set.Add(sub6);
            //set.Add(sub7);
            //set.Add(sub8);

            Console.WriteLine($"Total iterations: {iterations}");

            return set;
        }

        public static Set<Sequence> PermutateJoin(IEnumerable<Sequence> set)
        {
            var permutations = new Set<Sequence>();

            foreach (Sequence seq in set)
            {
                int length = seq.Count - 1;
                for (int i = 0; i < length; i++)
                {
                    List<int> copy = seq.ToList();
                    int join = int.Parse(copy[i].ToString() + copy[i + 1]);

                    // Insert join at index i, delete i+1 to i+2 that were joined
                    copy.Insert(i, join);
                    copy.RemoveRange(i + 1, 2);

                    var newPerm = new Sequence {copy};
                    iterations++;
                    permutations.Add(newPerm);
                }
            }

            return permutations;
        }

        public static Set<Sequence> PermutateSubtraction(IEnumerable<Sequence> set)
        {
            var permutations = new Set<Sequence>();

            foreach (Sequence seq in set)
            {
                int length = seq.Count();
                for (int i = 1; i < length; i++)
                {
                    List<int> copy = seq.ToList();
                    copy[i] *= -1;
                    iterations++;
                    permutations.Add(new Sequence {copy});
                }
            }

            return permutations;
        }

    }
}