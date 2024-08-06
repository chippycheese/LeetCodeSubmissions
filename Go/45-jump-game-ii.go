func jump(nums []int) int {
    jumps := 0
    end := len(nums)-1
    currentMax := 0
    x := 0
    for(x >= 0){
        if(x >= end){
            return jumps
        }
        if(currentMax < x + nums[x]){
            currentMax = x + nums[x]
        }
        x --
        if(x == -1){
            jumps ++
            x = currentMax
        }
    }
    
    return jumps
}