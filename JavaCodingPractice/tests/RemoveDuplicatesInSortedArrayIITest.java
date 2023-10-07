import org.junit.Assert;
import org.junit.Test;

public class RemoveDuplicatesInSortedArrayIITest {
    @Test
    public void TestCase1() {
        int[] nums = {1,1,1,2,2,3};
        int[] expected = {1,1,2,2,3};
        int k = RemoveDuplicatesInSortedArrayII.removeDuplicates(nums);
        Assert.assertEquals(5, k);
        for (int i = 0; i < k; i++) {
            Assert.assertEquals(expected[i], nums[i]);
        }
    }

    @Test
    public void TestCase2() {
        int[] nums = {0,0,1,1,1,1,2,3,3};
        int[] expected = {0,0,1,1,2,3,3};
        int k = RemoveDuplicatesInSortedArrayII.removeDuplicates(nums);
        Assert.assertEquals(7, k);
        for (int i = 0; i < k; i++) {
            Assert.assertEquals(expected[i], nums[i]);
        }
    }
}
