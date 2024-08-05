/**
 * Definition for a binary tree node.
 * type TreeNode struct {
 *     Val int
 *     Left *TreeNode
 *     Right *TreeNode
 * }
 */
func hasPathSum(root *TreeNode, targetSum int) bool {
    
    if(root == nil){
        return false
    }
    
    if(root.Left == nil && root.Right == nil){
        if(targetSum - root.Val == 0){
            return true
        }
        
    }

    if(root.Left != nil){
        if(hasPathSum(root.Left, targetSum - root.Val)){
            return true
        }
    }
    if(root.Right != nil){
        if(hasPathSum(root.Right, targetSum - root.Val)){
            return true
        }
    }

    
    return false

}