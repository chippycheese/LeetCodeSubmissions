public class Solution {
    public bool IsPalindrome(int x) {
        var xStr = x.ToString();
        for(int a = 0; a< xStr.Length; a++){
            if(xStr[a] != xStr[xStr.Length-1-a]){
                return false;
            }
        }
        return true;
    }
}