public class Solution {
    public int StrStr(string haystack, string needle) {
        if(haystack.Contains(needle)){
            for(int x = 0; x < haystack.Length - needle.Length +1; x++){
                for(int y = 0; y < needle.Length ; y ++){
                    Console.WriteLine(haystack[x + y] + "/" +needle[y]);
                    if(haystack[x + y] != needle[y]){
                        break;
                    }else if(y + 1 == needle.Length){
                        return x;
                    }
                }
            }
            return -1;
        }else{
            return -1;
        }
    }
}