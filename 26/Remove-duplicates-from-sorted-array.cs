public class Solution {
    public int RemoveDuplicates(int[] nums) {
        var hashSet = new HashSet<int>();
        var currentPosition = 0;
        for(int i = 0; i < nums.Length;){
            if(hashSet.Contains(nums[i])){
                i++;
            } else {
                hashSet.Add(nums[i]);
                if(currentPosition != i)
                    nums[currentPosition] = nums[i];
                i++;
                currentPosition++;
            }
        }
        return hashSet.Count;
    }
}
