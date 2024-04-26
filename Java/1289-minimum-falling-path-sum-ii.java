class Solution {
    public int minFallingPathSum(int[][] grid) {
        int size = grid.length;

        int[][] grid2 = new int[size][size];
        for(int y = 0; y < size; y++){
            for(int x = 0; x < size; x++){
                if(y == 0){
                    grid2[y][x] = grid[y][x];
                }else{
                    grid2[y][x] =  999999999;
                }
            }
        }


        for(int y = 1; y < size; y++){
            for(int x = 0; x < size; x++){
                for(int a = 0; a < size; a++){
                    if(x != a){
                        if(grid[y][x] + grid2[y-1][a] < grid2[y][x] ){
                            grid2[y][x] = grid[y][x] + grid2[y-1][a];
                        }
                    }
                }
            }
        }

        //finds min of last layer
        int min = grid2[size-1][0];
        for(int b = 0; b < size; b++){
            if(grid2[size-1][b]<min){
                min = grid2[size-1][b];
            }
        }
        return min;
    }
}