public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var dict = new Dictionary<int, int>();
        var result = new int[2];
        for(int i = 0; i < nums.Length; i++){
            var needed = target - nums[i];
            if(dict.ContainsKey(needed)){
                result[0] = dict[needed];
                result[1] = i;
            } else {
                dict[nums[i]] = i;
            }
        }

        return result;
    }
}
