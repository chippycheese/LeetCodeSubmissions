public class Solution {

    public int MinFallingPathSum(int[][] matrix) {
        
        if(matrix.GetLength(0) == 1){
            return matrix[0][0];
        }

        List<int> finalOptions = new List<int>();
        for(int y = 1; y < matrix.GetLength(0); y++){
            finalOptions.Clear();
            for(int x = 0; x < matrix.GetLength(0); x++){
                
                List<int> possibleOptions = new List<int>();
                possibleOptions.Add(matrix[y-1][x] + matrix[y][x]);
                if(x-1 >= 0){
                    possibleOptions.Add(matrix[y-1][x-1] + matrix[y][x]);
                }
                if(x+1 < matrix.GetLength(0)){
                    possibleOptions.Add(matrix[y-1][x+1] + matrix[y][x]);
                }
                matrix[y][x] = possibleOptions.Min();
                Console.WriteLine(matrix[y][x]);
                finalOptions.Add(matrix[y][x]);
            }
        }

        return finalOptions.Min();
    }

}