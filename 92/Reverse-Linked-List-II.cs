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
    public ListNode ReverseBetween(ListNode head, int left, int right) {
        var list = new List<ListNode>();
        var node = head;
        while(node != null)
        {
            list.Add(node);
            node = node.next;
        }

        left = left-1;
        right = right-1;

        while(left < right){
            var temp = list[left];
            list[left] = list[right];
            list[right] = temp;
            left+=1;
            right-=1;
        }

        Console.WriteLine(string.Join(",", list.Select(l => l.val)));

        for(int i = 0; i < list.Count; i++){
            if(i+1 < list.Count)
                list[i].next = list[i+1];
            else
                list[i].next = null;
        }

        return list[0];
    }
}
