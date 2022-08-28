using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleApp2
{
    public class SearchRotatedArray
    {
        public static int Search(int[] nums, int target)
        {
            //{4,5,6,7,0,1,2}
            //{4,5,6,7,0,1}
            int start = 0;
            int end = nums.Length - 1;
            int pivot = 0;
            while (start <= end)
            {
                var mid = (start + end) / 2;
                if (nums[mid] > nums[start])
                {
                    start = mid;
                }
                else if (nums[mid] < nums[start])
                {
                    end = mid;
                }
                else
                {
                    pivot = end;
                    break;
                }
            }

            if (target >= nums[pivot] && target <= nums.Last())
            {
                start = pivot;
                end = nums.Length - 1;
            }
            else
            {
                start = 0;
                end = pivot - 1;
            }

            while (start <= end)
            {
                var mid = (start + end) / 2;
                if (target < nums[mid])
                {
                    end = mid - 1;
                }
                else if (target > nums[mid])
                {
                    start = mid + 1;
                }
                else
                {
                    return mid;
                }
            }

            return -1;
        }
    }
}
