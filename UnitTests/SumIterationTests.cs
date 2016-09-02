using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using SU15_Alg_Lab1_Bonus;

namespace UnitTests
{
    [TestClass]
    public class SumIterationTests
    {
        [TestMethod]
        public void For_Sums_List()
        {
            List<int> input = new List<int> { 1, 2, 3, 4, 5 };
            int expected = 15;

            int actual = Problem.SumWithFor(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void While_Sums_List()
        {
            List<int> input = new List<int> { 1, 2, 3, 4, 5 };
            int expected = 15;

            int actual = Problem.SumWithWhile(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Recursion_Sums_List()
        {
            List<int> input = new List<int> { 1, 2, 3, 4, 5 };
            int expected = 15;

            int actual = Problem.SumWithRecursion(0, input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Recursion2_Sums_List()
        {
            List<int> input = new List<int> { 1, 2, 3, 4, 5 };
            int expected = 15;

            int actual = Problem.SumWithRecursion2(input);

            Assert.AreEqual(expected, actual);
        }
    }
}
