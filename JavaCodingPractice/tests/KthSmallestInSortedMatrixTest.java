import org.junit.Assert;
import org.junit.Test;

public class KthSmallestInSortedMatrixTest {
    @Test
    public void TestCase1() {
        int[][] input = {{1,5,9},{10,11,13},{12,13,15}};
        Assert.assertEquals(13, KthSmallestInSortedMatrix.kthSmallest(input, 8));
        Assert.assertEquals(13, KthSmallestInSortedMatrix.kthSmallest_TimeComplexity(input, 8));
    }

    @Test
    public void TestCase2() {
        int[][] input = {{-5}};
        Assert.assertEquals(-5, KthSmallestInSortedMatrix.kthSmallest(input, 1));
        Assert.assertEquals(-5, KthSmallestInSortedMatrix.kthSmallest_TimeComplexity(input, 1));
    }
}
