public class Solution {
    public int[] SearchRange(int[] nums, int target) {
        int left = BSearch(nums, target, true);
        int right = BSearch(nums, target, false);

        return new [] { left, right };
    }

    private int BSearch(int[] nums, int target, bool leftBias){
        int left = 0, right = nums.Length -1;
        int i = -1;
        while (left <= right){
            int mid = (left + right) / 2;
            if(target > nums[mid]){
                left = mid + 1;
            } else if(target < nums[mid]){
                right = mid -1;
            } else {
                i = mid;
                if (leftBias){
                    right = mid -1;
                } else{
                    left = mid + 1;
                }
            }
        }

        return i;
    }
}
