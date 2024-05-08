public class Solution {
    public string[] FindRelativeRanks(int[] score) {
        int size = score.Length;
        PriorityQueue<int, int> heap = new PriorityQueue<int,int>();
        for(int x = 0 ; x < size ; x++){
            heap.Enqueue(x,score[x]);
        }

        String[] final = new String[size];
        for(int x = size-1; x >= 0 ; x--){
            var index = heap.Dequeue();
            if(x == 0){
                final[index] = "Gold Medal";
            }else if(x == 1){
                final[index] = "Silver Medal";
            }else if(x == 2){
                final[index] = "Bronze Medal";
            }else{
                final[index] = (x+1).ToString();
            }
            
        }
        return final;
    }
}