func maxVowels(s string, k int) int {

    maxAmount := 0
    amount := 0
    x:= 0
    
    for(x < len(s)){
        
        if(x >= k && letterIsVowel(s[x-k]) ){
            amount --
        }

        if(letterIsVowel(s[x])){
            amount ++
        }
        
        if(amount > maxAmount){
            maxAmount ++
        }
        x++
    }
    return maxAmount
}

func letterIsVowel(s byte) bool{
    return s == 'a' ||
            s == 'e' ||
            s == 'i' ||
            s == 'o' ||
            s == 'u' ||
            s == 'A' ||
            s == 'E' ||
            s == 'I' ||
            s == 'O' ||
            s == 'U'
}