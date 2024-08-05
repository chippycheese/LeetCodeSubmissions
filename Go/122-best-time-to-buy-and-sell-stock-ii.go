func maxProfit(prices []int) int {
    x := len(prices) - 1
    totalProfit := 0

    for(x > 0){
        if(prices[x] > prices[x-1]){
            totalProfit += ( prices[x] - prices[x-1])
        }
        x --
    }

    return totalProfit
}