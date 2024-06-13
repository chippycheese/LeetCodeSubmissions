func findMaxAverage(nums []int, k int) float64 {
    
    max := 0
    a := 0

    currentSum := 0
    for(a < k){
        currentSum += nums[a]
        a++
    }
    max = currentSum

    a = 0
    for(a+k < len(nums)){
        currentSum -= nums[a]
        a ++
        currentSum += nums[a+k-1]
        if(currentSum > max){
            max = currentSum
        }
    }

    return float64(max) / float64(k)
}