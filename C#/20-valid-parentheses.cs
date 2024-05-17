public class Solution {
    public bool IsValid(string s) {
        LinkedList<char> stack = new LinkedList<char>();
        int count = 0;
        for(int c = 0; c < s.Length; c++){
            if(s[c] == '(' || s[c] == '{' || s[c] == '['){
                stack.AddLast(s[c]);
                count ++;
            }else if(count > 0){
                if(s[c] == ')' && stack.Last.Value == '('){
                    stack.RemoveLast();
                    count --;
                }else if(s[c] == '}' && stack.Last.Value == '{'){
                    stack.RemoveLast();
                    count --;
                }else if(s[c] == ']' && stack.Last.Value == '['){
                    stack.RemoveLast();
                    count --;
                }else{
                    return false;
                }
            }else{
                return false;
            }
        }
        return count == 0;
    }
}