/**
 * @param {number[][]} grid
 * @return {number}
 */
var matrixScore = function(grid) {
    var rows = grid.length
    var columns = grid[0].length
    for(var y = 0; y < rows; y++){
        if(grid[y][0] == 0){
            flipHor(grid,y);
        }
    }

    for(var x = 0; x < columns; x++){
        
        var zeros = 0;
        var ones = 0;
        for(var y = 0; y < rows; y++){
            if(grid[y][x] == 0){
                zeros ++;
            }else{
                ones ++;
            }
        }
        if(zeros > ones){
            flipVer(grid,x);
        }
    }

    return addGrid(grid);
};

function flipHor(grid, row){
    var columns = grid[0].length
    for(var x = 0; x < columns; x++){
        if(grid[row][x] == 0){
            grid[row][x] = 1;
        }else{
            grid[row][x] = 0;
        }
    }
}

function flipVer(grid, column){
    var rows = grid.length
    for(var y = 0; y < rows; y++){
        if(grid[y][column] == 0){
            grid[y][column] = 1;
        }else{
            grid[y][column] = 0;
        }
    }
}

function addGrid(grid){
    var rows = grid.length
    var columns = grid[0].length

    var total = 0;
    for(var y = 0; y < rows; y++){
        value = 0;
        for(var x = 0; x < columns; x++){ 
            if(grid[y][x] == 1){
                value += 2 ** ( Math.abs(columns-1-x))
            }
        }
        total += value;
    }
    
    return total;
}