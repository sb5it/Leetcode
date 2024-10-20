public class Solution {
    public IList<int> LargestValues(TreeNode root) {
        if(root is null) return new List<int>();
        var q = new Queue<TreeNode>();
        q.Enqueue(root);
        var result = new List<int>();
        var level = 0;
        while(q.Count > 0){
            var len = q.Count;
            for(int i = 0; i < len; i++){
                var curr = q.Dequeue();
                if(result.Count == level){
                    result.Add(curr.val);   
                } else {
                    result[level] = Math.Max(result[level], curr.val);
                }
                if(curr.left != null) q.Enqueue(curr.left);
                if(curr.right != null) q.Enqueue(curr.right);
            }
            level++;
        }

        return result;
    }
}
