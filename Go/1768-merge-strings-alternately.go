func mergeAlternately(word1 string, word2 string) string {
    word1Len := len(word1)
    word2Len := len(word2)
    max := word1Len
    if(word2Len > word1Len) {
        max = word2Len
    }
    i := 0
    finalString := ""
    for(i < max) {
        if(i < word1Len){
            finalString = finalString + string(word1[i])
        }
        if(i < word2Len){
            finalString = finalString + string(word2[i])
        }
        i++;
    }
    return finalString
}