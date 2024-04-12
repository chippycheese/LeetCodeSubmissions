/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public IList<int> LargestValues(TreeNode root) {
        if(root == null){
            return new List<int>();
        }
        List<List<int>> allValues = new List<List<int>> ();
        AddToList(0, root, allValues);
        

        List<int> FinalList = new List<int>();
        for(int cnt = 0; cnt < allValues.Count ;cnt++){
            FinalList.Add(FindMax(allValues[cnt]));
        }
        return FinalList;
    }
    
    public void AddToList(int x, TreeNode level, List<List<int>> allValues){
        if(allValues.Count == x){
            allValues.Add(new List<int>());
        }
        allValues[x].Add(level.val);
        
        if(level.left != null){
            AddToList(x+1, level.left, allValues);
        }
        if(level.right != null){
            AddToList(x+1, level.right, allValues);
        }
    }

    public int FindMax(List<int> row){
        int x = row[0];
        for(int cnt = 1; cnt < row.Count; cnt++){
            if(row[cnt] > x){
                x = row[cnt];
            }
        }
        return x;
    }

    
}