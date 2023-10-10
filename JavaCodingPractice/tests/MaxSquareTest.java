import org.junit.Assert;
import org.junit.Test;

public class MaxSquareTest {
    @Test
    public void TestCase1() {
        char[][] input = {{'1','0','1','0','0'},{'1','0','1','1','1'},{'1','1','1','1','1'},{'1','0','0','1','0'}};
        Assert.assertEquals(4, MaxSquare.maximalSquare(input));
    }

    @Test
    public void TestCase2() {
        char[][] input = {{'0','1'},{'1','0'}};
        Assert.assertEquals(1, MaxSquare.maximalSquare(input));
    }

    @Test
    public void TestCase3() {
        char[][] input = {{'0'}};
        Assert.assertEquals(0, MaxSquare.maximalSquare(input));
    }

    @Test
    public void TestCase4() {
        char[][] input = {{'0', '1'}};
        Assert.assertEquals(1, MaxSquare.maximalSquare(input));
    }

    @Test
    public void TestCase5() {
        char[][] input = {{'0'}, {'1'}};
        Assert.assertEquals(1, MaxSquare.maximalSquare(input));
    }
}
