public class Solution {
    public int MissingNumber(int[] nums) 
    {
        var hash = new HashSet<int>(nums);
        for(int i = 0; i <= nums.Length; i++)
        {
            if(!hash.Contains(i))
            {
                return i;
            }
        }

        return nums.Length;
    }
}
