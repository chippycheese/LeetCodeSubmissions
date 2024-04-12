public class Solution {
    public bool UniqueOccurrences(int[] arr) {
        
        Dictionary<string, int>  data = new Dictionary<string, int> ();
        for(int cnt = 0; cnt <arr.Length; cnt++){
            if(data.ContainsKey(arr[cnt].ToString())){
                var val = data[arr[cnt].ToString()];
                val += 1;
                data[arr[cnt].ToString()] = val;
            }else{
                data.Add(arr[cnt].ToString(),1);
            }
        }
        var numberOfSameModes = data
            .GroupBy(pair => pair.Value)
            .Where(group => group.Count() > 1);
        
        return !(numberOfSameModes.Count() > 0);
    }
}