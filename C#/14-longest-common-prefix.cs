public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        string longestPrefix = strs[0];
        
        for(int a = 1; a < strs.Length; a++){
            string Builder = "";
            for(int b = 0; b < strs[a].Length && b < longestPrefix.Length; b++){
                if(strs[a][b] == longestPrefix[b]){
                    Builder = Builder + strs[a][b];
                }else{
                    break;
                }
            }
            longestPrefix = Builder;
            
        }

        return longestPrefix;

    }
}