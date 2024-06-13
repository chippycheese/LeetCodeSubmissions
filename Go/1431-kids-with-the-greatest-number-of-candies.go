func kidsWithCandies(candies []int, extraCandies int) []bool {
    max := 0
    n := len(candies)

    a := 0
    for(a < n){
        if(candies[a] > max){
            max = candies[a]
        }
        a ++
    }
    
    var final []bool
    
    b := 0
    for(b < n){
        if(candies[b] + extraCandies >= max){
            final = append(final, true)
        }else{
            final = append(final, false)
        }
        b ++
    }
    return final
}