public class Solution {
    public int MaxSubArray(int[] nums) {
        var localMax = 0;
        var globalMax = int.MinValue;
        for(int i = 0; i < nums.Length; i++){
            localMax = Math.Max(nums[i], nums[i] + localMax);
            if(localMax > globalMax){
                globalMax = localMax;
            }
        }

        return globalMax;
    }
}
