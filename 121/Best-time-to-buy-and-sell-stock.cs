public class Solution {
    public int MaxProfit(int[] prices) {
        int left = 0, right = 1, profit = 0, maxProfit = 0;
        
        while (right < prices.Length){
            profit = prices[right]-prices[left];
            if (profit <= 0){
                left = right;
            } else {
                maxProfit = Math.Max(maxProfit, profit);
            }
            right++;
        }
        return maxProfit;
    }
}
