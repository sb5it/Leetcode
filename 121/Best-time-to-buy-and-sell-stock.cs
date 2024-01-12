public class Solution {
    public int MaxProfit(int[] prices) {
        int left = 0, profit = 0, maxProfit = 0;
        
        for (int right = 1; right < prices.Length; right++) {
             profit = prices[right]-prices[left];
            if (profit <= 0) {
                left = right;
            } else {
                maxProfit = Math.Max(maxProfit, profit);
            }
        }
        return maxProfit;
    }
}
