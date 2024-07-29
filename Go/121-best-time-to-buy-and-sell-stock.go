func maxProfit(prices []int) int {
    
    max := 0
    current := 0
    x := len(prices) - 1
    for(x > 0){
        current += prices[x] - prices[x-1]
        
        if(current > max){
            max = current
        }

        if(current < 0){
            current = 0
        }
        x --
    }
    
    return max;
}