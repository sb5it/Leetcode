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
    public IList<IList<int>> ZigzagLevelOrder(TreeNode root) {
        var result = new List<IList<int>>();
        var q = new Queue<TreeNode>();
        q.Enqueue(root);
        var fromLeft = true;
        while (q.Count > 0){
            fromLeft = !fromLeft;
            var level = new List<int>();
            var length = q.Count;
            for(int i = 0; i < length; i++){
                var node = q.Dequeue();
                if(node != null){
                    if(!fromLeft)
                        level.Add(node.val);
                    else
                        level.Insert(0, node.val);          
                    q.Enqueue(node.left);
                    q.Enqueue(node.right); 
                }
            }
            if(level.Count > 0) {
                result.Add(level);
            }
        }
        return result;
    }
}
