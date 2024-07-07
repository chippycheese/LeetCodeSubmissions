func findMaxConsecutiveOnes(nums []int) int {
 
    maxAmount := 0
    amount := 0
    x:= 0
    
    for(x < len(nums)){

        if(nums[x] == 1 ){
            amount ++
        }else{
            amount = 0
        }
        
        if(amount > maxAmount){
            maxAmount ++
        }
        x++
    }
    return maxAmount
}
