func maximumDifference(nums []int) int {

    max := -1
    current := 0
    x := len(nums) - 1
    for(x > 0){
        current += nums[x] - nums[x-1]
        
        if(current > max){
            max = current
        }

        if(current < 0){
            current = 0
        }
        x --
    }
    
    if(max == 0){
        return -1
    }
    return max;
}