import org.junit.Assert;
import org.junit.Test;

public class MinLengthofTwoSubArraysWithTargetTest {
    @Test
    public void TestCase_OnlyTwoSubArrays()
    {
        int[] arr = new int[] {3,2,2,4,3};
        Assert.assertEquals(2, MinLengthOfTwoSubArraysWithTarget.minSumOfLengths(arr, 3));
    }
    @Test
    public void TestCase_ThreeSubArrays()
    {
        int[] arr = new int[] {7,3,4,7};
        Assert.assertEquals(2, MinLengthOfTwoSubArraysWithTarget.minSumOfLengths(arr, 7));
    }
    @Test
    public void TestCase_OneSubArray()
    {
        int[] arr = new int[] {4,3,2,6,2,3,4};
        Assert.assertEquals(-1, MinLengthOfTwoSubArraysWithTarget.minSumOfLengths(arr, 6));
    }

    @Test
    public void TestCase_OvermappingSubArrays()
    {
        int[] arr = new int[] {1,6,1};
        Assert.assertEquals(-1, MinLengthOfTwoSubArraysWithTarget.minSumOfLengths(arr, 7));
    }

    @Test
    public void TestCase_ThreeOverlappedSubArrays()
    {
        int[] arr = new int[] {1,1,1,1,2,3,1,1,1};
        Assert.assertEquals(9, MinLengthOfTwoSubArraysWithTarget.minSumOfLengths(arr, 6));
    }

    @Test
    public void TestCase_MultipleOverlappingArrays()
    {
        int[] arr = new int[] {2,2,4,4,4,4,4,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1};
        Assert.assertEquals(23, MinLengthOfTwoSubArraysWithTarget.minSumOfLengths(arr, 20));
    }
}
