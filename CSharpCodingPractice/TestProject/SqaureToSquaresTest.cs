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
    public class SqaureToSquaresTest
    {
        [TestMethod]
        public void TestSqureToSquares50()
        {
            var expected = "1,3,5,8,49";
            var result = SqureToSqares.decompose(50);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestSqureToSquares11()
        {
            var expected = "1,2,4,10";
            var result = SqureToSqares.decompose(11);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestSqureToSquares4()
        {
            var result = SqureToSqares.decompose(4);

            Assert.IsNull(result);
        }
    }
}
