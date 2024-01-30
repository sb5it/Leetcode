public class Solution {
    public bool CanJump(int[] nums) {
        int jumpGoal = nums.Length - 1;
        for(int i = nums.Length - 1; i >= 0; i--){
            if (i + nums[i] >= jumpGoal)
                jumpGoal = i;
        }
        return jumpGoal == 0;
    }
}
