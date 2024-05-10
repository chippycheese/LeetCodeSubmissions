public class Solution {
    public int[] KthSmallestPrimeFraction(int[] arr, int k) {
        int pointer1 = 0;
        int pointer2 = arr.Length - 1;

        PriorityQueue<int[],float> heap = new PriorityQueue<int[],float>();

        while(pointer1 < pointer2){
            int[] pairing = {arr[pointer1],arr[pointer2]};
            float value = (float)arr[pointer1] / (float)arr[pointer2];
            heap.Enqueue(pairing, value );
            pointer2 --;
            if(pointer2 == pointer1){
                pointer2 = arr.Length -1;
                pointer1 ++;
            }
        }
        for(int x = 0; x < k ; x++){
            var index = heap.Dequeue();
            if(x+1 == k){
                return index;
            }
        }

        var finalArr = new int[2];
        return finalArr;
    }

    
}