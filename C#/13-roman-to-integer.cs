public class Solution {
    public int RomanToInt(string s) {
        int total = 0;
        if(s.Contains("CM")){
            total -= 200;
        }
        if(s.Contains("CD")){
            total -= 200;
        }
        if(s.Contains("XC")){
            total -= 20;
        }
        if(s.Contains("XL")){
            total -= 20;
        }
        if(s.Contains("IX")){
            total -= 2;
        }
        if(s.Contains("IV")){
            total -= 2;
        }

        for(int a = 0; a < s.Length; a++){
            switch(s[a]){
                case 'I':
                total += 1;
                break;
                case 'V':
                total += 5;
                break;
                case 'X':
                total += 10;
                break;
                case 'L':
                total += 50;
                break;
                case 'C':
                total += 100;
                break;
                case 'D':
                total += 500;
                break;
                case 'M':
                total += 1000;
                break;
            }
        }
        return total;
    }
}