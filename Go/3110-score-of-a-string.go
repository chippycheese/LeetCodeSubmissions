func scoreOfString(s string) int {
    diff := 0.0
    for i := 0; i < len(s)-1; i++ {
        f := int(s[i])
        l := int(s[i+1])
        diff = diff + math.Abs(float64(f-l))
    }
    
    return int(diff);
}