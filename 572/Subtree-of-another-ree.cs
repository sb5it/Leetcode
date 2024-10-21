public class Solution {
    public bool IsSubtree(TreeNode root, TreeNode subRoot) {
        var q = new Queue<TreeNode>();
        q.Enqueue(root);
        while(q.Count > 0){
            var len = q.Count;
            for(int i = 0; i < len; i++){
                var curr = q.Dequeue();
                if(curr.val == subRoot.val){
                    var isSame = IsSameTree(curr, subRoot);
                    if(isSame) return true;
                }
                if(curr.left is not null) q.Enqueue(curr.left);
                if(curr.right is not null) q.Enqueue(curr.right);
            }
        }

        return false;
    }

    private bool IsSameTree(TreeNode p, TreeNode q){
        if(p is null && q is null) return true;

        if(p is null || q is null) return false;

        if(p.val != q.val) return false;

        return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
    }
}
