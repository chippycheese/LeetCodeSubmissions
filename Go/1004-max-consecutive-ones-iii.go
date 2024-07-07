func longestOnes(nums []int, k int) int {
    
    maxAmount := 0
    amount := 0
    x := 0
    y :=0

    remainingFlips := k

    for(x < len(nums)){
        if(nums[x] == 1){
            amount ++
        }else if(nums[x] == 0 && remainingFlips > 0){
            remainingFlips --
            amount ++
        }else{
            if(k == 0){
                amount = 0
            }else{
                for(y < x){
                    y++
                    if(nums[y-1] == 0){
                        break;
                    }
                    amount --
                }
            }
        }

        x++

        if(remainingFlips >= 0){
            if(maxAmount < amount){
                maxAmount = amount
            }
        }


    }

    return maxAmount

}