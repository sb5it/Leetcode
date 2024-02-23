public class Solution {
    public int LengthOfLIS(int[] nums) {
        var LIS = new List<int>(nums.Select(s => 1).ToArray());
        for(int i = nums.Length - 1; i >= 0; i--){
            for(int j = i + 1; j < nums.Length; j++){
                if(nums[i] < nums[j]) {
                    LIS[i] = Math.Max(LIS[i], LIS[j] + 1);
                }
            }
        }
        return LIS.Max();
    }
}
