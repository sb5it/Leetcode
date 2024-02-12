/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
    public Node CopyRandomList(Node head) {
        var dict = new Dictionary<Node, Node>();
        Node dummy = new Node(0);
        Node tail = dummy;

        var current = head;
        while (current != null){
            var newNode = new Node(current.val) { random =  current.random};
            dict.Add(current, newNode);
            tail.next = newNode;
            tail = newNode;
            current = current.next;
        }

        current = dummy.next;
        while (current != null){
            if(current.random != null)
                current.random = dict[current.random];
            current = current.next;
        }

        return dummy.next;
    }
}
