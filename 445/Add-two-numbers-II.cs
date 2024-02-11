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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        var stack1 = new Stack<int>();
        var stack2 = new Stack<int>();

        var node1 = l1;
        while(node1 != null){
            stack1.Push(node1.val);
            node1 = node1.next;
        }

        var node2 = l2;
        while(node2 != null){
            stack2.Push(node2.val);
            node2 = node2.next;
        }

        int carry = 0;
        ListNode result = null; 
        while (stack1.Count > 0 || stack2.Count > 0 || carry > 0){
            var sum = carry;
            if (stack1.Count>0) sum+= stack1.Pop();
            if (stack2.Count>0) sum+= stack2.Pop();

            var node = new ListNode(sum % 10);
            node.next = result;
            result = node;

            carry = sum / 10;
        }

        return result;
    }
}
