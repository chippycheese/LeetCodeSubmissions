public class Solution {
    public bool BackspaceCompare(string s, string t) {
        return RewriteString(s) == RewriteString(t);
    }


    public string RewriteString(string str){
        for(int a = 0; a <str.Length; a ++){
            if(str[a] == '#'){
                str = BackspaceACharacter(str, a);
                a -= 2;
                if(a < 0){
                    a = -1;
                }
            }
        }
        return str;
    }

    public string BackspaceACharacter(string str, int position){
        StringBuilder strBuild
            = new StringBuilder(str);

        strBuild.Remove(position,1);
        if(position -1 >= 0){
            strBuild.Remove(position-1,1);
        }
        return strBuild.ToString();
    }
    
}