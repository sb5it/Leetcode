public class Solution {
    public int MaxProfit(int[] prices) {
        int minPrice = int.MaxValue, profit = 0, maxProfit = 0;
        
        for(int i = 0; i < prices.Length; i++) {
            minPrice = Math.Min(minPrice, prices[i]);
            profit = prices[i] - minPrice;
            maxProfit = Math.Max(maxProfit, profit);
        }
        return maxProfit;
    }
}
