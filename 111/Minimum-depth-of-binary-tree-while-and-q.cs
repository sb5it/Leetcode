public class Solution {
    public int MinDepth(TreeNode root) {
        if (root is null) return 0;
        var level = 1;
        var q = new Queue<TreeNode>();
        q.Enqueue(root);
        while(q.Count > 0){
            var len = q.Count;
            for(int i = 0; i < len; i++){
                var curr = q.Dequeue();
                if(curr.left is null && curr.right is null){
                    return level;
                }

                if(curr.left is not null) q.Enqueue(curr.left);
                if(curr.right is not null) q.Enqueue(curr.right);
            }
            level++;
        }
        return level;
    }
}
