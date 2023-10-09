public class RotateListByK {
    public static ListNode rotateRight(ListNode head, int k) {
        if (head == null) {
            return null;
        }

        int n = 1;
        ListNode last = head;
        while (last.next != null) {
            n++;
            last = last.next;
        }

        int nodesToKeep = n - k % n;
        if (n == nodesToKeep) {
            return head;
        }

        ListNode current = head;
        while (nodesToKeep > 1) {
            nodesToKeep--;
            current = current.next;
        }

        ListNode temp = current.next;
        current.next = null;
        last.next = head;
        head = temp;
        return head;
    }
}
