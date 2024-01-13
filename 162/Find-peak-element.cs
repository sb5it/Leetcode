public class Solution {
    public int FindPeakElement(int[] nums) {
        int left = 0, right = nums.Length -1;
        while (left <= right) {
            var m = left + ((right - left) / 2);
            if (m > 0 && nums[m - 1] > nums[m]) {
                right = m - 1;
            } else if (m < nums.Length - 1 && nums[m+1] > nums[m]) {
                left = m + 1;
            } else {
                return m;
            }
        }

        return -1;
    }
}
