public class Solution {
    private int sum = 0;
    public int SumNumbers(TreeNode root) {
        Traverse(root, 0);
        return sum;
    }

    private void Traverse(TreeNode node, int currentSum){
        if(node == null) return;
        currentSum *= 10;
        currentSum+= node.val; 

        if(node.right is null && node.left is null){
            sum += currentSum;
        }
        if (node.left is not null) Traverse(node.left, currentSum);
        if (node.right is not null) Traverse(node.right, currentSum);
    }
}
