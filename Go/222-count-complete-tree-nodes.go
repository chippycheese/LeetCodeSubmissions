/**
 * Definition for a binary tree node.
 * type TreeNode struct {
 *     Val int
 *     Left *TreeNode
 *     Right *TreeNode
 * }
 */
func countNodes(root *TreeNode) int {
    val := 0
    if(root != nil){
        val ++
    }else{
        return val
    }

    val += countNodes(root.Left)
    val += countNodes(root.Right)

    return val

}