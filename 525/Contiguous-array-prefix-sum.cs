public class Solution {
    public int FindMaxLength(int[] nums) {
        Dictionary<int, int> prefixSumToIndex = new Dictionary<int, int>();
        int prefixSum = 0;
        int maxLength = 0;
        prefixSumToIndex[0] = -1; 
        
        for (int i = 0; i < nums.Length; i++) {
            prefixSum += (nums[i] == 0) ? -1 : 1;
            
            if (prefixSumToIndex.ContainsKey(prefixSum)) {
                maxLength = Math.Max(maxLength, i - prefixSumToIndex[prefixSum]);
            } else {
                prefixSumToIndex[prefixSum] = i;
            }
        }
        
        return maxLength;
    }
}
