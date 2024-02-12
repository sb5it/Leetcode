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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        if(list1 == null){
            return list2;
        }

        if(list2 == null) {
            return list1;
        }

        var current1 = list1;
        var current2 = list2;
        ListNode temp = null;
        ListNode head = null;
        while(current1 != null || current2 != null) {
            ListNode currentNode = null;
            if (current1 == null) {
                currentNode = new ListNode(current2.val, null);
                current2 = current2.next;
            } else if(current2 == null) {
                currentNode = new ListNode(current1.val, null);
                current1 = current1.next;
            } else if( current1.val < current2.val) {
                currentNode = new ListNode(current1.val, null);
                current1 = current1.next;
            } else {
                currentNode = new ListNode(current2.val, null);
                current2 = current2.next;
            }
            if(head == null){
                head = currentNode;
                temp = head;
            }else {
                temp.next = currentNode;
                temp = currentNode;
            }
        }

        return head;
    }
}
