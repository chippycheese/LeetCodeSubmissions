func isPalindrome(s string) bool {
    s = cleanString(s)
    x := 0
    y := len(s) -1

    for(x < y){
        if(s[x] != s[y]){
            return false
        }
        x ++
        y --
    }

    return true
}

func cleanString(input string) string {
	re := regexp.MustCompile(`[^a-zA-Z0-9]+`)
	cleaned := re.ReplaceAllString(input, "")
	lowercase := strings.ToLower(cleaned)
	return lowercase
}