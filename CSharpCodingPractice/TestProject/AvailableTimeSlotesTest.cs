using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp2;
using System.Linq;

namespace TestProject
{
    [TestClass]
    public class AvailableTimeSlotesTest
    {
        [TestMethod]
        public void TestAvailableTimeslots()
        {
            int[][] p1Meetings = new int[][]
            {
                new int[] {0, 844},
                new int[] {1555, 2020},
                new int[] {901, 945},
                new int[] {1130, 1345}
            };

            int[][] p2Meetings = new int[][]
            {
                new int[] {200, 900},
                new int[] {1655, 2220}
            };

            int[][] p3Meetings = new int[][]
            {
                new int[] {1230, 1420}
            };

            int[][][] schedules = new int[][][] { p1Meetings, p2Meetings, p3Meetings };
            int[][] result = AvailableTimeslots.FindAvailableTimeslots(schedules);

            int[][] expected = new int[][]
            {
                new int[] {900, 901},
                new int[] {945, 1130},
                new int[] {1420, 1555},
                new int[] {2220, 2400}
            };

            Assert.IsTrue(expected.Length == result.Length);
            Assert.IsTrue(Compare2DArray(expected, result));
        }

        private bool Compare2DArray(int[][] a, int[][] b)
        {
            if (a.Length != b.Length)
            {
                return false;
            }

            foreach (var a1 in a)
            {
                bool found = false;
                foreach (var b1 in b)
                {
                    if (b1[0] == a1[0] && b1[1] == a1[1])
                    {
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
