import java.util.ArrayDeque;

public class MapOfHighestPeak {
    public static int[][] highestPeak(int[][] isWater) {
        int m = isWater.length;
        int n = isWater[0].length;
        ArrayDeque<int[]> processCells = new ArrayDeque<>();
        int[][] heightMap = new int[m][n];
        for (int i = 0; i < m; i ++) {
            for (int j = 0; j < n; j++) {
                if (isWater[i][j] == 1) {
                    processCells.add(new int[] {i, j});
                    heightMap[i][j] = 0;
                } else {
                    heightMap[i][j] = -1;
                }
            }
        }

        while (!processCells.isEmpty()) {
            int[] cell = processCells.poll();
            int x = cell[0];
            int y = cell[1];
            int height = heightMap[x][y];
            if (x - 1 >= 0 && heightMap[x-1][y] == -1) {
                heightMap[x-1][y] = height + 1;
                processCells.add(new int[] {x-1, y});
            }
            if (x + 1 < m && heightMap[x+1][y] == -1) {
                heightMap[x+1][y] = height + 1;
                processCells.add(new int[] {x+1, y});
            }
            if (y - 1 >= 0 && heightMap[x][y-1] == -1) {
                heightMap[x][y-1] = height + 1;
                processCells.add(new int[] {x, y-1});
            }
            if (y + 1 < n && heightMap[x][y+1] == -1) {
                heightMap[x][y+1] = height + 1;
                processCells.add(new int[] {x, y+1});
            }
        }


        return heightMap;
    }
}
