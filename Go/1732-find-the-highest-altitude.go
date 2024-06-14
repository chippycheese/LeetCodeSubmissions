func largestAltitude(gain []int) int {
    
    a := 0
    b := len(gain)
    h := 0
    mH := h

    for(a < b){
        h += gain[a]
        if(h > mH){
            mH = h
        }
        a++
    }

    return mH
}n