func canJump(nums []int) bool {
    end := len(nums)-1
    currentMax := 0
    x := 0
    for(x < end && (x < currentMax || nums[x] > 0)){
        if(currentMax < x + nums[x]){
            currentMax = x + nums[x]
        }
        if(x < currentMax || nums[x] > 0){
            x++
        }
    }
    return x == end
}