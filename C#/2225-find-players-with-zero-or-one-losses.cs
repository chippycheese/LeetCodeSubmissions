public class Solution {
    public IList<IList<int>> FindWinners(int[][] matches) {
        
        List<int> Winners = new List<int>();
        List<int> Second = new List<int>();
        Hashtable numberNames = new Hashtable();

        for(int cnt = 0; cnt < matches.Length; cnt++){
            if(numberNames[matches[cnt][0]] == null){
                numberNames.Add(matches[cnt][0],0);
            }
            if(numberNames[matches[cnt][1]] == null){
                numberNames.Add(matches[cnt][1],0);
            }
            
            int numberOfLosses = Convert.ToInt32(numberNames[matches[cnt][1]]);
            numberOfLosses ++;
            numberNames[matches[cnt][1]] = numberOfLosses;
        }
    

        List<int> listOfWinners = new List<int>();
        List<int> listOfSeconds = new List<int>();
        
        foreach(var key in numberNames.Keys){
            if(Convert.ToInt32(numberNames[key]) == 0){
                listOfWinners.Add(Convert.ToInt32(key));
            }else if(Convert.ToInt32(numberNames[key]) == 1){
                listOfSeconds.Add(Convert.ToInt32(key));
            }
        }
        listOfWinners.Sort();
        listOfSeconds.Sort();

        IList<IList<int>> finalList = new List<IList<int>>();
        finalList.Add(listOfWinners);
        finalList.Add(listOfSeconds);
        return finalList;
    }
}