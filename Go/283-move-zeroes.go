func moveZeroes(nums []int)  {
    zeroCount := len(nums)
    a := 0
    b := 0

    for(a < len(nums)){
        if (nums[a] != 0){
            nums[b] = nums[a]
            b ++
        }else{
            zeroCount --
        }
        a ++
    }
    for(zeroCount < len(nums)){
        nums[zeroCount] = 0
        zeroCount ++
    }
        
}