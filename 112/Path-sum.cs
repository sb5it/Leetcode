public class Solution {
    public bool HasPathSum(TreeNode root, int targetSum) {
        return Traverse(root, 0, targetSum);;
    }

    public bool Traverse(TreeNode node, int sum, int targetSum) {
        if (node is null) return false;

        sum += node.val;

        if (node.left is null && node.right is null) {
            return sum == targetSum;
        }

        return Traverse(node.left, sum, targetSum) || Traverse(node.right, sum, targetSum);
    }
}
