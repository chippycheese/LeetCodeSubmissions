public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int[] finalNumbs = new int[nums.Length];
        int x = 0;
        int y = 0;
        for(int cnt = 0; cnt < nums.Length; cnt ++){
            if(nums[cnt] != val){
                nums[cnt - y] = nums[cnt];
                x++;
            }else{
                y++;
            }
        }
        return x;

    }
}