func equalPairs(grid [][]int) int {
    
    matches := 0
    a := 0

    for(a < len(grid[0])){

        b := 0
        
        for(b < len(grid[0])){
            
            arr := make([]int, len(grid[0]))
            c := 0
            for(c < len(grid[0])){
                arr[c] = grid[c][b]
                c++
            }
           

           if(reflect.DeepEqual(grid[a], arr)){
              matches ++
           }
           b++           
        }
        a++
    }
    return matches
}