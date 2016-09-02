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
        public static IEnumerable<IEnumerable<int>> FindPermutations()
        {
            var digits = new Set<int> {1, 2, 3, 4};
            var set = new Set<Set<int>> {digits};

            Set<Set<int>> join1 = PermutateJoin(set);
            Set<Set<int>> join2 = PermutateJoin(join1);

            return set;
        }

        public static IEnumerable<T> Permutate<T>(IEnumerable<T> set, Func<IEnumerable<T>, IEnumerable<T>> rules)
        {
            return rules(set);
        }

        public static Set<Set<int>> PermutateJoin(Set<Set<int>> set)
        {
            var permutations = new Set<Set<int>>();

            foreach (Set<int> perm in set)
            {

                int length = perm.Count - 2;
                for (int i = 0; i <= length; i++)
                {
                    List<int> copy = perm.Copy().ToList();
                    int join = int.Parse(copy[i].ToString() + copy[i + 1]);

                    // Insert join at pos X, delete X+1 to X+2 that were joined
                    int pos = Math.Max(0, i);
                    copy.Insert(pos, join);
                    copy.RemoveRange(pos + 1, 2);


                    // Check if we've already generated this permutation
                    bool exists = false;
                    foreach (Set<int> e in permutations)
                    {
                        if (perm.EqualTo(e))
                        {
                            exists = true;
                            break;
                        }
                    }

                    if (!exists)
                    {
                        var newPerm = new Set<int> {copy};
                        permutations.Add(newPerm);
                    }
                }

            }

            return permutations;
        }

        public static Set<Set<int>> PermutateSubtraction(Set<Set<int>> set)
        {
            var permutations = new Set<Set<int>>();

            foreach (Set<int> perm in set)
            {

                int length = perm.Count() - 1;
                for (int i = 1; i <= length; i++)
                {
                    List<int> copy = perm.Copy().ToList();
                    copy[i] = copy[i] - 2*copy[i];


                    // Check if we've already generated this permutation
                    bool exists = false;
                    foreach (Set<int> e in permutations)
                    {
                        if (perm.EqualTo(e))
                        {
                            exists = true;
                            break;
                        }
                    }

                    if (!exists)
                    {
                        var newPerm = new Set<int> { copy };
                        permutations.Add(newPerm);
                    }
                }

            }

            return permutations;
        }

    }
}