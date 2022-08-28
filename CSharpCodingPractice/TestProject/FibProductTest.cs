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
    public class FibProductTest
    {
        [TestMethod]
        public void Test4895()
        {
            ulong[] r = new ulong[] { 55, 89, 1 };
            Assert.IsTrue(CompareFibProd(r, FibProduct.ProductFib(4895)));
        }

        [TestMethod]
        public void Test800()
        {
            ulong[] r = new ulong[] { 34, 55, 0 };
            Assert.IsTrue(CompareFibProd(r, FibProduct.ProductFib(800)));
        }

        [TestMethod]
        public void Test714()
        {
            ulong[] r = new ulong[] { 21, 34, 1 };
            Assert.IsTrue(CompareFibProd(r, FibProduct.ProductFib(714)));
        }

        private bool CompareFibProd(ulong[] expected, ulong[] result)
        {
            return expected[0] == result[0] && expected[1] == result[1] && expected[2] == result[2];
        }
    }
}
