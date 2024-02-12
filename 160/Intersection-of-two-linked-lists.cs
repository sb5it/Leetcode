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
        var hashSet = new HashSet<ListNode>();

        while(headA != null || headB != null) {
            if(headA != null) { 
                if (hashSet.Contains(headA)){
                    return headA;
                } else {
                    hashSet.Add(headA);
                }
                headA = headA.next;
            }
            
            if(headB != null){
                if(hashSet.Contains(headB)){
                    return headB;
                } else {
                    hashSet.Add(headB);
                }
                headB = headB.next;
            }
        }
        return null;
    }
}
