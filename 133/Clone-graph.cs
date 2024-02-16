/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;

    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}
*/

public class Solution {
    public Node CloneGraph(Node node) {
        if(node == null){
            return null;
        }
        var dict = new Dictionary<Node, Node>();
        
        Node CloneDfs(Node node){
            if(dict.ContainsKey(node)){
                return dict[node];
            }

            var copy = new Node(node.val);
            dict.Add(node, copy);
            foreach(var n in node.neighbors)
                copy.neighbors.Add(CloneDfs(n));

            return copy;
        }

        return CloneDfs(node);
    }
}
