public class Solution {
    public int FindMin(int[] nums) {
        var min = nums[0];
        int left = 0, right = nums.Length - 1;
        while (left <= right){
            if (nums[left] < nums[right]) {
                min = Math.Min(nums[left], min);
                break;
            }
            var pivot = (left+right) / 2;
            min = Math.Min(min, nums[pivot]);
            if (nums[pivot] >= nums[left]) {
                left = pivot + 1;
            } else {
                right = pivot - 1;
            }
        }

        return min;
    }
}
