public class Solution {
    private int count = 0;
    private int result = -1;
    
    public int KthSmallest(TreeNode root, int k) {
        InorderTraversal(root, k);
        return result;
    }

    private void InorderTraversal(TreeNode node, int k) {
        // Base case: if the node is null, return
        if (node == null) return;

        // Traverse the left subtree
        InorderTraversal(node.left, k);

        // Visit the current node
        count++;
        if (count == k) {
            result = node.val;
            return;
        }

        // Traverse the right subtree
        InorderTraversal(node.right, k);
    }
}
