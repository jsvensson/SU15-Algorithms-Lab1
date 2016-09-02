using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SU15_Alg_Lab1_Bonus;

namespace UnitTests
{
    [TestClass]
    public class SplitIntTests
    {
        [TestMethod]
        public void Splits_Digits()
        {
            int input = 123;
            int[] expected = {1, 2, 3};

            int[] actual = input.Split().ToArray();

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
