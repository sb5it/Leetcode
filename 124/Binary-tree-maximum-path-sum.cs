public class Solution {
    private int Max = int.MinValue;
    public int MaxPathSum(TreeNode root) {
        Dfs(root);
        return Max;
    }

    private int Dfs(TreeNode node){
        if(node is null) return 0;

        var leftPath = Math.Max(0, Dfs(node.left));
        var rightPath = Math.Max(0, Dfs(node.right));

        Max = Math.Max(Max, leftPath + rightPath + node.val);

        return node.val + Math.Max(leftPath, rightPath);
    }
}
