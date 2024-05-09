public class Solution {
    public long MaximumHappinessSum(int[] happiness, int k) {
        Array.Sort(happiness);
        long maxHappy = 0;
        int y = 0;
        for(int x = happiness.Length-1; x >= 0; x--){
            maxHappy += Math.Max((happiness[x] - y),0);
            
            y++;
            if(y == k){
                break;
            }
        }
        return maxHappy;
    }
}