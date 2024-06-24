func maxArea(height []int) int {
    max := 0
    a := 0
    b := len(height)-1
    for(a < b){
        current := 0
        if(height[a] > height[b]){
            current = (b-a) * height[b]
        }else{
            current = (b-a) * height[a]
        }
        if(current > max){
            max = current
        }
        if(height[a] > height[b]){
            b --
        }else{
            a ++
        }
    }
    return max
}