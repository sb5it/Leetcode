public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        var result = new List<IList<int>>();
        for(int i = 0; i < nums.Length-2; i++){
            if (i > 0 && nums[i] == nums[i - 1]) continue;
            var indexes = TwoSum(nums, i + 1, 0 - nums[i]);
            foreach(var index in indexes){
                result.Add(new int[] {nums[i], index[0], index[1]});
            }
        }
        return result;
    }

    private IList<IList<int>> TwoSum(int[] nums, int left, int target){
        int right = nums.Length - 1;
        var result = new List<IList<int>>();
        while(left < right) {
            if (nums[left] + nums[right] == target){
                result.Add(new List<int> {nums[left], nums[right]});
                while (left < right && nums[left] == nums[left + 1]) left++;
                while (left < right && nums[right] == nums[right - 1]) right--;
                left++;
                right--;
            } else if(nums[left] + nums[right] > target){
                right--;
            } else {
                left++;
            }
        }
        return result;
    }
}
