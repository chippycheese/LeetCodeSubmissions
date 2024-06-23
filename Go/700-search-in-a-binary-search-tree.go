/**
 * Definition for a binary tree node.
 * type TreeNode struct {
 *     Val int
 *     Left *TreeNode
 *     Right *TreeNode
 * }
 */
func searchBST(root *TreeNode, val int) *TreeNode {
    return tree(root,val)
}

func tree(root *TreeNode, val int) *TreeNode {
    if(root == nil){
        return nil
    }else if(root.Val == val){
        return root
    }else if(root.Val > val){
        return tree(root.Left, val)
    }else{
        return tree(root.Right, val)
    }
}