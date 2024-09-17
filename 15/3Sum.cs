public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        var result = new List<IList<int>>();
        var hash = new HashSet<string>();
        for(int i = 0; i < nums.Length-2; i++){
            var indexes = TwoSum(nums, i + 1, 0 - nums[i]);
            foreach(var index in indexes){
                if(!hash.Contains($"{nums[i]}-{index[0]}-{index[1]}")){
                    hash.Add($"{nums[i]}-{index[0]}-{index[1]}");
                    result.Add(new int[] {nums[i], index[0], index[1]});
                } 
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
