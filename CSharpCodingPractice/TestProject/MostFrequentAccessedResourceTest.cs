using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp2;
using System.Linq;

namespace TestProject
{
    [TestClass]
    public class MostFrequentAccessedResourceTest
    {
        [TestMethod]
        public void TestMostFrequentAccessedResource1()
        {
            string[][] logs1 = new string[][] {
                new[] { "58523", "user_1", "resource_1" },
                new[] { "62314", "user_2", "resource_2" },
                new[] { "54001", "user_1", "resource_3" },
                new[] { "200", "user_6", "resource_5" },
                new[] { "215", "user_6", "resource_4" },
                new[] { "54060", "user_2", "resource_3" },
                new[] { "53760", "user_3", "resource_3" },
                new[] { "58522", "user_22", "resource_1" },
                new[] { "53651", "user_5", "resource_3" },
                new[] { "2", "user_6", "resource_1" },
                new[] { "100", "user_6", "resource_6" },
                new[] { "400", "user_7", "resource_2" },
                new[] { "100", "user_8", "resource_6" },
                new[] { "54359", "user_1", "resource_3"},
            };

            var result = Solution.GetHighestAccessedResource(logs1);
            Assert.AreEqual("resource_3", result.First());
            Assert.AreEqual("3", result.Last());

        }

        [TestMethod]
        public void TestMostFrequentAccessedResource2()
        {
            string[][] logs2 = new string[][] {
                new[]{"300", "user_1", "resource_3"},
                new[]{"599", "user_1", "resource_3"},
                new[]{"900", "user_1", "resource_3"},
                new[]{"1199", "user_1", "resource_3"},
                new[]{"1200", "user_1", "resource_3"},
                new[]{"1201", "user_1", "resource_3"},
                new[]{"1202", "user_1", "resource_3"}
            };

            var result = Solution.GetHighestAccessedResource(logs2);
            Assert.AreEqual("resource_3", result.First());
            Assert.AreEqual("4", result.Last());
        }

        [TestMethod]
        public void TestMostFrequentAccessedResource3()
        {
            string[][] logs3 = new string[][] {
                new[]{"300", "user_10", "resource_5"}
            };
            var result = Solution.GetHighestAccessedResource(logs3);
            Assert.AreEqual("resource_5", result.First());
            Assert.AreEqual("1", result.Last());
        }
    }
}
