class Solution {

    public boolean validPath(int n, int[][] edges, int source, int destination) {
        //making a graph
        List<List<Integer>> graph = new ArrayList<>();
        for (int i = 0; i < n; i++) {
            graph.add(new ArrayList<>());
        }
        for (int[] edge : edges) {
            graph.get(edge[0]).add(edge[1]);
            graph.get(edge[1]).add(edge[0]);
        }
        
        //visited to prevent loops
        int[] visited = new int[n];
        
        
        return search(graph, source, destination, visited);
    }

    public boolean search(List<List<Integer>> graph, int source, int destination, int[] visited) {

        if (source == destination){
            return true;
        }
        visited[source] = 1;
        
        for (int neighbor : graph.get(source)) {
            if (visited[neighbor] == 0) {
                if (search(graph, neighbor, destination, visited)){
                    return true;
                }
                     
            }
        }
        return false; 
    }
}