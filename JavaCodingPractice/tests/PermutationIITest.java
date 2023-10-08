import org.junit.Assert;
import org.junit.Test;

import java.util.ArrayList;
import java.util.List;

public class PermutationIITest {
    @Test
    public void TestCase1() {
        int[] nums = {1,1,2};
        List<List<Integer>> expected = new ArrayList<>();
        expected.add(List.of(1,1,2));
        expected.add(List.of(1,2,1));
        expected.add(List.of(2,1,1));
        List<List<Integer>> result = PermutationII.permuteUniqueI(nums);
        Assert.assertEquals(expected.size(), result.size());
        for (List<Integer> p : result) {
            Assert.assertTrue(expected.contains(p));
        }
    }

    @Test
    public void TestCase2() {
        int[] nums = {1,2,3};
        List<List<Integer>> expected = new ArrayList<>();
        expected.add(List.of(1,2,3));
        expected.add(List.of(1,3,2));
        expected.add(List.of(2,1,3));
        expected.add(List.of(2,3,1));
        expected.add(List.of(3,1,2));
        expected.add(List.of(3,2,1));
        List<List<Integer>> result = PermutationII.permuteUniqueI(nums);
        Assert.assertEquals(expected.size(), result.size());
        for (List<Integer> p : result) {
            Assert.assertTrue(expected.contains(p));
        }
    }
}
