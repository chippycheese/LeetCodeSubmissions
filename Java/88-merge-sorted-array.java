class Solution {
    public void merge(int[] nums1, int m, int[] nums2, int n) {
        int[] num1Holder = new int[m];
        for(int cnt = 0; cnt < m; cnt++){
            num1Holder[cnt] = nums1[cnt];
        }

        int x = 0;
        int y = 0;
        for(int cnt = 0; cnt <m+n; cnt++){
            if(x < m && y < n){
                if(num1Holder[x] < nums2[y]){
                    nums1[cnt] = num1Holder[x];
                    x++;
                }else{
                    nums1[cnt] = nums2[y];
                    y++;
                }
            }else if(x < m){
                nums1[cnt] = num1Holder[x];
                x++;
            }else{
                nums1[cnt] = nums2[y];
                y++;
            }
        }
        
    }
}