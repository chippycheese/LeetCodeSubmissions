func reverseVowels(s string) string {
    a := 0
    b := len(s)
    oldStr := []rune(s)

    for(a < b){
        if(s[a] == 'a' || s[a] == 'e' || s[a] == 'i' || s[a] == 'o' ||s[a] == 'u' ||
           s[a] == 'A' || s[a] == 'E' || s[a] == 'I' || s[a] == 'O' ||s[a] == 'U'){
            for(b > a){
                b--
                if(s[b] == 'a' || s[b] == 'e' || s[b] == 'i' || s[b] == 'o' ||s[b] == 'u' ||
                   s[b] == 'A' || s[b] == 'E' || s[b] == 'I' || s[b] == 'O' ||s[b] == 'U'){
                    temp := oldStr[b]
                    oldStr[b] = oldStr[a]
                    oldStr[a] = temp
                    break;
                }
            }
        }
        a ++
    }
    s = string(oldStr)
    return s

}