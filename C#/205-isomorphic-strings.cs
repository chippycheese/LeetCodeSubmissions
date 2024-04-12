public class Solution {
    public bool IsIsomorphic(string s, string t) {
        
        var sletterDictionary = new Dictionary<string, int>();
        var tletterDictionary = new Dictionary<string, int>();

        for(int cnt = 0; cnt < s.Length; cnt++){
            if (sletterDictionary.ContainsKey(s[cnt].ToString())){
                if(sletterDictionary[s[cnt].ToString()] != t[cnt]){
                    return false;
                }
            }else if (tletterDictionary.ContainsKey(t[cnt].ToString())){
                if(tletterDictionary[t[cnt].ToString()] != s[cnt]){
                    return false;
                }
            }else{
                sletterDictionary.Add(s[cnt].ToString(), t[cnt]);
                tletterDictionary.Add(t[cnt].ToString(), s[cnt]);
            }
        }
        return true;
    }
}