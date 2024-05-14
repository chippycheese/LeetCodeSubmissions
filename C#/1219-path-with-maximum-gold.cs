public class Solution {
    
    public int GetMaximumGold(int[][] grid) {
        int maxGold = 0;
        int rows = grid.Length;
        int columns = grid[0].Length;
        for(int x = 0; x < columns; x++){
            for(int y = 0; y < rows; y++){
                var gold = SearchNode(grid,x,y,columns, rows,0);        
                if(gold > maxGold){
                    maxGold = gold;
                }
            }
        }
        
        return maxGold;
    }

    public int SearchNode(int[][] grid, int x, int y, int mx, int my, int currentGold) {
        if( x < 0 || x >= mx || y < 0 || y >= my || grid[y][x] == 0){
            return 0;
        }
            int goldHere = grid[y][x];
            if(goldHere == 0){
                return 0;
            }
            currentGold += goldHere;
            grid[y][x] = 0;
            var a = SearchNode(grid, x-1, y,mx, my, currentGold);
            var b = SearchNode(grid, x, y-1,mx, my, currentGold);
            var c = SearchNode(grid, x+1, y,mx, my, currentGold);
            var d = SearchNode(grid, x, y+1,mx, my, currentGold);
            grid[y][x] = goldHere;
            return goldHere + Math.Max(Math.Max(a, b), Math.Max(c, d));
        
    }

}