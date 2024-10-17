public class Solution {
    public int PathSum(TreeNode root, int targetSum) {
        var sumFreqMap = new Dictionary<long, int>();
        sumFreqMap[0] = 1;
        return Traverse(root, targetSum, 0, sumFreqMap);
    }

    public int Traverse(TreeNode node, int targetSum, long currentSum, Dictionary<long, int> sumFreqMap){
        if(node is null) return 0;

        currentSum+=node.val;
        
        var numberOfPaths = sumFreqMap.GetValueOrDefault(currentSum - targetSum, 0);
        
        sumFreqMap[currentSum] = sumFreqMap.GetValueOrDefault(currentSum, 0) + 1;

        numberOfPaths += 
            Traverse(node.left, targetSum, currentSum, sumFreqMap) 
                + Traverse(node.right, targetSum, currentSum, sumFreqMap);
        
        sumFreqMap[currentSum]--;
        return numberOfPaths;
    }
}
