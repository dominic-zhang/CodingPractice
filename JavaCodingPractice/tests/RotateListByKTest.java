import org.junit.Assert;
import org.junit.Test;

import java.util.List;

public class RotateListByKTest {
    @Test
    public void TestCase1() {
        ListNode node5 = new ListNode(5, null);
        ListNode node4 = new ListNode(4, node5);
        ListNode node3 = new ListNode(3, node4);
        ListNode node2 = new ListNode(2, node3);
        ListNode node1 = new ListNode(1, node2);
        ListNode result = RotateListByK.rotateRight(node1, 2);
        Assert.assertEquals(4, result.val);
        result = result.next;
        Assert.assertEquals(5, result.val);
        result = result.next;
        Assert.assertEquals(1, result.val);
        result = result.next;
        Assert.assertEquals(2, result.val);
        result = result.next;
        Assert.assertEquals(3, result.val);
        result = result.next;
        Assert.assertNull(result);
    }

    @Test
    public void TestCase2() {
        ListNode node3 = new ListNode(2, null);
        ListNode node2 = new ListNode(1, node3);
        ListNode node1 = new ListNode(0, node2);
        ListNode result = RotateListByK.rotateRight(node1, 4);
        Assert.assertEquals(2, result.val);
        result = result.next;
        Assert.assertEquals(0, result.val);
        result = result.next;
        Assert.assertEquals(1, result.val);
        result = result.next;
        Assert.assertNull(result);
    }

    @Test
    public void TestCase3() {
        ListNode node1 = null;
        ListNode result = RotateListByK.rotateRight(node1, 0);
        Assert.assertNull(result);
    }

    @Test
    public void TestCase4() {
        ListNode node1 = new ListNode(1, null);
        ListNode result = RotateListByK.rotateRight(node1, 0);
        Assert.assertEquals(1, result.val);
        Assert.assertNull(result.next);
    }

    @Test
    public void TestCase5() {
        ListNode node2 = new ListNode(2, null);
        ListNode node1 = new ListNode(1, node2);
        ListNode result = RotateListByK.rotateRight(node1, 2);
        Assert.assertEquals(1, result.val);
        result = result.next;
        Assert.assertEquals(2, result.val);
        result = result.next;
        Assert.assertNull(result);
    }
}
