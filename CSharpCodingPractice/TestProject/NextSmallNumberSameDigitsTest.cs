using CodingKata;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    [TestClass]
    public class NextSmallNumberSameDigitsTest
    {
        [TestMethod]
        public void Test21()
        {
            int expected = 12;
            Assert.AreEqual(expected, NextSmallNumberSameDigits.GetNumber(21));
        }

        [TestMethod]
        public void Test531()
        {
            int expected = 513;
            Assert.AreEqual(expected, NextSmallNumberSameDigits.GetNumber(531));
        }

        [TestMethod]
        public void Test2071()
        {
            int expected = 2017;
            Assert.AreEqual(expected, NextSmallNumberSameDigits.GetNumber(2071));
        }

        [TestMethod]
        public void Test9()
        {
            int expected = -1;
            Assert.AreEqual(expected, NextSmallNumberSameDigits.GetNumber(9));
        }

        [TestMethod]
        public void Test111()
        {
            int expected = -1;
            Assert.AreEqual(expected, NextSmallNumberSameDigits.GetNumber(111));
        }

        [TestMethod]
        public void Test135()
        {
            int expected = -1;
            Assert.AreEqual(expected, NextSmallNumberSameDigits.GetNumber(135));
        }

        [TestMethod]
        public void Test1027()
        {
            int expected = -1;
            Assert.AreEqual(expected, NextSmallNumberSameDigits.GetNumber(1027));
        }

        [TestMethod]
        public void Test10027()
        {
            int expected = 7210;
            Assert.AreEqual(expected, NextSmallNumberSameDigits.GetNumber(10027));
        }

        [TestMethod]
        public void Test1237513()
        {
            int expected = 1237351;
            Assert.AreEqual(expected, NextSmallNumberSameDigits.GetNumber(1237513));
        }

        [TestMethod]
        public void Test1237135()
        {
            int expected = 1235731;
            Assert.AreEqual(expected, NextSmallNumberSameDigits.GetNumber(1237135));
        }

        [TestMethod]
        public void Test29009()
        {
            int expected = 20990;
            Assert.AreEqual(expected, NextSmallNumberSameDigits.GetNumber(29009));
        }

        [TestMethod]
        public void Test59884848483559()
        {
            long expected = 59884848459853;
            Assert.AreEqual(expected, NextSmallNumberSameDigits.GetNumber(59884848483559));
        }

        [TestMethod]
        public void Test5921212123559()
        {
            long expected = 5921211955322;
            Assert.AreEqual(expected, NextSmallNumberSameDigits.GetNumber(5921212123559));
        }

        [TestMethod]
        public void Test51226262651257()
        {
            long expected = 51226262627551;
            Assert.AreEqual(expected, NextSmallNumberSameDigits.GetNumber(51226262651257));
        }

        [TestMethod]
        public void Test100()
        {
            long expected = 10;
            Assert.AreEqual(expected, NextSmallNumberSameDigits.GetNumber(100));
        }
    }
}
