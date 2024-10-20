public class Solution {
    public int MaxDepth(TreeNode root) {
        return Traverse(root);
    }

    private int Traverse(TreeNode node){
        if(node is null) return 0;

        return 1 + Math.Max(Traverse(node.left), Traverse(node.right));
    }
}
