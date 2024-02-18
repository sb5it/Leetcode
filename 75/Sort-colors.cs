public class Solution {
    public void SortColors(int[] nums) {
        int i = 0, left = 0, right = nums.Length - 1;

        while(i <= right){
            if(nums[i] == 0){
                var temp = nums[left];
                nums[left] = nums[i];
                nums[i] = temp;
                i++;
                left++;
            } else if(nums[i] == 2){
                var temp = nums[right];
                nums[right] = nums[i];
                nums[i] = temp;
                right--;
            } else {
                i++;
            }
        }
    }
}
