public class Solution {
    public int NumRescueBoats(int[] people, int limit) {
        Array.Sort(people);
        int pointer1 = 0;
        int pointer2 = people.Length -1;
        int boatTotal = 0;
        while(pointer2 >= pointer1){
            if(people[pointer2] + people[pointer1] <= limit){
                pointer1 ++;
            }   
            pointer2 --;
            boatTotal ++;
            
        }
        return boatTotal;
    }
}