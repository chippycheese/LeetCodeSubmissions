public class Solution {
    public int SingleNumber(int[] nums) {
        int final = 0;
        foreach(var num in nums){
            final = final ^ num;
        }
        return final;
    }
}