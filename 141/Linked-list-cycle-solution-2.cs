public class Solution {
    public bool HasCycle(ListNode head) {
        ListNode slow = head, fast = head?.next;
        while(slow != null && fast != null && slow != fast){
            slow = slow.next;
            fast = fast.next?.next;
        }

        return slow != null && fast != null && slow == fast;
    }
}
