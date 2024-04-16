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
    public TreeNode AddOneRow(TreeNode root, int val, int depth) {
        
        if(depth == 1){
            TreeNode updatedRoot = new TreeNode();
            updatedRoot.val = val;
            updatedRoot.left = root;
            return updatedRoot;
        }

        CheckNode(root, val, 1, depth);
        return root;

    }

    public void CheckNode(TreeNode root, int val, int current, int depth){
        Console.WriteLine(current);
        if(current + 1 == depth){
            
                TreeNode updatedLeftRoot = new TreeNode();
                updatedLeftRoot.val = val;
                TreeNode updatedRightRoot = new TreeNode();
                updatedRightRoot.val = val;

                updatedLeftRoot.left = root.left;
                root.left = updatedLeftRoot;
                            
                updatedRightRoot.right = root.right;
                root.right = updatedRightRoot;
            
        }

        if(root.left != null ){
            CheckNode(root.left, val, current + 1, depth);
        }
        if(root.right != null ){
            CheckNode(root.right, val, current + 1, depth);
        }
    }

}