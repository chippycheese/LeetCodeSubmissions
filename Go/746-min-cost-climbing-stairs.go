func minCostClimbingStairs(cost []int) int {
    s :=  make([]int, len(cost))

    a := len(cost)-1
    for(a >= 0){
        
        sa := 0
        sb := 0
        if(a + 1  < len(cost)){
            sa = s[a+1]
        }
        if(a + 2  < len(cost)){
            sb = s[a+2]
        }
        
        if(sa > sb){
            s[a] = cost[a] + sb
        }else{
            s[a] = cost[a] + sa
        }

        a --
    }
    
    if(s[0] > s[1]){
        return s[1]
    }else{
        return s[0]
    }

}