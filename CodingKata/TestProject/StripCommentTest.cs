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
    public class StripCommentTest
    {
        [TestMethod]
        public void StripComments()
        {
            Assert.AreEqual(
                    "apples, pears\ngrapes\nbananas",
                    StripComment.StripComments("apples, pears # and bananas\ngrapes\nbananas !apples", new string[] { "#", "!" }));

            Assert.AreEqual("a\nc\nd", StripComment.StripComments("a #b\nc\nd $e f g", new string[] { "#", "$" }));

        }
    }
}
