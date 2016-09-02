using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SU15_Alg_Lab1_Bonus;

namespace UnitTests
{
    [TestClass]
    public class IntComparatorTests
    {
        [TestMethod]
        public void Compares_9_50()
        {
            // 9 > 50
            Assert.IsTrue(Problem.IntComparator(9, 50));
        }

        [TestMethod]
        public void Compares_50_9()
        {
            // 50 < 9
            Assert.IsFalse(Problem.IntComparator(50, 9));
        }

        [TestMethod]
        public void Compares_7_700()
        {
            // 7 > 700
            Assert.IsTrue(Problem.IntComparator(7, 700));
        }

        [TestMethod]
        public void Compares_700_7()
        {
            // 700 < 7
            Assert.IsFalse(Problem.IntComparator(700, 7));
        }

        [TestMethod]
        public void Compares_600_7()
        {
            // 600 < 7
            Assert.IsFalse(Problem.IntComparator(600, 7));
        }

        [TestMethod]
        public void Compares_800_7()
        {
            // 800 > 7
            Assert.IsTrue(Problem.IntComparator(800, 7));
        }



    }
}
