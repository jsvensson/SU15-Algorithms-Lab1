using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SU15_Alg_Lab1_Bonus;

namespace UnitTests
{
    [TestClass]
    public class SortNumbersTests
    {
        [TestMethod]
        public void Sorts_Numbers_1()
        {
            int[] input = {32, 1, 7};
            string expected = "7321";

            string actual = Problem.SortNumbers(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Sorts_Numbers_2()
        {
            int[] input = { 50, 2, 1, 9 };
            string expected = "95021";

            string actual = Problem.SortNumbers(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Sorts_Numbers_3()
        {
            int[] input = { 11, 1, 101, 12 };
            string expected = "12111011";

            string actual = Problem.SortNumbers(input);

            Assert.AreEqual(expected, actual);
        }



    }
}
