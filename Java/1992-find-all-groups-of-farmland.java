class Solution {
    public int[][] findFarmland(int[][] land) {

        int cols = land.length;
        int rows = land[0].length;

        ArrayList<int[]> allLands = new ArrayList<>();

        for(int x = 0; x < cols; x++){
            for(int y = 0; y < rows; y++){
                if(land[x][y] == 1){
                    int[] fLand = farmlandFound(land, x, y);
                    //System.out.printf("[%s,%s,%s,%s],",fLand[0],fLand[1],fLand[2],fLand[3]);
                    allLands.add(fLand);
                }
            }
        }
        
        return convertToArray(allLands);
    }

    public int[] farmlandFound(int[][] land, int x, int y){
        int cols = land.length;
        int rows = land[0].length;

        int c = x;
        int d = y;
        for(int a = x; a < cols; a++){
            if(land[a][y] == 0){
                break;
            }
            c = a;
        }
        for(int b = y; b < rows; b++){
            if(land[x][b] == 0){
                break;
            }
            d = b;
        }

        for(int a = x; a <= c; a++){
            for(int b = y; b <= d; b++){
                land[a][b] = 0;
            }
        }

        return new int[]{x,y,c,d};
    }

    public static int[][] convertToArray(List<int[]> list) {
        int[][] newArray = new int[list.size()][];
        for (int i = 0; i < list.size(); i++) {
            newArray[i] = list.get(i);
        }
        return newArray;
    }
}