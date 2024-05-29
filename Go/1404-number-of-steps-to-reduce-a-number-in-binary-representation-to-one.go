func numSteps(s string) int {
    if(len(s) == 1){
        return 0
    }
    a := len(s) - 1
    car := 0
    steps := 0
    for(a > 0){
        if(s[a] == '0' && car == 1 || s[a] == '1' && car == 0){
            car = 1
            steps+=2
        }else{
            steps++
        }
        a --
    }
    return steps + car;
}