/**
 * Definition for a binary tree node.
 * 2
 */
public class Solution {
    private TreeNode _successor;
    public TreeNode InorderSuccessor(TreeNode root, TreeNode p) {
        Dfs(root, p);
        return _successor;
    }

    private void Dfs(TreeNode node, TreeNode p){
        if(node != null){
            if(p.val < node.val && (_successor is null || node.val < _successor.val)){
                _successor = node;
            }
            Dfs(node.left, p);
            Dfs(node.right, p);
        }
    }
}
