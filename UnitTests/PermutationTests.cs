using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SU15_Alg_Lab1_Bonus;

namespace UnitTests
{
    [TestClass]
    public class PermutationTests
    {
        [TestMethod]
        public void PermutateJoins()
        {
            int[] input = {1, 2, 3};
            int[,] expected = { {12, 3}, {1, 23} };

            IEnumerable<int[]> actual = Problem5.PermutateJoins(input);

            CollectionAssert.AreEquivalent(expected, actual.ToArray());
        }
    }
}
