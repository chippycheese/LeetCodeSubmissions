func letterCombinations(digits string) []string {

    if(len(digits) == 0){
        return nil
    }

    letters := map[byte]string{
		'2': "abc",
		'3': "def",
        '4': "ghi",
        '5': "jkl",
        '6': "mno",
        '7': "pqrs",
        '8': "tuv",
        '9': "wxyz",
	}
    var combos []string
    combos = append(combos, "")
    return add(digits, 0, letters, combos)
}

func add(digits string, position int, letters map[byte]string, combos []string) []string{

    letterDigits := letters[digits[position]]
    var newCombos []string

    b := 0
    for(b < len(combos)){
        previous := combos[b]
        a := 0
        for(a < len(letterDigits)){
            newCombos = append(newCombos, previous + string( letterDigits[a] ))
            a ++
        }
        b ++
    }
    
    if(position+1 < len(digits)){
        newCombos = add(digits, position + 1, letters, newCombos)
    }

    return newCombos
}