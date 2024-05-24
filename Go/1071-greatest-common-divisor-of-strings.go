func gcdOfStrings(str1 string, str2 string) string {

    if len(str1) < len(str2){
        temp := str1
        str1 = str2
        str2 = temp
    }

    a := 1   
    valid := ""
 
    for a <= len(str2) {
        test := substring(str2, 0, a)
        comparer := test
        comparer2 := test
        for (len(comparer) < len(str1)){
            comparer = comparer + test
        }
        for (len(comparer2) < len(str2)){
            comparer2 = comparer2 + test
        }

        if(comparer == str1 && comparer2 == str2){
            valid = test
        }
        a++
    }
    return valid
}

func substring(str1 string, index int, length int) string {
    fString := ""
    a := 0
    for (a < length){
        fString = fString + string(str1[a+index])
        a ++
    }
    return fString
}