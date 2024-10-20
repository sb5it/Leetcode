public class Solution {
    public int MaxDepth(TreeNode root) {
        if (root is null) return 0;
        var result = 0;
        var q = new Queue<TreeNode>();
        q.Enqueue(root);
        while(q.Count > 0){
            result++;
            var length = q.Count;
            for(int i = 0; i < length; i++){
                var curr = q.Dequeue();
                if(curr.left is not null) q.Enqueue(curr.left);
                if(curr.right is not null) q.Enqueue(curr.right);
            }
        }

        return result;
    }
}
