import org.junit.Assert;
import org.junit.Test;

public class MapOfHighestPeakTest {
    @Test
    public void TestCase_2by2_1Water() {
        //Input: isWater = [[0,1],[0,0]]
        //Output: [[1,0],[2,1]]
        int[][] isWater = {{0,1}, {0,0}};
        int[][] expect = {{1,0}, {2,1}};
        int[][] result = MapOfHighestPeak.highestPeak(isWater);
        Assert.assertArrayEquals(expect[0], result[0]);
        Assert.assertArrayEquals(expect[1], result[1]);
    }

    @Test
    public void TestCase_3by3_2Water() {
        //Input: isWater = [[0,0,1],[1,0,0],[0,0,0]]
        //Output: [[1,1,0],[0,1,1],[1,2,2]]
        int[][] isWater = {{0,0,1}, {1,0,0}, {0,0,0}};
        int[][] expect = {{1,1,0}, {0,1,1},{1,2,2}};
        int[][] result = MapOfHighestPeak.highestPeak(isWater);
        Assert.assertArrayEquals(expect[0], result[0]);
        Assert.assertArrayEquals(expect[1], result[1]);
        Assert.assertArrayEquals(expect[2], result[2]);
    }
}
