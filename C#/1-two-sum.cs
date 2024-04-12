public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        for(int a = 0; a < nums.GetLength(0); a ++){
            for(int b = a+1; b < nums.GetLength(0); b ++){
                if(a != b && (nums[a] + nums[b] == target)){
                    int[] sum = new int[2];
                    sum[0] = a;
                    sum[1] = b;
                    return sum;
                }
            }   
        }
        return null;
    }
}