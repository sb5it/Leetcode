public class Solution {
    public TreeNode ReverseOddLevels(TreeNode root) {
        if (root == null) return root;

        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        var level = 0;
        while (queue.Count > 0) {

            int levelSize = queue.Count;
            var currentLevel = new List<TreeNode>();

            for (int i = 0; i < levelSize; i++) {
                var currentNode = queue.Dequeue();
                currentLevel.Add(currentNode);

                if (currentNode.left != null) queue.Enqueue(currentNode.left);
                if (currentNode.right != null) queue.Enqueue(currentNode.right);
            }
            if(level % 2 != 0){
                var reversedValues = currentLevel.Select(n => n.val).ToArray();
                Array.Reverse(reversedValues);
                for(int i = 0; i<reversedValues.Length;i++){
                    currentLevel[i].val = reversedValues[i];
                }
            }

            level++;
        }
        return root;
    }
}
