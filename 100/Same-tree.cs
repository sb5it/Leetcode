public class Solution {
    public bool IsSameTree(TreeNode p, TreeNode q) {
        if(p is null && q is null) return true;
        var pQ = new Queue<TreeNode>();
        var qQ = new Queue<TreeNode>();
        pQ.Enqueue(p);
        qQ.Enqueue(q);
        while(pQ.Count > 0 && qQ.Count > 0 && pQ.Count == qQ.Count){
            var len = pQ.Count;
            for(int i = 0; i < len; i++){
                var pCurr = pQ.Dequeue();
                var qCurr = qQ.Dequeue();
                if(pCurr is null && qCurr is not null
                    || pCurr is not null && qCurr is null) return false;
                if(pCurr?.val != qCurr?.val) return false;
                if (pCurr is not null) pQ.Enqueue(pCurr.left);
                if (pCurr is not null) pQ.Enqueue(pCurr.right);
                if (qCurr is not null) qQ.Enqueue(qCurr.left);
                if (qCurr is not null) qQ.Enqueue(qCurr.right);
            }
        }

        return pQ.Count == qQ.Count;
    }
}
