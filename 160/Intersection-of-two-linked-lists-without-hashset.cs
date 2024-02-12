/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
        ListNode l1 = headA, l2 = headB;
        while (l1 != l2){
            if(l1 != null)
                l1 = l1.next;
            else 
                l1 = headB;
            if(l2 != null)
                l2 = l2.next;
            else
                l2 = headA;
        }

        return l1;
    }
}
