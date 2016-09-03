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
            var digits = new Set<int> {1, 2, 3, 4, 5, 6, 7, 8, 9};
            var set = new Set<Set<int>> {digits};

            // Slow-ass join loop
            Set<Set<int>> join;
            for (int i = 0; i < digits.Count - 1; i++)
            {
                var newSet = (Set<Set<int>>)set.Copy();
                join = PermutateJoin(newSet);
                set.Add(join);
            }


            //Set<Set<int>> join1 = PermutateJoin(set);
            //Set<Set<int>> join2 = PermutateJoin(join1);
            //Set<Set<int>> join3 = PermutateJoin(join2);
            //Set<Set<int>> join4 = PermutateJoin(join3);
            //Set<Set<int>> join5 = PermutateJoin(join4);
            //Set<Set<int>> join6 = PermutateJoin(join5);
            //Set<Set<int>> join7 = PermutateJoin(join6);
            //Set<Set<int>> join8 = PermutateJoin(join7);

            //set.Add(join1);
            //set.Add(join2);
            //set.Add(join3);
            //set.Add(join4);
            //set.Add(join5);
            //set.Add(join6);
            //set.Add(join7);
            //set.Add(join8);

            //Set<Set<int>> sub1 = PermutateSubtraction(set);
            //Set<Set<int>> sub2 = PermutateSubtraction(sub1);
            //Set<Set<int>> sub3 = PermutateSubtraction(sub2);
            //Set<Set<int>> sub4 = PermutateSubtraction(sub3);
            //Set<Set<int>> sub5 = PermutateSubtraction(sub4);
            //Set<Set<int>> sub6 = PermutateSubtraction(sub5);
            //Set<Set<int>> sub7 = PermutateSubtraction(sub6);
            //Set<Set<int>> sub8 = PermutateSubtraction(sub7);
            //set.Add(sub1);
            //set.Add(sub2);
            //set.Add(sub3);
            //set.Add(sub4);
            //set.Add(sub5);
            //set.Add(sub6);
            //set.Add(sub7);
            //set.Add(sub8);

            Console.WriteLine($"Total iterations: {iterations}");

            return set;
        }

        public static Set<Set<int>> PermutateJoin(Set<Set<int>> set)
        {
            var permutations = new Set<Set<int>>();

            foreach (Set<int> perm in set)
            {

                int length = perm.Count - 2;
                for (int i = 0; i <= length; i++)
                {
                    var copy = perm.Copy().ToList();
                    int join = int.Parse(copy[i].ToString() + copy[i + 1]);

                    // Insert join at index i, delete i+1 to i+2 that were joined
                    copy.Insert(i, join);
                    copy.RemoveRange(i + 1, 2);

                    var newPerm = new Set<int> {copy};
                    iterations++;
                    permutations.Add(newPerm);
                }

            }

            return permutations;
        }

        public static Set<Set<int>> PermutateSubtraction(Set<Set<int>> set)
        {
            var permutations = new Set<Set<int>>();

            foreach (Set<int> perm in set)
            {
                int length = perm.Count();
                for (int i = 1; i < length; i++)
                {
                    var copy = (Set<int>)perm.Copy();
                    copy[i] *= -1;
                    iterations++;
                    permutations.Add(copy);
                }
            }

            return permutations;
        }

    }
}