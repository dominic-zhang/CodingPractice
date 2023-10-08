import java.util.Comparator;
import java.util.PriorityQueue;

/// TimeComplexity O(k * n), SpaceComplexity O(n)
public class KthSmallestInSortedMatrix {
    public static int kthSmallest(int[][] matrix, int k) {
        int n = matrix.length;
        int[] indexes = new int[n];
        int count = 0;
        int result = 0;
        while (count < k) {
            int smallest = Integer.MAX_VALUE;
            int index = 0;
            for (int i = 0; i < n; i++) {
                if (indexes[i] < n && matrix[i][indexes[i]] < smallest) {
                    smallest = matrix[i][indexes[i]];
                    index = i;
                    result = smallest;
                }
            }
            indexes[index]++;
            count++;
        }
        return result;
    }

    /// TimeComplexity O(k * log(min(k,n))), SpaceComplexity O(min(k,n))
    public static int kthSmallest_TimeComplexity(int[][] matrix, int k) {
        int m = matrix.length, n = matrix[0].length, ans = -1; // For general, the matrix need not be a square
        PriorityQueue<int[]> minHeap = new PriorityQueue<>(Comparator.comparingInt(o -> o[0]));
        for (int r = 0; r < Math.min(m, k); ++r)
            minHeap.offer(new int[]{matrix[r][0], r, 0});

        for (int i = 1; i <= k; ++i) {
            int[] top = minHeap.poll();
            int r = top[1];
            int c = top[2];
            ans = top[0];
            if (c + 1 < n)
                minHeap.offer(new int[]{matrix[r][c + 1], r, c + 1});
        }
        return ans;
    }
}
