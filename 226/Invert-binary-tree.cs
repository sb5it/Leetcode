public class Solution {
    public TreeNode InvertTree(TreeNode root) {
        if(root is null) return root;
        var stack = new Stack<TreeNode>();
        stack.Push(root);
        while(stack.Any()){
            var curr = stack.Pop();
            (curr.left, curr.right) = (curr.right, curr.left);
            if(curr.left != null) stack.Push(curr.left);
            if(curr.right != null) stack.Push(curr.right);
        }

        return root;
    }
}
