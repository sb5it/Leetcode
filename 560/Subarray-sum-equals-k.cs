public class Solution {
    public int SubarraySum(int[] nums, int k) {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        dict.Add(0, 1); 

        int prefixSum = 0, count = 0;
        for(int i = 0; i< nums.Length; i++) {
            prefixSum += nums[i];
            
            if(dict.ContainsKey(prefixSum - k))
                count += dict[prefixSum - k];

            dict[prefixSum] = dict.TryGetValue(prefixSum, out int current) ? current + 1 : 1;
        }

        return count;
    }
}
