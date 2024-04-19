class Solution {
    public int numIslands(char[][] grid) {
        int rows = grid.length;
        int cols = grid[0].length;

        char[][] grid2 = getCharGrid(cols, rows);
        int totalIslands = 0;

        
        for(int y = 0; y < rows; y++){
            for(int x = 0; x< cols; x++){
                System.out.print(grid[y][x]);
                if(grid[y][x] == '1' && grid2[y][x] == '0'){
                    totalIslands += 1;
                    islandSearch(grid,grid2, x , y);
                }
            }
        }
        return totalIslands;
    }

    public void islandSearch(char[][] grid, char[][] grid2, int x, int y){
        
        if(grid[y][x] == '1' && grid2[y][x] == '0'){
            grid2[y][x] = '1';
            if(positionCheck(grid,x-1,y)){
                islandSearch(grid,grid2, x-1 , y);
            }
            if(positionCheck(grid,x+1,y)){
                islandSearch(grid,grid2, x+1 , y);
            }
            if(positionCheck(grid,x,y-1)){
                islandSearch(grid,grid2, x, y-1);
            }
            if(positionCheck(grid,x,y+1)){
                islandSearch(grid,grid2, x , y+1);
            }
        }
        
    }

    public char[][] getCharGrid(int rows, int cols){
        char[][] grid = new char[cols][rows];
        for(int y = 0; y < rows; y++){
            for(int x = 0; x < cols; x++){
                grid[x][y] = '0';
            }
        }
        return grid;
    }

    public boolean positionCheck(char[][] grid, int x, int y) {
        try{
            if(grid[y][x] == '1'){
                return true;
            }
            return false;
        }catch(Exception e){
            return false;
        }
    }
    
}