public class Solution {
    public bool IsPowerOfFour(int n) {
        while(n % 4 == 0 && n != 0 && n != 1){
            n = n / 4;
        }
        return n == 1;
    }
}