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
    public ListNode MergeKLists(ListNode[] lists) {
        if(lists == null || lists.Length == 0){
            return null;
        }

        while (lists.Length > 1){
            var mergedLists = new List<ListNode>();
            for(int i = 0; i < lists.Length; i+=2){
                ListNode l1 = lists[i];
                ListNode l2 = null;
                if(i+1 < lists.Length){
                    l2 = lists[i+1];
                }
                mergedLists.Add(MergeLists(l1, l2));
            }
            lists = mergedLists.ToArray();
        }

        return lists[0];
    }

    public ListNode MergeLists(ListNode l1, ListNode l2){
        var dummy = new ListNode(0, null);
        var tail = dummy;
        while (l1 != null && l2 != null){
            if(l1.val < l2.val){
                tail.next = l1;
                l1 = l1.next;
            } else{
                tail.next = l2;
                l2 = l2.next;
            }
            tail = tail.next;
        }

        if(l1 != null) {
            tail.next = l1;
        } else {
            tail.next = l2;
        }

        return dummy.next;
    }
}
