import java.util.ArrayList;
import java.util.Arrays;
import java.util.HashMap;
import java.util.List;

public class PermutationII {
    public static List<List<Integer>> permuteUnique(int[] nums) {
        List<Integer> input = Arrays.stream(nums).boxed().toList();
        List<List<Integer>> result = recursivePermute(input);
        List<List<Integer>> unique = new ArrayList<>();
        for (List<Integer> r : result) {
            if (!unique.contains(r))
                unique.add(r);
        }
        return unique;
    }

    private static List<List<Integer>> recursivePermute(List<Integer> input) {
        List<List<Integer>> result = new ArrayList<>();
        if (input.size() == 1) {
            result.add(input);
            return result;
        }
        List<Integer> visited = new ArrayList<>();
        for (Integer num : input) {
            if (visited.contains(num)) {
                continue;
            }

            visited.add(num);
            List<Integer> nums = new ArrayList<>(input);
            nums.remove(num);
            List<List<Integer>> subResult = recursivePermute(nums);
            for (List<Integer> r : subResult) {
                r.add(0, num);
                result.add(r);
            }
        }

        return result;
    }

    private static void solve(int[] nums, int index, List<List<Integer>> ans)
    {
        if(index >= nums.length)
        {
            ans.add(Arrays.stream(nums).boxed().toList());
            return;
        }

        for(int i = index; i < nums.length; i++)
        {
            swap(nums, index, i);
            solve(nums, index + 1, ans);

            //backtrack
            swap(nums, index, i);
        }
    }

    private static void swap(int[] nums, int m, int n) {
        int temp = nums[m];
        nums[m] = nums[n];
        nums[n] = temp;
    }

    public static List<List<Integer>> permuteUniqueI(int[] nums) {
        List<List<Integer>> ans = new ArrayList<>();
        List<List<Integer>> unique = new ArrayList<>();
        int index = 0;
        solve(nums, index, ans);
        for (List<Integer> r : ans) {
            if (!unique.contains(r))
                unique.add(r);
        }
        return unique;
    }
}
