import org.junit.Assert;
import org.junit.Test;

public class Utf8ValidationTest {
    @Test
    public void TestCase_ValidTwoBytesUtf8() {
        int[] input = new int[] {197,130,1};
        Assert.assertTrue(Utf8Validation.validUtf8(input));
    }

    @Test
    public void TestCase_InvalidThreeBytesUtf8() {
        int[] input = new int[] {235,140,4};
        Assert.assertFalse(Utf8Validation.validUtf8(input));
    }

    @Test
    public void TestCase_OneBytesUtf8() {
        int[] input = new int[] {145};
        Assert.assertFalse(Utf8Validation.validUtf8(input));
    }

    @Test
    public void TestCase_FiveBytesUtf8() {
        int[] input = new int[] {250,145,145,145,145};
        Assert.assertFalse(Utf8Validation.validUtf8(input));
    }
}
