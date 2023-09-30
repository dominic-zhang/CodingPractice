import java.util.ArrayList;
import java.util.List;

public class MinLengthOfTwoSubArraysWithTarget {
    public static int minSumOfLengths(int[] arr, int target) {
        int start = 0;
        int end = 0;

        List<Integer[]> subArrays = new ArrayList<Integer[]>();
        int sumOfSubArray = arr[0];
        while (start < arr.length) {
            if (sumOfSubArray == target) {
                subArrays.add(new Integer[] {start, end});
            }

            if (sumOfSubArray >= target) {
                sumOfSubArray -= arr[start];
                start++;
            }

            if (sumOfSubArray < target) {
                if (end == arr.length - 1) {
                    break;
                }
                end++;
                sumOfSubArray += arr[end];
            }
        }

        if (subArrays.size() <= 1) {
            return -1;
        }

        int minLength = 100000000;
        for (int i = 0; i < subArrays.size(); i++) {
            Integer[] a = subArrays.get(i);
            for (int j = i + 1; j < subArrays.size(); j++) {
                Integer[] b = subArrays.get(j);
                if (!overlapped(a, b) && len(a) + len(b) < minLength) {
                    minLength = len(a) + len(b);
                }
            }
        }

        return minLength == 100000000 ? -1 : minLength;
    }

    private static boolean overlapped(Integer[] a, Integer[] b) {
        return (a[0] >= b[0] && a[0] <= b[1]) ||
                (a[1] <= b[1] && a[1] >= b[0]);
    }

    private static int len(Integer[] a) {
        return a[1] - a[0] + 1;
    }
}
