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
    private Dictionary<string, List<TreeNode>> _subTrees = new Dictionary<string, List<TreeNode>>();
    private List<TreeNode> _result = new List<TreeNode>();

    public IList<TreeNode> FindDuplicateSubtrees(TreeNode root) {
        Dfs(root);
        return _result;
    }

    private string Dfs(TreeNode root) {
        if (root == null) return "n";
        var s = string.Join(",", new string[] { root.val.ToString(), Dfs(root.left), Dfs(root.right)});
        if (_subTrees.ContainsKey(s) && _subTrees[s].Count == 1) {
            _result.Add(root);
        }
        if (!_subTrees.TryAdd(s, new List<TreeNode>{root})) {
            _subTrees[s].Add(root);
        }
        return s;
    }
}
