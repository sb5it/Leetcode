public class Solution {
    public IList<IList<int>> PathSum(TreeNode root, int targetSum) {
        var result = new List<IList<int>>();
        Traverse(root, 0, new List<int>(), targetSum, result);
        return result;
    }

    public void Traverse(TreeNode node, int sum, List<int> currentPath, int targetSum, IList<IList<int>> result) {
        if(node is null) return;
        sum += node.val;
        currentPath.Add(node.val);

        if(node.left is null && node.right is null && sum == targetSum){
            result.Add(currentPath.ToList());
        }

        if(node.left is not null) Traverse(node.left, sum, currentPath, targetSum, result);
        if(node.right is not null) Traverse(node.right, sum, currentPath, targetSum, result);

        sum -= node.val;
        currentPath.RemoveAt(currentPath.Count - 1);
    }
}
