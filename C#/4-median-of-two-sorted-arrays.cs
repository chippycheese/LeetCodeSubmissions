public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int totalCount = (nums1.Length + nums2.Length)/2;
        int x = 0;
        int y = 0;

        if(nums1.Length == 0 && nums2.Length == 1){
            return nums2[0];
        }else if(nums1.Length == 1 && nums2.Length == 0){
            return nums1[0];
        }
        
        while(x+y < totalCount-1){

            FindNextNumber(nums1, nums2, ref x , ref y);
        }

        
        if((nums1.Length + nums2.Length) % 2 == 0){
            Console.WriteLine("Emptyu");
            double med = FindMed(nums1, nums2, ref x , ref y);
            FindNextNumber(nums1, nums2, ref x , ref y);
            double med2 = FindMed(nums1, nums2, ref x , ref y);
            med = (med + med2)/2;
            return med;
        }else{
            Console.WriteLine("NonE");
            FindNextNumber(nums1, nums2, ref x , ref y);
            double med = FindMed(nums1, nums2, ref x , ref y);
            return med;
        }
    }

    void FindNextNumber(int[] nums1, int[] nums2, ref int x, ref int y){
        if(x == nums1.Length){
            y++;
        }else if(y == nums2.Length){
            x++;
        }else{
            if(nums1[x] < nums2[y]){
                x++;
            }else{
                y++;
            }
        }
    }

    double FindMed(int[] nums1, int[] nums2, ref int x, ref int y){
        if(x == nums1.Length){
            return nums2[y];
        }else if(y == nums2.Length){
            return nums1[x];
        }else{
            if(nums1[x] < nums2[y]){
                return nums1[x];
            }else{
                return nums2[y];
            }
        }
    }
    
}