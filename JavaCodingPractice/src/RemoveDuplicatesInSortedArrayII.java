public class RemoveDuplicatesInSortedArrayII {
    public static int removeDuplicates(int[] nums) {
        int moves = 0;
        int appeared = 0;
        int currentNum = 1000000;
        for (int i = 0; i < nums.length; i++) {
            if (nums[i] == currentNum) {
                if (appeared == 2) {
                    moves++;
                } else {
                    nums[i - moves] = nums[i];
                    appeared++;
                }
            } else {
                nums[i - moves] = nums[i];
                appeared = 1;
                currentNum = nums[i];
            }
        }

        return nums.length - moves;
    }
}
