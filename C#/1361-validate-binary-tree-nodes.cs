public class Solution {

    public static int x = 0;

    public bool ValidateBinaryTreeNodes(int n, int[] leftChild, int[] rightChild) {
        
        if(MergedTree(n,leftChild,rightChild)){
            return false;
        }

        //find tree top
        List<int> treeTop = FindTreeTop(n, leftChild, rightChild);
        if(treeTop.Count != 1){
            return false;
        }
        x = 0;
        int startNode = treeTop[0];
        
        var leftBranch = true;
        var rightBranch = true;
        if(leftChild[startNode] != -1){
            x++;
            leftBranch = ValidateBranch(leftChild[startNode], n,leftChild,rightChild);
        }
        if(rightChild[startNode] != -1){
            x++;
            rightBranch = ValidateBranch(rightChild[startNode], n,leftChild,rightChild);
        }
        if(x != n-1){
            return false;
        }

        return leftBranch && rightBranch; 
    }

    public List<int> FindTreeTop(int n, int[] leftChild, int[] rightChild) {
        List<int> treeTop = new();
        List<int> leftList = new();
        leftList.AddRange(leftChild);
        List<int> rightList = new();
        rightList.AddRange(rightChild);

        int openConnections = 0;

        for(int a = 0; a < n; a++ ){

            if(!leftList.Contains(a) && !rightList.Contains(a)){
                treeTop.Add(a);
            }

        }
        return treeTop;

    }

    public bool ValidateBranch(int a, int n, int[] leftChild, int[] rightChild){
        
        //Loop Detection
        if(x > n){
            return false;
        }
        if(x == n){
            return leftChild[a] == -1 && rightChild[a] == -1;
        }
        if(leftChild[a] != -1){
            Console.WriteLine("Node" + a.ToString() + "| Left: " + leftChild[a].ToString());
            x++;
            ValidateBranch(leftChild[a], n,leftChild,rightChild);
        }
        if(rightChild[a] != -1){
            Console.WriteLine("Node" + a.ToString() + "| Right: " + rightChild[a].ToString());
            x++;
            ValidateBranch(rightChild[a], n,leftChild,rightChild);
        }

        

        return true;
    }

    public bool MergedTree(int n, int[] leftChild, int[] rightChild){
        for(int a = 0; a < n; a++){
            bool found = false;
            for(int b = 0; b < n; b++){
                if(leftChild[b] == a){
                    if(found){
                        return true;
                    }else{
                        found = true;
                    }
                }
                if(rightChild[b] == a){
                    if(found){
                        return true;
                    }else{
                        found = true;
                    }
                }
            }
        }
        return false;
    }
    
}