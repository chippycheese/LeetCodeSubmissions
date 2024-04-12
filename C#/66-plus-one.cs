public class Solution {
    public int[] PlusOne(int[] digits) {
        List<int> backwardList = new List<int>();
        int carry = 1;
        for(int x = digits.Length-1; x >= 0; x--){
            if(digits[x]+carry >= 10){
                backwardList.Add(0);
                carry = 1;
            }else{
                backwardList.Add(digits[x]+carry);
                carry = 0;
            }
        }
        if(carry == 1){
            backwardList.Add(carry);
        }
        int[] finalList = new int[backwardList.Count];
        for(int cnt = 0; cnt < finalList.Length; cnt++){
            finalList[cnt] = backwardList[backwardList.Count-cnt-1];
        }
        return finalList;
    }
}