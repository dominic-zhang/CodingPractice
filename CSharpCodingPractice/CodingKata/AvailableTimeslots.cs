using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class AvailableTimeslots
    {
        public static int[][] FindAvailableTimeslots(int[][][] schedules)
        {
            List<int[]> combinedList = new List<int[]>();
            foreach (var schedule in schedules)
            {
                combinedList.AddRange(schedule);
            }

            var mergedList = MergeIntervals(combinedList.ToArray());
            List<int[]> result = new List<int[]>();
            int start = 0;
            int end = 0;
            foreach (var timeslot in mergedList)
            {
                if (start < timeslot[0])
                {
                    end = timeslot[0];
                    result.Add(new int[2] { start, end });
                }

                start = timeslot[1];
            }
            if (start < 2400)
            {
                result.Add(new int[2] { start, 2400 });
            }
            return result.ToArray();
        }

        static int[][] MergeIntervals(int[][] intervals)
        {
            List<int[]> result = new List<int[]>();
            //order based on start[i]
            intervals = intervals.OrderBy(x => x[0]).ToArray();

            //iterate through array rows
            foreach (var item in intervals)
            {
                if (result.Count == 0 || result.Last()[1] < item[0])
                {
                    result.Add(item);
                }
                else
                {
                    result.Last()[1] = Math.Max(item[1], result.Last()[1]);
                }

            }
            return result.ToArray();
        }
    }
}
