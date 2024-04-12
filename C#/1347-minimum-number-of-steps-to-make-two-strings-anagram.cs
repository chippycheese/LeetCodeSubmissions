public class Solution {
    public int MinSteps(string s, string t) {
        int count = 0;
        var alpha = "abcdefghijklmnopqrstuvwxyz";
        for(int cnt = 0; cnt < alpha.Length; cnt ++){
            var sTotalCount = s.Count(x => x == alpha[cnt]);
            var tTotalCount = t.Count(x => x == alpha[cnt]);
            count += Math.Abs(sTotalCount-tTotalCount);
        }
        return count/2;
    }
}