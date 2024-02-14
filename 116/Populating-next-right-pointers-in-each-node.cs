/*
// Definition for a Node.
public class Node {
    public int val;
    public Node left;
    public Node right;
    public Node next;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, Node _left, Node _right, Node _next) {
        val = _val;
        left = _left;
        right = _right;
        next = _next;
    }
}
*/

public class Solution {
    public Node Connect(Node root) {
        Node current = root, next = root?.left;
        while(current != null && next != null){
            current.left.next = current.right;
            if(current.next != null && current.right != null)
                current.right.next = current.next.left;
            current = current.next;
            if(current == null){
                current = next;
                next = current.left;
            }
        }
        return root;
    }
}
