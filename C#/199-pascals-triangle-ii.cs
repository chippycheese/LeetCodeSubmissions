public class Solution {
    public IList<int> GetRow(int rowIndex) {
        IList<int> CurrentRow = new List<int>();
        
        if(rowIndex == 0){
            CurrentRow.Add(1);
        }else if(rowIndex == 1){
            CurrentRow.Add(1);
            CurrentRow.Add(1);
        }else{
            IList<int> PreviousRow = new List<int>();
            PreviousRow.Add(1);
            PreviousRow.Add(1);
            int x = 2;
            while(x <= rowIndex){
                CurrentRow = new List<int>();
                CurrentRow.Add(1);
                for(int a = 0; a < x-1; a++){
                    CurrentRow.Add(PreviousRow[a] +PreviousRow[a+1]);    
                }
                x ++;
                CurrentRow.Add(1);
                PreviousRow = CurrentRow;
            }
        }
        
        return CurrentRow;
    }


}