using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp2;
using System.Linq;

namespace TestProject
{
    [TestClass]
    public class SearchRotatedArrayTest
    {
        [TestMethod]
        public void TestSearchRotatedArray()
        {
            int[] nums = { 4, 5, 6, 7, 0, 1, 2 };
            int target = 7;

            Assert.AreEqual(3, SearchRotatedArray.Search(nums, target));
        }

        [TestMethod]
        public void TestSearchRotatedArray1()
        {
            int[] nums = { 4, 5, 6, 7, 0, 1 };
            int target = 7;

            Assert.AreEqual(3, SearchRotatedArray.Search(nums, target));
        }

        [TestMethod]
        public void TestSearchRotatedArray2()
        {
            int[] nums = { 1, 2, 4, 5, 6, 7, 0};
            int target = 7;

            Assert.AreEqual(5, SearchRotatedArray.Search(nums, target));
        }

        [TestMethod]
        public void TestSearchRotatedArray3()
        {
            int[] nums = { 7, 0, 1, 2, 4, 5, 6 };
            int target = 4;

            Assert.AreEqual(4, SearchRotatedArray.Search(nums, target));
        }
    }
}
