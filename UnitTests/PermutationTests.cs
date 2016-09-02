using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SU15_Alg_Lab1_Bonus;
using Set;

namespace UnitTests
{
    [TestClass]
    public class PermutationTests
    {
        [TestMethod]
        public void Permutate_Joins()
        {
            var input = new Set<int[]> {new[] {1, 2, 3, 4}};
            IEnumerable<int>[] expected =
            {
                new[] {12, 3, 4},
                new[] {1, 23, 4},
                new[] {1, 2, 34}
            };

            IEnumerable<int>[] actual = Problem5.PermutateJoin(input).ToArray();

            CollectionAssert.AreEquivalent(expected, actual);
        }

        [TestMethod]
        public void Permutate_Joins_Step2()
        {
            var input = new Set<int[]>
            {
                new[] {12, 3, 4},
                new[] {1, 23, 4},
                new[] {1, 2, 34}
            };

            IEnumerable<int>[] expected =
            {
                new[] {123, 4},
                new[] {12, 34},
                new[] {1, 234}
            };

            IEnumerable<int>[] actual = Problem5.PermutateJoin(input).ToArray();

            CollectionAssert.AreEquivalent(expected, actual);

        }
    }
}
