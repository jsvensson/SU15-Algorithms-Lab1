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
            var set = new HashSet<Sequence> {digits};

            // Slow-ass join loop
            //Set<Sequence> join;
            //int length = digits.Count - 1;
            //for (int i = 0; i < length; i++)
            //{
            //    var newSet = (Set<Sequence>)set.Copy();
            //    join = PermutateJoin(newSet);
            //    set.Add(join);
            //}

            HashSet<Sequence> join1 = PermutateJoin(set);
            HashSet<Sequence> join2 = PermutateJoin(join1);
            HashSet<Sequence> join3 = PermutateJoin(join2);
            HashSet<Sequence> join4 = PermutateJoin(join3);
            HashSet<Sequence> join5 = PermutateJoin(join4);
            HashSet<Sequence> join6 = PermutateJoin(join5);
            HashSet<Sequence> join7 = PermutateJoin(join6);
            HashSet<Sequence> join8 = PermutateJoin(join7);

            set.UnionWith(join1);
            set.UnionWith(join2);
            set.UnionWith(join3);
            set.UnionWith(join4);
            set.UnionWith(join5);
            set.UnionWith(join6);
            set.UnionWith(join7);
            set.UnionWith(join8);

            HashSet<Sequence> sub1 = PermutateSubtraction(set);
            HashSet<Sequence> sub2 = PermutateSubtraction(sub1);
            HashSet<Sequence> sub3 = PermutateSubtraction(sub2);
            HashSet<Sequence> sub4 = PermutateSubtraction(sub3);
            HashSet<Sequence> sub5 = PermutateSubtraction(sub4);
            HashSet<Sequence> sub6 = PermutateSubtraction(sub5);
            HashSet<Sequence> sub7 = PermutateSubtraction(sub6);
            HashSet<Sequence> sub8 = PermutateSubtraction(sub7);
            set.UnionWith(sub1);
            set.UnionWith(sub2);
            set.UnionWith(sub3);
            set.UnionWith(sub4);
            set.UnionWith(sub5);
            set.UnionWith(sub6);
            set.UnionWith(sub7);
            set.UnionWith(sub8);

            Console.WriteLine($"Total iterations: {iterations}");

            return set;
        }

        public static HashSet<Sequence> PermutateJoin(IEnumerable<Sequence> set)
        {
            var permutations = new HashSet<Sequence>();

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

        public static HashSet<Sequence> PermutateSubtraction(IEnumerable<Sequence> set)
        {
            var permutations = new HashSet<Sequence>();

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