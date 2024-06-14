func pivotIndex(nums []int) int {
    leftSum := 0
    rightSum := 0
    n := len(nums)
    a := n - 1

    for(a > 0){
        rightSum += nums[a]
        a--
    }

    
    for(a < n){
        if(rightSum == leftSum){
            return a
        }

        leftSum += nums[a]
        a ++
        if(a < n){
            rightSum -= nums[a]
        }
    }

    return -1

}