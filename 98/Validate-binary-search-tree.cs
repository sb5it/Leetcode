/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public bool IsValidBST(TreeNode root) {
        return Evaluate(root, long.MinValue, long.MaxValue);
    }

    private bool Evaluate(TreeNode node, long min, long max)
    {
        if (node == null)
        {
            return true;
        }

        return node.val > min &&
            node.val < max &&
            Evaluate(node.left, min, node.val) &&
            Evaluate(node.right, node.val, max);
    }
}
