class Solution {
    public int islandPerimeter(int[][] grid) {
        int rows = grid.length;
        int cols = grid[0].length;

        int totalSides = 0;

        for(int x = 0; x< cols; x++){
            for(int y = 0; y < rows; y++){
                
                if(grid[y][x] == 1){
                    totalSides += 4;
                    if(positionCheck(grid,x-1,y)){
                        totalSides -= 1;
                    }
                    if(positionCheck(grid,x+1,y)){
                        totalSides -= 1;
                    }
                    if(positionCheck(grid,x,y-1)){
                        totalSides -= 1;
                    }
                    if(positionCheck(grid,x,y+1)){
                        totalSides -= 1;
                    }


                }


            }
        }
        return totalSides;
    }

    public boolean positionCheck(int[][] grid, int x, int y) {
        try{
            if(grid[y][x] == 1){
                return true;
            }
            return false;
        }catch(Exception e){
            return false;
        }
    }
}