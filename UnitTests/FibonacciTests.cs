using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SU15_Alg_Lab1_Bonus;

namespace UnitTests
{
    [TestClass]
    public class FibonacciTests
    {
        [TestMethod]
        public void First_Ten()
        {
            ulong[] expected = {0, 1, 1, 2, 3, 5, 8, 13, 21, 34};

            ulong[] actual = Problem.FibonacciForLoop(10);

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
