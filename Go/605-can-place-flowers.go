func canPlaceFlowers(flowerbed []int, n int) bool {
    i := 0

    for(i < len(flowerbed)){
        if(flowerbed[i] == 1){
            i++
            continue
        }
        if(len(flowerbed) == 1){
            flowerbed[i] = 1
            n --
        }else if(i == 0){
            if(flowerbed[i+1] == 0){
                flowerbed[i] = 1
                n --
            }
        }else if(i == len(flowerbed)-1){
            if(flowerbed[i-1] == 0){
                flowerbed[i] = 1
                n --
            }
        }else{
            if(flowerbed[i-1] == 0 && flowerbed[i+1] == 0){
                flowerbed[i] = 1
                n --
            }
        }
        i++
    }
    
    if( n <= 0 ){
        return true
    }else{
        return false
    }

}