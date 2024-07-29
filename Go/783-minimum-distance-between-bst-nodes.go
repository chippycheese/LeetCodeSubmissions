/**
 * Definition for a binary tree node.
 * type TreeNode struct {
 *     Val int
 *     Left *TreeNode
 *     Right *TreeNode
 * }
 */
 func minDiffInBST(root *TreeNode) int {
    minDiff := 9999999
    inOrder(root, nil, &minDiff)
    return minDiff
}

func inOrder(root *TreeNode, prevNode *TreeNode, minDiff *int) *TreeNode{
    if(root == nil){
        return nil
    }
    if(root.Left != nil){
        prevNode = inOrder(root.Left, prevNode, minDiff)
    }
    if(prevNode != nil){
        fmt.Println(prevNode.Val)
        diff := root.Val - prevNode.Val
        if(diff < *minDiff){
            *minDiff = diff    
        }
    }
    
    prevNode = root
    if(root.Right != nil){
        prevNode = inOrder(root.Right, prevNode, minDiff)
    }
    return prevNode
}