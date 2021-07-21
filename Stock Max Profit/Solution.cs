public class Solution {
    public int MaxProfit(int[] prices) {
        
        //base case if array is empty / only one element
        if (prices.Length < 2){
            return 0;
        }
        
        //var for max profit
        int maxProfit = 0;
        
        //for loop to loop through each day
        for(int i = 0; i < prices.Length; i++){
            
            //had to put variables here so min and max aren't remembered from previous days
            int min = 2147483647;
            int max = -1;
            int profit = -1;
            
            //calculates min
            if(prices[i] < min){
                min = prices[i];
            }
            
            //inner for loop that starts at current day and loops to find max
            for(int j = i; j < prices.Length; j++){
                
                if (prices[j] > max){
                    max = prices[j];
                }
                
            }
            
            //calculates profit with min from current day, and the max of the rest of the days onward
            profit = max - min;
            
            
            //gets max profit which IS remembered since the variable is OUTSIDE the for loops
            if(profit > maxProfit){
                maxProfit = profit;
            }
            
        }
        
        //there is no profit, return 0
        if(maxProfit <= 0){
            return 0;
        }
        
        //return max profit
        return maxProfit;
    }
}



