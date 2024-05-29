func countBits(n int) []int {
    
    var arr []int
    
    a := 0
    pow := 2

    for(a<=n){
        if(a == 0){
            arr = append(arr,0)
        }else if(a == 1){
            arr = append(arr,1)
        }else{
            if(a - (pow * 2) == 0){
                pow = pow * 2
            }
            arr = append(arr, arr[a-pow] +1)
        }
        a ++
    }
    return arr
}