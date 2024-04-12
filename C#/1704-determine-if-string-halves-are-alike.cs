public class Solution {
    public bool HalvesAreAlike(string s) {
        int halfway = s.Length/2;
        int counter = 0;
        for(int cnt = 0; cnt < s.Length; cnt++){
            if(IsAVowel(s[cnt])){
                if(cnt < halfway){
                    counter ++;
                }else{
                    counter --;
                }
            }
        }
        return counter == 0;
    }

    public bool IsAVowel(char s){
        return s == 'a' || s == 'e' || s == 'i' || s == 'o' || s =='u' ||
        s == 'A' || s == 'E' || s == 'I' || s == 'O' || s =='U';
    }
}