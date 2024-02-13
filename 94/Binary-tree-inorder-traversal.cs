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
    public IList<int> InorderTraversal(TreeNode root) {
        var result = new List<int>();
        InOrder(root, result);
        return result;
    }

    public void InOrder(TreeNode node, List<int> result){
        if(node == null)
            return;
        InOrder(node.left, result);
        result.Add(node.val);
        InOrder(node.right, result);
    }
}
