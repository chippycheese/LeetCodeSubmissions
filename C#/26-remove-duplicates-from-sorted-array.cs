public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int current = nums[0];
        int x = 1;
        for(int cnt = 1; cnt < nums.Length;cnt++){
            if(nums[cnt] != current){
                nums[x] = nums[cnt];
                current = nums[cnt];
                x++;
            }
        }
        return x;
    }
}