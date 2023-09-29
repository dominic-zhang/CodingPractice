import org.junit.Assert;
import org.junit.Test;

public class CalculatorTest {
    @Test
    public void TestCaseAdd()
    {
        Assert.assertEquals(3, Calculator.Add(1, 2));
    }
}