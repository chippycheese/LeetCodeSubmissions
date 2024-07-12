func canVisitAllRooms(rooms [][]int) bool {
    visited := make([]bool, len(rooms))
    visited[0] = true
    visited = visitRoom(rooms, 0, visited)
    a := 0
    for(a < len(visited)){
        if(!visited[a]){
            return false
        }
        a++
    }
    return true
}

func visitRoom(rooms[][]int, currentRoom int, visited []bool) []bool {
    a := 0
    if(len(rooms[currentRoom]) == 0){
        return visited
    }
    for(a < len(rooms[currentRoom])){
        num := rooms[currentRoom][a]
        if(!visited[num]){
            visited[num] = true
            visited = visitRoom(rooms, num, visited)
        }
        a++
    }
    return visited;
}