public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        var result = new int[nums.Length];
        Array.Fill(result, 1);
        var prefix = 1;
        for(int i = 0; i< nums.Length; i++){
            result[i] = prefix;
            prefix*= nums[i];
        }
        var postFix = 1;
        for(int i = nums.Length - 1; i >= 0; i--){
            result[i] *= postFix;
            postFix *= nums[i];  
        }

        return result;
    }
}
