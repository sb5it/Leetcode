/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode OddEvenList(ListNode head) {
        if (head == null || head.next == null) return head;

        var lastOdd = head;
        var lastEven = head.next;
        var firstEven = head.next;
        var isOdd = true;
        var node = lastEven.next;

        while (node != null)
        {
            if (isOdd)
            {
                lastOdd.next = node;
                lastOdd = node;
            }
            else
            {
                lastEven.next = node;
                lastEven = node;
            }

            node = node.next;
            isOdd = !isOdd;
        }
        
        lastEven.next = null;
        lastOdd.next = firstEven;
        return head;
    }
}
