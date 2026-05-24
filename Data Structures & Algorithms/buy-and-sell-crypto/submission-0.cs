public class Solution {
    public int MaxProfit(int[] prices) {
        int minSoFar = prices[0];
        int maxProfit = 0;
        int potentialProfit = 0;
        
        for (int i = 1; i < prices.Length; i++) {
            potentialProfit = prices[i] - minSoFar;

            if (potentialProfit > maxProfit)
                maxProfit = potentialProfit;

            if (prices[i] < minSoFar)
                minSoFar = prices[i];
        }
        
        return maxProfit;
    }
}
