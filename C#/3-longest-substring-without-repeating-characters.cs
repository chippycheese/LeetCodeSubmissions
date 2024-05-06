public class Solution {
    public int LengthOfLongestSubstring(string s) {

        Hashtable characterIndex = new Hashtable();

        int largest = 0;
        int index = 0;
        int count = 0;
        while(index <s.Length){  
            if(!characterIndex.ContainsKey(s[index])){
                characterIndex.Add(s[index],index);
                count++;
                if(count > largest){
                    largest = count;
                }
            }else{
                count = 0;
                index = (int)characterIndex[s[index]];
                characterIndex.Clear();
            }
            index++;
        }

        return largest;
    }
}