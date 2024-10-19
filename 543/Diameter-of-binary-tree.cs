public class Solution {
    private int max = 0;
    public int DiameterOfBinaryTree(TreeNode root) {
        Dfs(root);
        return max;
    }

    private int Dfs(TreeNode node){
        if(node is null) return 0;

        var leftHeight = Dfs(node.left);
        var rightHeight = Dfs(node.right);

        max = Math.Max(max, leftHeight + rightHeight);

        return 1 + Math.Max(leftHeight, rightHeight);
    }
}
