using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingKata
{
    public class SnailSolution
    {
        public static int[] Snail(int[][] array)
        {
            int n = array.Length;
            if (n == 0 || array.All(x => x.Length == 0))
            {
                return new int[] { };
            }
            int[][] visited = array.Select(x => x.Select(y => y = 0).ToArray()).ToArray();
            int[] result = new int[n * n];
            int idx = 0;

            int[] pos = { 0, 0 };
            int[] direction = { 0, 1 };
            while (!OutOfBound(pos, n) && visited[pos[0]][pos[1]] == 0)
            {
                visited[pos[0]][pos[1]] = 1;
                int[] nextPos = { pos[0] + direction[0], pos[1] + direction[1] };
                if (OutOfBound(nextPos, n) || visited[nextPos[0]][nextPos[1]] == 1)
                {
                    direction = RotateRight(direction);
                    nextPos[0] = pos[0] + direction[0];
                    nextPos[1] = pos[1] + direction[1];
                }

                result[idx++] = array[pos[0]][pos[1]];
                pos = nextPos;
            }

            return result;
        }

        public static bool OutOfBound(int[] pos, int n)
        {
            return pos[0] >= n || pos[1] >= n || pos[0] < 0 || pos[1] < 0;
        }

        public static int[] RotateRight(int[] direction)
        {
            if (direction[0] == 1 && direction[1] == 0)
            {
                return new int[] { 0, -1 };
            }
            else if (direction[0] == 0 && direction[1] == 1)
            {
                return new int[] { 1, 0 };
            }
            else if (direction[0] == -1 && direction[1] == 0)
            {
                return new int[] { 0, 1 };
            }
            else
            {
                return new int[] { -1, 0 };
            }
        }
    }
}
