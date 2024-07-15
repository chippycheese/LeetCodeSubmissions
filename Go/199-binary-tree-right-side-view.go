/**
 * Definition for a binary tree node.
 * type TreeNode struct {
 *     Val int
 *     Left *TreeNode
 *     Right *TreeNode
 * }
 */
func rightSideView(root *TreeNode) []int {
    vision := make([]int , 0)
    return searching(root, 1, vision)
}

func searching(root *TreeNode, depth int, vision []int) []int{
    if(root == nil){
        return vision;
    }
    if(depth > len(vision)){
        vision = append(vision, root.Val)
    }

    vision = searching(root.Right, depth+1, vision)
    vision = searching(root.Left, depth+1, vision)
    return vision
}