public class Solution {
    public int LongestConsecutive(int[] nums) {
        if(nums is null || nums.Length == 0) return 0;
        var set = new HashSet<int>(nums);
        var longestStreak = 0;
        foreach(var i in set){
            if(!set.Contains(i-1)){
                var currentStreak = 0;
                var currentNumber = i;
                while (set.Contains(currentNumber)){
                    currentStreak++;
                    currentNumber++;
                }
                longestStreak = Math.Max(longestStreak, currentStreak);
            }
        }

        return longestStreak;
    }
}
