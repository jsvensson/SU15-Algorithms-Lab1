using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SU15_Alg_Lab1_Bonus
{

    public class Problem5
    {
        public static void Permutations()
        {
            int[] digits = {1, 2, 3};

            var permutations = new List<int[]>();

            // Starting set = all-positive permutation
            permutations.Add(digits);

        }

        public static IEnumerable<int[]> PermutateJoins(IEnumerable<int> set)
        {
            var perms = new List<int[]>();
            int count = set.Count() - 1;
            int[] arr = set.ToArray();

            for (int i = 0; i < set.Count(); i++)
            {

            }




        }

    }
}