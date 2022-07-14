using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingKata
{
    public class PyramidSlideDown
    {
        public static int LongestSlideDown(int[][] pyramid)
        {
            if (pyramid.Length == 1)
            {
                return pyramid[0][0];
            }

            for (int i = pyramid.Length - 2; i >= 0; i--)
            {
                for (int j = 0; j < pyramid[i].Length; j++)
                {
                    pyramid[i][j] += Math.Max(pyramid[i + 1][j], pyramid[i + 1][j + 1]);
                }
            }

            return pyramid[0][0];
        }

        public static int LongestSlideDown1(int[][] pyramid)
        {
            // for any pyramid[i][j], left child is pyramid pyramid[i+1][j], right child is pyramid[i+1][j+1]
            List<int> slideDown = new List<int>();
            Stack<int[]> positions = new Stack<int[]>();
            positions.Push(new int[2] { 0, 0 });
            int sum = int.MinValue;

            while(positions.Count > 0)
            {
                var pos = positions.Pop();
                slideDown = slideDown.Take(pos[0]).ToList();
                slideDown.Add(pyramid[pos[0]][pos[1]]);
                if (slideDown.Count == pyramid.Length)
                {
                    var newSum = slideDown.Sum();
                    if (newSum > sum)
                        sum = newSum;
                }

                if (pos[0] + 1 < pyramid.Length)
                {
                    positions.Push(new int[2] { pos[0] + 1, pos[1] + 1 });
                    positions.Push(new int[2] { pos[0] + 1, pos[1] });
                }
            }

            return sum;
        }
    }
}
