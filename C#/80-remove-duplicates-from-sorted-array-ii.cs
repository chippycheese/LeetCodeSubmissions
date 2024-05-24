public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int i = 0;
        int lastSeen = 999999999;
        int seen = 0;
        for(int a = 0; a < nums.Length; a++){
            if(nums[a] != lastSeen){
                lastSeen = nums[a];
                seen = 1;
            }else{
                seen ++;
            }

            if(seen < 3){
                nums[i] = nums[a];
                i++;
            }
            
            
        }
        return i;
    }
}