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
            var input = new Set<Sequence> {new Sequence {1, 2, 3, 4}};
            var expected = new Set<Sequence>
            {
                new Sequence {12, 3, 4},
                new Sequence {1, 23, 4},
                new Sequence {1, 2, 34}
            };

            var actual = Problem5.PermutateJoin(input);

            Assert.IsTrue(expected.EqualTo(actual));
        }

    }
}
