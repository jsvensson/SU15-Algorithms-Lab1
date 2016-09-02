using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SU15_Alg_Lab1_Bonus;
using System.Collections.Generic;

namespace UnitTests
{
    [TestClass]
    public class AlternatingListTests
    {
        [TestMethod]
        public void Alternates_List()
        {
            var list1 = new List<string> {"1", "2", "3"};
            var list2 = new List<string> {"a", "b", "c"};
            string expected = "{ 1, a, 2, b, 3, c }";

            string actual = Problem.AlternateLists(list1, list2);

            Assert.AreEqual(expected, actual);
        }
    }
}
